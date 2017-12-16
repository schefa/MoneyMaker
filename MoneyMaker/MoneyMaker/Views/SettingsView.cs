using System;
using System.Windows.Forms;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using System.Threading.Tasks;
using System.Linq;
using MoneyMaker.Models.Database;
using MoneyMaker.Helpers;
using System.Drawing;

namespace MoneyMaker.Views
{
    public partial class SettingsView : MoneyMakerView
    {
        private Currency.CurrencyCode defaultCurrency = SettingsModel.getInstance().getCurrency();
        private decimal defaultCapitalGainTax = SettingsModel.getInstance().getCapitalGainTax();
        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();
         
        public SettingsView()
        {
            InitializeComponent();
            mainForm.setHeadline("Einstellungen");
             
                tabSettings.TabPages.Remove(tabPage2);  

            cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Google);
            cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Yahoo);
            cbxDataProvider.SelectedItem = webFinanceStrategy;

            var currencies = FinanceUnifier.Currencies;
            cbxCurrencies.DisplayMember = "Name";
            foreach (var item in currencies)
            {
                cbxCurrencies.Items.Add(item);
            }
            cbxCurrencies.SelectedItem = currencies.FirstOrDefault(x=>x.ShortCode == defaultCurrency);

            nudCapitalGainTax.Value = defaultCapitalGainTax;

            cbxDataProvider.SelectedIndexChanged += new EventHandler(cbxDataProvider_SelectedIndexChanged);
            cbxCurrencies.SelectedIndexChanged += new EventHandler(cbxCurrencies_SelectedIndexChanged);
        }

        private async void cbxDataProvider_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = (FinanceAPI.FinanceStrategies)cbxDataProvider.SelectedItem;
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Datenquelle wird in "+ selected.ToString() +" geändert...");
            Task task = Task.Run(() => SettingsModel.getInstance().setFinanceDataProvider(selected));
            await task;
            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        private async void cbxCurrencies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = (Currency)cbxCurrencies.SelectedItem;
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Währung wird in " + selected.Name + " geändert...");
            Task task = Task.Run(() => SettingsModel.getInstance().setCurrency(selected.ShortCode));
            await task;
            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        private async void nudCapitalGainTax_ValueChanged(object sender, EventArgs e)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Kapitalerstragssteuer wird geändert");
            Task task = Task.Run(() => SettingsModel.getInstance().setCapitalGainTax(nudCapitalGainTax.Value));
            await task;
            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }
        

    }
}
