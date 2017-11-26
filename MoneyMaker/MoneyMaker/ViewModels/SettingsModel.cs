using System;
using System.Linq;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.Models;

namespace MoneyMaker.ViewModels
{
    public class SettingsModel : DatabaseModel
    {

        #region Constructor Singleton

        private static ManagerProfile manager = null;
        private static SettingsModel instance = null;

        private SettingsModel()
        {
            manager = FrmMain.Current.ManagerProfile;
        }
        
        public static SettingsModel getInstance()
        {
            if(instance == null)
            {
                instance = new SettingsModel();
            }
            return instance;
        }
        #endregion
        
       

        #region Finance Provider
        private FinanceAPI.FinanceStrategies financeDataProvider = FinanceAPI.FinanceStrategies.Yahoo;
        public FinanceAPI.FinanceStrategies getFinanceDataProvider()
        {
            if (ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("dataprovider");
                if (check == null)
                {
                    financeDataProvider = FinanceAPI.FinanceStrategies.Yahoo;
                }
                else
                {
                    financeDataProvider = (FinanceAPI.FinanceStrategies)Enum.Parse(typeof(FinanceAPI.FinanceStrategies), check.value);
                }
            }
            return financeDataProvider;
        }

        private Settings getSettingByKey(string key)
        {
            Settings result = null;
            if(ConnectionState == true)
            {
                result = (from st in db.Settings
                            where st.key == key
                            where st.AccountID == manager.AccountID
                            select st).FirstOrDefault();
            }
            return result;
        }

        public void setFinanceDataProvider(FinanceAPI.FinanceStrategies selected)
        {
            if(ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("dataprovider");
                if (check == null)
                {
                    db.Settings.InsertOnSubmit(new Settings() {
                        AccountID = manager.AccountID,
                        key = "dataprovider",
                        value = selected.ToString(),
                    });
                }
                else
                {
                    check.value = selected.ToString();
                }
                db.SubmitChanges();
            }
        }
        #endregion

        #region Currency
        private Currency.CurrencyCode currency = Currency.CurrencyCode.EUR;
        public Currency.CurrencyCode getCurrency()
        {
            if (ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("currency");

                if (check != null)
                {
                    currency = (Currency.CurrencyCode)Enum.Parse(typeof(Currency.CurrencyCode), check.value);
                }
            }
            return currency;
        }

        public void setCurrency(Currency.CurrencyCode selected)
        {
            if (ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("currency");

                if (check == null)
                {
                    db.Settings.InsertOnSubmit(new Settings()
                    {
                        AccountID = manager.AccountID,
                        key = "currency",
                        value = selected.ToString(),
                    });
                }
                else
                {
                    check.value = selected.ToString();
                }
                db.SubmitChanges();
            }
        }
        #endregion


        public decimal getCapitalGainTax()
        {
            decimal result = 0;
            if (ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("capitaltax");
                if(check != null)
                {
                    result = Convert.ToDecimal(check.value);
                }
            }
            return result;
        }

        public void setCapitalGainTax(decimal value)
        {
            if (ConnectionState == true && manager != null)
            {
                var check = getSettingByKey("capitaltax");

                if (check == null)
                {
                    db.Settings.InsertOnSubmit(new Settings()
                    {
                        AccountID = manager.AccountID,
                        key = "capitaltax",
                        value = value.ToString(),
                    });
                }
                else
                {
                    check.value = value.ToString();
                }
                db.SubmitChanges();
            }
        }
    }
}
