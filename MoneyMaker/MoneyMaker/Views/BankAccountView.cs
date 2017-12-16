using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MoneyMaker.ViewModels;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Models;
using MoneyMaker.Helpers;

namespace MoneyMaker.Views
{
    public partial class BankAccountView : MoneyMakerView
    {

        #region Attributes
        private DepotModel depotModel;
        private BankAccountModel bankModel;
        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();
        private Currency.CurrencyCode defaultCurrency = SettingsModel.getInstance().getCurrency();
        private Dictionary<string, double> currencyRates = new Dictionary<string, double>();

        private DateTime start = DateTime.Now.AddDays(-7);
        private DateTime end = DateTime.Now;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public BankAccountView()
        {
            InitializeComponent();
            bankModel = new BankAccountModel();
            depotModel = new DepotModel();

            cbxTransactionType.DisplayMember = "Description";
            cbxTransactionType.Items.Add(new TransactionItem { Description = "Einzahlen", TransactionType = 'c' });
            cbxTransactionType.Items.Add(new TransactionItem { Description = "Auszahlen", TransactionType = 't' });
            cbxTransactionType.SelectedIndex = 0;

            splitContainerMain.Panel2Collapsed = true;

            startDate.MaxDate = DateTime.Now;
            startDate.Value = DateTime.Now.AddDays(-7);

            setDefaultCurrencyInLabel();
            mainForm.setHeadline("Bank");
        }

        /// <summary>
        /// Loads and fills the listview with transaction items
        /// </summary>
        private async void refreshTransactionsListviewAsync()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Lädt Transaktionsdaten...");
            
            decimal? accBalance = bankModel.getBank().AccountBalance;
            
            lvTransactions.Items.Clear();
            Task<List<TransactionItem>> task = Task.Run(() => bankModel.getTransactions(start,end));
            var transactions = await task;

            var income = new Dictionary<string, decimal?>();
            var outcome = new Dictionary<string, decimal?>();

            foreach (TransactionItem transaction in transactions)
            {
                var lvItem = new ListViewItem(transaction.toArray());
                lvItem.Tag = transaction;
                lvTransactions.Items.Add(lvItem);

                var date = transaction.Created.ToShortDateString();
                switch (transaction.TransactionType)
                {
                    case 'p': case 't': case 'x':
                        if (!outcome.ContainsKey(date))
                        {
                            outcome.Add(date, transaction.Amount);
                        }
                        else
                        {
                            outcome[date] += transaction.Amount;
                        }
                        break;
                    case 's': case 'c': case 'y':
                        if (!income.ContainsKey(date))
                        {
                            income.Add(date, transaction.Amount);
                        }
                        else
                        {
                            income[date] += transaction.Amount;
                        }
                        break;
                }
            }

            drawChart(income,outcome);

            lblAccountBalance.Text = ((double) accBalance).ToString("0.00");
            
            lvTransactions.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent); 

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
        }

        /// <summary>
        /// Draws the chart
        /// </summary>
        private void drawChart(Dictionary<string,decimal?> income, Dictionary<string, decimal?> outcome)
        {
            chart.Series.Clear();
             
            var seriesIncome = new Series("Einzahlungen");
            seriesIncome.Color = System.Drawing.Color.ForestGreen;
            seriesIncome.ChartArea = chart.ChartAreas[0].Name;

            var seriesCosts = new Series("Auszahlungen");
            seriesCosts.Color = System.Drawing.Color.Tomato;
            seriesCosts.ChartArea = chart.ChartAreas[0].Name;

            foreach (var item in income)
            {
                seriesIncome.Points.AddXY(item.Key, item.Value);
            }

            foreach (var item in outcome)
            {
                seriesCosts.Points.AddXY(item.Key, item.Value);
            }

            chart.Series.Add(seriesIncome);
            chart.Series.Add(seriesCosts);
        }

        /// <summary>
        /// Resets the form fields on the right
        /// </summary>
        private void resetFields()
        {
            tbAmount.Text = "";
            tbDescription.Text = "";
            dpCreated.Value = DateTime.Now;
        }

        /// <summary>
        /// Intervall changes
        /// </summary>
        private void date_ValueChanged(object sender, EventArgs e)
        {
            start = startDate.Value;
            end = endDate.Value;
            refreshTransactionsListviewAsync();
        }

        #region Button click methods

        /// <summary>
        /// Button click method to refresh the listview
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            refreshTransactionsListviewAsync();
        }

        /// <summary>
        /// Stores a new transaction to database
        /// </summary>
        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            btnAddTransaction.Visible = true;
            var transactionType = (TransactionItem) cbxTransactionType.SelectedItem;

            decimal amount;
            bool result = decimal.TryParse(tbAmount.Text, out amount);
            if (result)
            {
                var bank = bankModel.getBank();
                char[] burden = { 't', 'p' };
                if (bank != null)
                {
                    if (burden.Contains(transactionType.TransactionType) && amount > bank.AccountBalance)
                    {
                        MessageBox.Show("Sie können Ihr Konto nicht überziehen!");
                    }
                    else
                    {
                        var item = new TransactionItem()
                        {
                            BankAccountID = bank.BankAccountID,
                            Description = tbDescription.Text,
                            Amount = amount,
                            Created = dpCreated.Value,
                            TransactionType = transactionType.TransactionType,
                        };
                        bankModel.saveTransaction(item);
                        refreshTransactionsListviewAsync();
                        resetFields();
                    } 
                }
            }
            else
            {
                MessageBox.Show("Die Summe muss eine Zahl sein!");
            }
        }

        /// <summary>
        /// Opens the edit form on the right
        /// </summary>
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = false;
            btnAddTransaction.Visible = false;
            resetFields();
        }

        /// <summary>
        /// Closes the form on the right
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = true;
            btnAddTransaction.Visible = true;
            resetFields();
        }

        /// <summary>
        /// Asynchronous method to load the depot value
        /// </summary>
        private async void btnUpdateDepot_Click(object sender, EventArgs e)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Börsendaten werden abgerufen...");

            var depot = depotModel.getUserDepot();
            var stocks = depotModel.getStocks();
            decimal? depotBalance = 0;
            foreach (var item in stocks)
            {
                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, item.symbol);
                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                SingleQuote stockData = await taskStockData;

                if (stockData != null)
                {
                    if (stockData.Currency.ShortCode == defaultCurrency)
                    {
                        depotBalance += (stockData.CurrentPrice * item.Quantity);
                    }
                    else
                    {
                        string currencyPair = "" + stockData.Currency.ShortCode + defaultCurrency;
                        if (!currencyRates.ContainsKey(currencyPair))
                        {
                            Task<CurrencyRate> taskCurrencyData = Task.Run(() => new FinanceAPI(webFinanceStrategy, currencyPair).getCurrencyRate());
                            CurrencyRate currencyRate = await taskCurrencyData;
                            if (currencyRate != null)
                            {
                                depotBalance += stockData.CurrentPrice * item.Quantity * Convert.ToDecimal( currencyRate.Rate );
                                currencyRates.Add(currencyPair, currencyRate.Rate);
                            }
                        }
                        else
                        {
                            depotBalance += stockData.CurrentPrice * item.Quantity * Convert.ToDecimal( currencyRates[currencyPair]);
                        }
                    }
                }
            }

            lblDepotBalance.Text = ((double) depotBalance).ToString("0.00");

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        /// <summary>
        /// Toggles the chart
        /// </summary>
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            if(splitListChart.Panel2Collapsed)
            {
                splitListChart.Panel2Collapsed = false;
                btnShowChart.Text = "Chart ausblenden";
            }
            else
            {
                splitListChart.Panel2Collapsed = true;
                btnShowChart.Text = "Chart einblenden";
            }
        }

        #endregion

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckDigital(ref sender, ref e);
        }
    }
}
