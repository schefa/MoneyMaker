using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Helpers;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.Libraries.Webservices.Entities;

namespace MoneyMaker.Views
{
    public partial class DepotView : MoneyMakerView
    {

        private DateTime startDate = DateTime.Now.AddMonths(-9);
        private DateTime endDate = DateTime.Now;

        private DepotModel depotModel;
        private BankAccountModel bankModel;
        private StockListitem selectedStock = null;
        private SingleQuote stockLatestPrice;
        private Dictionary<string, double> currencyRates = new Dictionary<string, double>();

        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();
        private Currency.CurrencyCode defaultCurrency = SettingsModel.getInstance().getCurrency();

        private ListViewColumnSorter lvwColumnSorter;

        /// <summary>
        /// Constructor
        /// </summary>
        public DepotView()
        {
            InitializeComponent();
            depotModel = new DepotModel(mainForm.User);
            bankModel = new BankAccountModel(mainForm.User);

            refreshDepotDataAsync();
            updateStockPricesInListViewAsync();

            cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Google);
            cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Yahoo);
            cbxDataProvider.SelectedItem = webFinanceStrategy;
            
            lvwColumnSorter = new ListViewColumnSorter();
            lvDepot.ListViewItemSorter = lvwColumnSorter;

            lvDepot.Columns.Add("Buchwert");
            lvDepot.Columns.Add("Marktkapitalisierung");
            lvDepot.Columns.Add("50 Tage");
            lvDepot.Columns.Add("250 Tage");

            setDefaultCurrencyInLabel();
            mainForm.setHeadline("Depot");
            toggleToolbar(true);

            dpEnddate.Value = endDate;
            dpStartdate.MaxDate = DateTime.Now;
            dpStartdate.Value = startDate;

            dpEnddate.ValueChanged += new EventHandler(datetime_Changed);
            dpStartdate.ValueChanged += new EventHandler(datetime_Changed);
        }

        #region Listview Methods

        /// <summary>
        /// Changes the datetime and refreshes the chart asynchronously
        /// </summary>
        private void datetime_Changed(object sender, EventArgs e)
        {
            if(selectedStock != null)
            {
                startDate = dpStartdate.Value;
                endDate = dpEnddate.Value;
                drawChart(selectedStock);
            }
        }

        /// <summary>
        /// Changes the selected item
        /// </summary>
        private void lvDepot_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = lvDepot.PointToClient(Control.MousePosition);
                ListViewHitTestInfo hitTest = lvDepot.HitTest(mousePos);

                var firstSelected = hitTest.Item;
                if (firstSelected?.Tag != null)
                {
                    selectedStock = (StockListitem)firstSelected.Tag;
                    loadChartDataAsync(selectedStock);
                }
                else
                {
                    cleanRightSidebar();
                }
            }
        }

        /// <summary>
        /// Refreshes the stocks list asynchronously
        /// </summary>
        private async void refreshDepotDataAsync()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapierdaten werden geladen...");
            
            lvDepot.Items.Clear();
            Task<List<StockListitem>> task = Task.Run(() => depotModel.getStocks());
            var stocks = await task;
            
            if(stocks != null)
            {
                foreach (StockListitem stock in stocks)
                {
                    var lvItem = new ListViewItem(stock.toStringArray());
                    lvItem.Tag = stock;
                    lvDepot.Items.Add(lvItem);
                }

                updateStockPricesInListViewAsync();

                if(!lvDepot.IsDisposed)
                {
                    lvDepot.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvDepot.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvDepot.Columns[2].Width = 120;
                }

            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        /// <summary>
        /// Sorts the column on click
        /// </summary>
        private void lvDepot_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        /// <summary>
        /// updates the latest stock prices in listview
        /// </summary>
        private async void updateStockPricesInListViewAsync()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapierdaten werden aktualisiert...");
            double depotCurrent = 0.00;
            double depotStart = 0.00;
            
            for (int i = 0; i < lvDepot.Items.Count && lvDepot.Items.Count > 0; i++)
            {

                StockListitem slItem = (StockListitem)lvDepot.Items[i].Tag;
                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, slItem.symbol);
                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                SingleQuote stockData = await taskStockData;
                if (stockData != null && null != lvDepot.Items[i])
                {
                    if(webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                    {
                        var yahooStock = (YahooSingleQuote)stockData;
                        slItem.BookValue = yahooStock.BookValue;
                        slItem.MarketCapitalization = yahooStock.MarketCapitalization;
                        slItem.FiftydayMovingAverage = yahooStock.FiftydayMovingAverage;
                        slItem.TwoHundreddayMovingAverage = yahooStock.TwoHundreddayMovingAverage;
                    }

                    slItem.Change = stockData.Change;
                    slItem.PriceCurrent = Convert.ToDouble(stockData.CurrentPrice);
                    
                    lvDepot.Items[i] = new ListViewItem(slItem.toStringArray(webFinanceStrategy));
                    lvDepot.Items[i].Tag = slItem;
                    if (slItem.Currency.ShortCode == defaultCurrency)
                    {
                        depotCurrent += (double)slItem.PriceCurrent * (double)slItem.Quantity;
                        depotStart += (double)slItem.PricePurchase * (double)slItem.Quantity;
                    }
                    else
                    {
                        string currencyPair = "" + slItem.Currency.ShortCode + defaultCurrency;
                        if(!currencyRates.ContainsKey(currencyPair))
                        {
                            Task<CurrencyRate> taskCurrencyData = Task.Run(() => new FinanceAPI(webFinanceStrategy, currencyPair).getCurrencyRate());
                            CurrencyRate currencyRate = await taskCurrencyData;
                            if (currencyRate != null)
                            {
                                depotCurrent += (double)slItem.PriceCurrent * (double)slItem.Quantity * currencyRate.Rate;
                                depotStart += (double)slItem.PricePurchase * (double)slItem.Quantity * currencyRate.Rate;
                                currencyRates.Add(currencyPair, currencyRate.Rate);
                            }
                        }
                        else
                        {
                            depotCurrent += (double)slItem.PriceCurrent * (double)slItem.Quantity * currencyRates[currencyPair];
                            depotStart += (double)slItem.PricePurchase * (double)slItem.Quantity * currencyRates[currencyPair];
                        }
                    }
                }
            }

            lblDepotCurrent.Text = depotCurrent.ToString("0.00");
            lblDepotStart.Text = depotStart.ToString("0.00");
            calculateDepotChanges();
            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        #endregion

        #region Button methods
        /// <summary>
        /// Selects the stock which the user searched for
        /// </summary>
        private void btnGetStock_Click(object sender, EventArgs e)
        {
            ComboBox cbMultiLine = stockSearchView.SearchBox;

            StockListitem watchlistStock = new StockListitem();
            YahooStockSearchResult selectedItem = (YahooStockSearchResult)cbMultiLine.SelectedItem;
           
            // Add Stock to List
            if (selectedItem != null)
            { 
                watchlistStock = depotModel.buildWatchlistStockItem(selectedItem, nupStockQuantity.Value);
                selectedStock = watchlistStock;
                makeBuyProposition();
            }
        }

        /// <summary>
        /// Sales the stock, removes it from depot and adds transaction
        /// </summary>
        private async void btnSale_Click(object sender, EventArgs e)
        {
            if(selectedStock != null && nupQuantity.Value <= selectedStock.Quantity )
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapier wird verkauft...");  

                Task task = Task.Run(() => depotModel.removeStock(selectedStock, nupQuantity.Value));
                await task;

                refreshDepotDataAsync();
                lblQuantityInput.Text = ( selectedStock.Quantity - nupQuantity.Value).ToString();

                drawChart();
                cleanRightSidebar();
                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
            }
        }

        /// <summary>
        /// Starts the buying process 
        /// </summary>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(selectedStock != null)
            {
                selectedStock.Quantity = Convert.ToInt32(nupStockQuantity.Value);
                saveStockAsync(selectedStock);
                refreshDepotDataAsync();
                toggleToolbar(true);
            }
        }

        /// <summary>
        /// Button click updates prices
        /// </summary>
        private void btnUpdatePrices_Click(object sender, EventArgs e)
        {
            updateStockPricesInListViewAsync();
        }

        private void btnDrawLineToggle_Click(object sender, EventArgs e)
        {

            var controls = panelChart.Controls;
            if (controls != null)
            {
                foreach (Control control in controls)
                {
                    if (control is StockChartView)
                    {
                        var chart = (StockChartView)control;
                        var splitMain = chart.SplitContainer;
                        splitMain.Panel2Collapsed = !splitMain.Panel2Collapsed;
                        chart.CreateNewTrendlineChecked = !chart.CreateNewTrendlineChecked;
                        chart.DrawingAllowed = !chart.DrawingAllowed;
                    }
                }
            }
        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            drawChart(selectedStock);
        }
        #endregion

        #region Buying process
        /// <summary>
        /// When user selects a stock, another dialog occurs where he can see his proposal
        /// </summary>
        private async void makeBuyProposition()
        {
            if(selectedStock != null)
            {

                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, selectedStock.symbol);
                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                stockLatestPrice = await taskStockData;
                if(stockLatestPrice != null && stockLatestPrice.CurrentPrice > 0)
                {
                    toggleToolbar(false);
                    selectedStock.PriceCurrent = Convert.ToDouble( stockLatestPrice.CurrentPrice );
                    lblBuyName.Text = selectedStock.name;
                    lblBuyPrice.Text = selectedStock.toPriceFormat(selectedStock.PriceCurrent);
                    var total = (selectedStock.PriceCurrent * Convert.ToDouble(nupStockQuantity.Value)); 
                    lblBuyTotal.Text = selectedStock.toPriceFormat(total);
                }
                else
                {
                    MessageBox.Show("Es konnten keine Preisinformationen für das Wertpapier gefunden werden.");
                }
            }
        }

        /// <summary>
        /// Stores the stock to database if bank has money
        /// </summary>
        private async void saveStockAsync(StockListitem watchlistStock)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapier wird gekauft...");

            FinanceAPI rest = new FinanceAPI(webFinanceStrategy, watchlistStock.symbol);
            Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
            stockLatestPrice = await taskStockData;

            if (stockLatestPrice != null)
            {
                watchlistStock.PurchaseDate = DateTime.Now;
                watchlistStock.PricePurchase = stockLatestPrice.CurrentPrice;
                watchlistStock.PriceCurrent = (double) stockLatestPrice.CurrentPrice;
                if(webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                {
                    var yahooStock = stockLatestPrice as YahooSingleQuote;
                    watchlistStock.BookValue = yahooStock.BookValue;
                    watchlistStock.MarketCapitalization = yahooStock.MarketCapitalization;
                    watchlistStock.FiftydayMovingAverage = yahooStock.FiftydayMovingAverage;
                    watchlistStock.TwoHundreddayMovingAverage = yahooStock.TwoHundreddayMovingAverage;
                }
                decimal totalSum = Convert.ToDecimal(watchlistStock.PriceCurrent * watchlistStock.Quantity);
                var bank = bankModel.getBank();

                if (totalSum <= bank.AccountBalance)
                {
                    Task<int> insertTask = Task.Run(()=> depotModel.insertStockToDepot(watchlistStock));
                    int id = await insertTask;
                    if(id > 0)
                    {
                        depotModel.saveTransaction(TransactionItem.TransactionTypeEnum.Purchase, watchlistStock);
                        watchlistStock.StocksMapID = id;

                        // Add to listview
                        var lvItem = new ListViewItem(watchlistStock.toStringArray());
                        lvItem.Tag = watchlistStock;
                        lvDepot.Items.Add(lvItem);

                        // Draw Chart
                        selectedStock = watchlistStock;
                        loadChartDataAsync(selectedStock);
                    }
                }
                else
                {
                    MessageBox.Show("Nicht genügend Geld auf der Bank");
                }
            }
            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        /// <summary>
        /// The selected number of stocks in the buy proposition
        /// </summary>
        private void nupStockQuantity_ValueChanged(object sender, EventArgs e)
        {
            var total = Convert.ToDouble(nupStockQuantity.Value) * selectedStock.PriceCurrent;
            lblBuyTotal.Text = selectedStock.toPriceFormat(total);
        }
        #endregion

        #region Details on the right sidebar

        /// <summary>
        /// updates the stock details on the right sidebar
        /// </summary>
        private void fillRightSidebarWithData()
        {
            if (stockLatestPrice != null)
            {
                lblDateInput.Text = stockLatestPrice.Date.ToShortDateString();
                lblOpenInput.Text = stockLatestPrice.toPriceFormat(stockLatestPrice.Open);
                lblCloseInput.Text = stockLatestPrice.toPriceFormat(stockLatestPrice.CurrentPrice);
                lblChangePercentageInput.Text = stockLatestPrice.ChangePercentage.ToString("+0.00%;-0.00%");
                lblChangePercentageInput.ForeColor = (stockLatestPrice.ChangePercentage >= 0) ? Color.Green : Color.Red;
                lblVolumeInput.Text = stockLatestPrice.Volume.ToString();
            }

            btnSale.Enabled = false;
            if (selectedStock != null)
            {
                additionalStockData(selectedStock);
            
                gbDetails.Text = selectedStock.name;
                lblQuantityInput.Text = selectedStock.Quantity.ToString();
                lblPurchaseDateInput.Text = selectedStock.PurchaseDate.ToShortDateString();

                btnSale.Enabled = true;
                nupQuantity.Maximum = Convert.ToDecimal(selectedStock.Quantity); 
                lblPricePurchaseInput.Text = selectedStock.toPriceFormat(selectedStock.PricePurchase);

                lblTotalValueInput.Text = selectedStock.toPriceFormat(selectedStock.PricePurchase * selectedStock.Quantity);
            }
        }

        /// <summary>
        /// Additional stock data (book value, market capilization, etc.)
        /// </summary>
        private void additionalStockData(StockListitem selectedStock)
        {
            if(selectedStock != null)
            {
                int height = 30;
                var fullHeight = (height) * 4;

                if (gbDetails.Controls.ContainsKey("pnDetailsAdditional"))
                {
                    gbDetails.Controls.RemoveByKey("pnDetailsAdditional");
                    gbDetails.Size = new Size(gbDetails.Size.Width, (gbDetails.Size.Height - fullHeight));
                    pnDetails.Location = new Point(pnDetails.Location.X, pnDetails.Location.Y - fullHeight);
                    gbBestand.Location = new Point(gbBestand.Location.X, gbBestand.Location.Y - fullHeight);
                    gbPurchaseData.Location = new Point(gbPurchaseData.Location.X, gbPurchaseData.Location.Y - fullHeight);
                }

                if (webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                {
                    var topControl = pnDetails.Location;
                    // Make box bigger
                    gbDetails.Size = new Size(gbDetails.Size.Width, (gbDetails.Size.Height + fullHeight));
                    pnDetails.Location = new Point(pnDetails.Location.X, pnDetails.Location.Y + fullHeight);
                    gbBestand.Location = new Point(gbBestand.Location.X, gbBestand.Location.Y + fullHeight);
                    gbPurchaseData.Location = new Point(gbPurchaseData.Location.X, gbPurchaseData.Location.Y + fullHeight);

                    string[] additionalStockDataLabel = { "Buchwert", "Marktkap.", "50-Tage", "250-Tage" };
                    string[] additionalStockData = { selectedStock.BookValue.ToString(), selectedStock.MarketCapitalization, selectedStock.FiftydayMovingAverage.ToString(), selectedStock.TwoHundreddayMovingAverage.ToString() };

                    Panel pnDetailsAdditional = new Panel();
                    pnDetailsAdditional.Name = "pnDetailsAdditional";
                    pnDetailsAdditional.Location = new Point(10, topControl.Y + 7);
                    pnDetailsAdditional.Size = new Size(216, fullHeight);
                    gbDetails.Controls.Add(pnDetailsAdditional);

                    for (int i = 0; i < 4; i++)
                    {
                        Label labelInfo = new Label();
                        labelInfo.Size = new Size(60, height);
                        labelInfo.Text = additionalStockDataLabel[i];
                        labelInfo.Location = new Point(0, (height * i));
                        Label labelBox = new Label();
                        labelBox.Text = additionalStockData[i];
                        labelBox.Size = new Size(90, height);
                        labelBox.Location = new Point(67, (height * i));
                        pnDetailsAdditional.Controls.Add(labelInfo);
                        pnDetailsAdditional.Controls.Add(labelBox);
                    }
                }
            }
        }

        /// <summary>
        /// Resets the right sidebar with its details
        /// </summary>
        private void cleanRightSidebar()
        {
            foreach (Control groupBox in panelRight.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control x in groupBox.Controls)
                    {
                        if (x is Label && ((Label)x).Name.Contains("Input"))
                        {
                            x.Text = "...";
                        }
                        else if(x is Panel)
                        {
                            foreach (Control y in x.Controls)
                            {
                                if (y is Label && ((Label)y).Name.Contains("Input"))
                                {
                                    y.Text = "...";
                                }
                            }
                        }
                    }
                }
            }
            gbDetails.Text = "Wertpapier";
            selectedStock = null;
            nupQuantity.Value = 0;
        }

        /// <summary>
        /// Changes the data provider
        /// </summary>
        private void cbxDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            webFinanceStrategy = (FinanceAPI.FinanceStrategies)cbxDataProvider.SelectedItem;
            loadChartDataAsync(selectedStock);
        }

        #endregion

        #region Chart method
        /// <summary>
        /// Draws the chart for stock
        /// </summary>
        private void drawChart(StockListitem stockItem = null)
        {
            panelChart.Controls.Clear();
            if (stockItem != null)
            {
                MoneyMakerView view = new StockChartView(stockItem, webFinanceStrategy, startDate, endDate);
                view.Dock = DockStyle.Fill;
                panelChart.Controls.Add(view);
            }
        }

        /// <summary>
        /// prepares data for stock chart and detail view
        /// </summary>
        private async void loadChartDataAsync(StockListitem selectedItem)
        {
            if(selectedItem != null)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Chart wird gezeichnet...");

                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, selectedItem.symbol);

                drawChart(selectedItem);

                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                stockLatestPrice = await taskStockData;
            
                if(stockLatestPrice != null)
                {  
                    fillRightSidebarWithData();
                    additionalStockData(selectedItem);
                    mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
                }
            }
        }
        #endregion

        /// <summary>
        /// Calculates the depot value changes and prints result in labels
        /// </summary>
        private void calculateDepotChanges()
        {
            double totalChange = (Convert.ToDouble(lblDepotCurrent.Text) - Convert.ToDouble(lblDepotStart.Text));
            lblDepotChangeTotal.Text = totalChange.ToString("+ 0.00;- 0.00");
            lblDepotChangeTotal.ForeColor = (totalChange >= 0) ? Color.Green : Color.Red;
            double changePercentage = totalChange / Convert.ToDouble(lblDepotStart.Text);
            if(!Double.IsNaN(changePercentage))
            {
                lblDepotChangePerc.Text = changePercentage.ToString("0.00%");
                lblDepotChangePerc.ForeColor = (totalChange >= 0) ? Color.Green : Color.Red;
            }
        }

        /// <summary>
        /// Shows and hides the buy proposition container
        /// </summary>
        private void toggleToolbar(bool value)
        {
            switch (value)
            {
                case true:
                    splitContainerToolbar.Panel2Collapsed = true;
                    splitContainerLeftTop.SplitterDistance = 46;
                    break;
                default: case false:
                    splitContainerToolbar.Panel2Collapsed = false;
                    splitContainerLeftTop.SplitterDistance = 90;
                    break;
            }
        }

    }
}
