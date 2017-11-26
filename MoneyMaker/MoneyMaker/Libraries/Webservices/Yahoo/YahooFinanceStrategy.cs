using System;

namespace MoneyMaker.Libraries.Yahoo
{
    /// <summary>
    /// Yahoo Finance - Part of Strategy pattern
    /// @author : Fjodor Schäfer
    /// </summary>
    public class YahooFinanceStrategy : FinanceStrategy
    {
        /// <summary>
        /// Custom constructor
        /// </summary>
        public YahooFinanceStrategy(string symbol, string exchange = null) : base(symbol, exchange) { }

        /// <summary>
        /// Creates the Download URI in order to get the data
        /// </summary>
        protected override string getDownloadURI()
        {
            string query;
            string result;
            string exchange = this.exchange;

            if (String.IsNullOrEmpty(symbol))
            {
                result = string.Empty;
            }
            else
            {
                switch (dataTimestamp)
                {

                    case DataTimestamp.AllQuotes:
                        query = "select * from yahoo.finance.historicaldata where startDate='" + startDate.ToString("yyyy-MM-dd") + "' and endDate='" + endDate.ToString("yyyy-MM-dd") + "' and symbol='" + symbol + "'";
                        break;

                    case DataTimestamp.LatestQuote:
                        query = "select * from yahoo.finance.quotes where symbol in ('" + symbol + "')";
                        break;

                    case DataTimestamp.Intervall:
                        if (endDate < startDate)
                        { //It's impossible to download data from the future. That's why no URL is returned in this case.
                            query = string.Empty;
                        }
                        else {
                            query = "select * from yahoo.finance.historicaldata where startDate='" + startDate.ToString("yyyy-MM-dd") + "' and endDate='" + endDate.ToString("yyyy-MM-dd") + "' and symbol='" + symbol + "'";
                        }
                        break;

                    case DataTimestamp.CurrencyRate:
                    case DataTimestamp.CurrencyRates:
                        query = "select * from yahoo.finance.xchange where pair in ('"+symbol+"')";
                        break;

                    default:
                        query = string.Empty;
                        break;
                }

                if(String.IsNullOrEmpty(query))
                {
                    result = string.Empty;
                }
                else
                {
                    result = (YahooURIBuilder.createUrl(query));
                }

            }

            return result;
        }

    }
}
