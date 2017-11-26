using System;
using System.Net;

namespace MoneyMaker.Libraries
{
    /// <summary>
    /// Strategy pattern for different web services yahoo, google, nasdaq etc.
    /// @author : Fjodor Schäfer
    /// </summary>
    public abstract class FinanceStrategy
    {

        protected string symbol;
        protected string exchange;
        protected string downloadedData;

        protected DateTime startDate;
        protected DateTime endDate;

        protected DataTimestamp dataTimestamp = DataTimestamp.LatestQuote;
        public enum DataTimestamp
        {
            LatestQuote,
            AllQuotes,
            Intervall,
            CurrencyRate,
            CurrencyRates
        }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="symbol">Symbol of stock</param>
        /// <param name="exchange">Exchange of stock</param>
        public FinanceStrategy(string symbol, string exchange = null)
        {
            this.symbol = symbol;
            this.exchange = exchange;
        }

        #region Downloads finance data

        /// <summary>
        /// Download single quote
        /// </summary>
        public string downloadLatestQuoteData()
        {
            dataTimestamp = DataTimestamp.LatestQuote;
            downloadData();
            return downloadedData;
        }

        /// <summary>
        /// Download multiple quotes
        /// </summary>
        public string downloadHistoricalQuotesData(DateTime startDate, DateTime endDate)
        {
            dataTimestamp = DataTimestamp.Intervall;
            this.startDate = startDate;
            this.endDate = endDate;
            downloadData();
            return downloadedData;
        }

        /// <summary>
        /// Download single currency rate
        /// </summary>
        public string downloadCurrencyRate()
        {
            dataTimestamp = DataTimestamp.CurrencyRate;
            downloadData();
            return downloadedData;
        }

        /// <summary>
        /// Download multiple currency rates
        /// </summary>
        public string downloadCurrencyRates()
        {
            dataTimestamp = DataTimestamp.CurrencyRates;
            downloadData();
            return downloadedData;
        }
        #endregion

        /// <summary>
        /// Method to download the data from URL
        /// Some finance services (like Google) provide additional information which has to be removed
        /// </summary>
        protected virtual void downloadData()
        {
            string uri = getDownloadURI();

            if (!String.IsNullOrEmpty(uri))
            {
                try
                {
                    using (WebClient wClient = new WebClient())
                    {
                        downloadedData = wClient.DownloadString(uri);
                    }
                }
                catch (WebException webEx)
                {
                    string errorMessage = "Problem beim Laden der Daten für \"" + symbol + "\"\n" + webEx.Message;
                    FrmMain.Current.notifyUser(FrmMain.NotifyType.ErrorMessage, errorMessage);
                  //  MessageBox.Show(errorMessage);
                }
            }

            return;
        }

        /// <summary>
        /// Abstact method forced on every strategy. 
        /// They have different URLs
        /// </summary>
        /// <returns>URL as a string</returns>
        protected abstract string getDownloadURI();

    }
}
