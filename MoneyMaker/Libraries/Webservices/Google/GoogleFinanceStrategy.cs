using System;
using System.IO;
using System.Text;

namespace MoneyMaker.Libraries.Google
{
    /// <summary>
    /// Google Finance - Part of Strategy pattern
    /// @author : Fjodor Schäfer
    /// </summary>
    public class GoogleFinanceStrategy : FinanceStrategy
    {
        // https://www.google.com/finance/historical?q=NASDAQ%3AGOOG
        // http://www.google.com/finance/historical?q=NASDAQ%3AGOOG&output=csv
        // http://www.codeproject.com/Articles/221952/Simple-Csharp-DLL-to-download-data-from-Google-Fin
        // https://www.google.com/finance/getprices?q=YHOO&i=120
        // https://www.google.com/finance/getprices?q=YHOO&i=86400&p=50d&f=d,c,v,k,o,h,l
         
        public GoogleFinanceStrategy(string symbol, string exchange = null) : base(symbol, exchange) { }
        
        protected override void downloadData()
        {
            base.downloadData();
            processData();
        }

        /// <summary>
        /// Transforms the Google data string into something more readable
        /// </summary>
        private void processData()
        {
            if(downloadedData != null)
            { 
                using (MemoryStream ms = new MemoryStream(Encoding.Default.GetBytes(downloadedData)))
                {
                    GoogleDataTransformer dp = new GoogleDataTransformer();
                    string errorMessage;
                    string resultValue;

                    resultValue = (DataTimestamp.LatestQuote == dataTimestamp || dataTimestamp == DataTimestamp.CurrencyRate) ? 
                        dp.processStreamMadeOfOneMinuteBarsToExtractMostRecentOHLCVForCurrentDay(ms, out errorMessage) :
                        dp.processStreamMadeOfOneDayLinesToExtractHistoricalData(ms, out errorMessage);

                    if (!String.IsNullOrEmpty(errorMessage))
                    {
                        downloadedData = string.Empty;
                    }
                    else {
                        downloadedData = resultValue;
                    }
                }
            }
        }

        /// <summary>
        /// Creates the Download URI in order to get the data
        /// </summary>
        protected override string getDownloadURI()
        {
            string result;

            if (String.IsNullOrEmpty(symbol))
            {
                result = string.Empty;
            }
            else
            {
                GoogleURIBuilder uriBuilder = new GoogleURIBuilder(exchange, symbol);

                switch (dataTimestamp)
                {

                    case DataTimestamp.AllQuotes:
                        result = uriBuilder.getGetPricesUrlToDownloadAllData(DateTime.Now);
                        break;

                    case DataTimestamp.LatestQuote:
                        result = uriBuilder.getGetPricesUrlForLastQuote();
                        break;

                    case DataTimestamp.Intervall: 
                        if (endDate < startDate)
                        { //It's impossible to download data from the future. That's why no URL is returned in this case.
                            result = string.Empty;
                        }
                        else {
                            result = uriBuilder.getGetPricesUrlForRecentData(startDate, endDate);
                        }
                        break;

                    case DataTimestamp.CurrencyRate:
                    case DataTimestamp.CurrencyRates:
                        result = uriBuilder.getGetPricesUrlForCurrencyRate();
                        break;

                    default:
                        result = string.Empty;
                        break;
                }
            }

            return result;
        }

    }
}
