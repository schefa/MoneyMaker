using MoneyMaker.Libraries.Webservices;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoneyMaker.Views
{
    public class MoneyMakerView : UserControl
    {
        protected FrmMain mainForm = FrmMain.Current;

        public MoneyMakerView()
        {
             
        }

        protected void setDefaultCurrencyInLabel()
        {
            var controls = getAllControls(this, typeof(Label));
            Currency.CurrencyCode defaultCurrency = SettingsModel.getInstance().getCurrency();
            foreach (Label c in controls)
            {
                if (c.GetType() == typeof(Label) && c.Name.Contains("Currency"))
                    c.Text = FinanceUnifier.getCurrencySymbolByEnum(defaultCurrency);
            }
        }

        protected IEnumerable<Control> getAllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => getAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

    }
}
