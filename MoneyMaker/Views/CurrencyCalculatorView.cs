using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.Models;
using MoneyMaker.ViewModels;
using MoneyMaker.Libraries.Webservices.Entities;

namespace MoneyMaker.Views
{
    public partial class CurrencyCalculatorView : MoneyMakerView
    {

        private Currency.CurrencyCode defaultCurrency = SettingsModel.getInstance().getCurrency();
        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();
        private List<Currency> currencies = FinanceUnifier.Currencies;
        private List<CurrencyRate> currencyRates = new List<CurrencyRate>();
        
        public CurrencyCalculatorView()
        {
            InitializeComponent();
            mainForm.setHeadline("Währungsrechner");
            
            cbxCurrencyFrom.DisplayMember = "Name";
            foreach (var item in currencies)
            {
                cbxCurrencyFrom.Items.Add(item);
            }
            var selected = currencies.FirstOrDefault(x => x.ShortCode == defaultCurrency);
            cbxCurrencyFrom.SelectedItem = selected;

            cbxCurrencyFrom.SelectedIndexChanged += new EventHandler(cbxCurrencyFrom_SelectedIndexChanged);
            nupCurrencyFrom.ValueChanged += new EventHandler(nupCurrencyFrom_ValueChanged);
            getCurrencyRatesAsync(selected);
        }

        private void cbxCurrencyFrom_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = (Currency)cbxCurrencyFrom.SelectedItem;
            getCurrencyRatesAsync(selected);
        }

        private async void getCurrencyRatesAsync(Currency selected)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Währungsdaten " + selected.Name + " geladen...");

            FinanceAPI finance;
            switch (webFinanceStrategy)
            {
                case FinanceAPI.FinanceStrategies.Yahoo:
                    StringBuilder symbol = new StringBuilder();
                    for (int i = 0; i < currencies.Count; i++)
                    {
                        symbol.Append(selected.ShortCode + currencies[i].ShortCode.ToString());
                        if(i < (currencies.Count-1))
                            symbol.Append("','");
                    }

                    finance = new FinanceAPI(webFinanceStrategy, symbol.ToString());
                    Task<List<CurrencyRate>> task = Task.Run(() => finance.getCurrencyRates());
                    currencyRates = await task;
                    break;

                case FinanceAPI.FinanceStrategies.Google:

                    foreach (var item in currencies)
                    {
                        string currencySymbol = ""+ selected.ShortCode + item.ShortCode;
                        finance = new FinanceAPI(webFinanceStrategy, currencySymbol);
                        Task<CurrencyRate> taskGoogle = Task.Run(() => finance.getCurrencyRate());
                        var currencyRate = await taskGoogle;
                        if(currencyRate != null)
                            currencyRates.Add(currencyRate);
                    }
                    break;
            }

            drawCurrencyRates(currencyRates);

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);

        }

        private void drawCurrencyRates(List<CurrencyRate> currencyRates)
        {
            panelCurrencies.Controls.Clear();
            decimal quantity = nupCurrencyFrom.Value;
            int height = 26;

            for (int i = 0; i < currencyRates.Count; i++)
            {
                Label labelBox = new Label();
                labelBox.Name = "lblCurrencyBox" + currencies[i].Name + i;
                labelBox.Text = ((double) quantity * currencyRates[i].Rate).ToString();
                labelBox.Size = new Size(90, height);
                labelBox.BorderStyle = BorderStyle.FixedSingle;
                labelBox.Location = new Point(0, i * (height + 4));
                labelBox.Tag =  currencyRates[i];
                labelBox.TextAlign = ContentAlignment.MiddleRight;

                Label labelSymbol = new Label();
                labelSymbol.Name = "lblCurrencySymbol" + currencies[i].Name + i;
                labelSymbol.Text = currencies[i].Symbol;
                labelSymbol.Size = new Size(30, height);
                labelSymbol.Location = new Point(100, i * (height + 4));
                labelSymbol.TextAlign = ContentAlignment.MiddleLeft;

                Label labelName = new Label();
                labelName.Name = "lblCurrencyName" + currencies[i].Name + i;
                labelName.Text = currencies[i].Name;
                labelName.Size = new Size(130, height);
                labelName.Location = new Point(140, i * (height+4));
                labelName.TextAlign = ContentAlignment.MiddleLeft;

                panelCurrencies.Controls.Add(labelBox);
                panelCurrencies.Controls.Add(labelSymbol);
                panelCurrencies.Controls.Add(labelName);

            }
        }

        private void nupCurrencyFrom_ValueChanged(object sender, EventArgs e)
        {
            if(currencyRates != null)
                drawCurrencyRates(currencyRates);
        }
    }
}
