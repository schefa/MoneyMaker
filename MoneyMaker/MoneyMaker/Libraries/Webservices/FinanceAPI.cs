using MoneyMaker.Libraries.Google;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Libraries.Yahoo;
using System;
using System.Collections.Generic;

namespace MoneyMaker.Libraries.Webservices
{

    /// <summary>
    /// Methods to get the finance data depending on the strategy selected - Part of Strategy pattern (Context)
    /// @author : Fjodor Schäfer
    /// </summary>
    public class FinanceAPI
    {
        private FinanceStrategy financeStrategy;
        private IFinanceDataTransformer financeDataStrategy;

        private string exchange;
        private string symbol;

        private FinanceStrategies strategy;
        public enum FinanceStrategies
        {
            Google,
            Yahoo
        }

        /// <summary>
        /// Constructor sets the strategy
        /// </summary>
        public FinanceAPI(FinanceStrategies strategy, string symbol, string exchange = null)
        {
            this.symbol = symbol;
            this.exchange = exchange;
            setStrategy(strategy);
        }
        
        /// <summary>
        /// Sets the finance strategy
        /// </summary>
        private void setStrategy(FinanceStrategies strategy)
        {
            this.strategy = strategy;
            switch (strategy)
            {
                case FinanceStrategies.Yahoo:
                    financeStrategy = new YahooFinanceStrategy(symbol, exchange);
                    financeDataStrategy = new YahooDataTransformer();
                    break;
                case FinanceStrategies.Google: default:
                    // unify yahoo & google
                    exchange = FinanceUnifier.transformExchangeToGoogle(symbol, exchange);
                    symbol = FinanceUnifier.transformSymbolToGoogle(symbol);

                    financeStrategy = new GoogleFinanceStrategy(symbol, exchange);
                    financeDataStrategy = new GoogleDataTransformer();
                    break;
            }
        }
        
        /// <summary>
        /// historical prices JSON
        /// </summary>
        public string getHistoricalQuotesData(DateTime startDate, DateTime endDate)
        {
            return financeStrategy.downloadHistoricalQuotesData(startDate, endDate);
        }

        /// <summary>
        /// latest price JSON
        /// </summary>
        public string getLatestQuoteData()
        {
            return financeStrategy.downloadLatestQuoteData();
        }

        /// <summary>
        /// Get currency rates data
        /// </summary>
        public string getCurrencyRatesData()
        {
            return financeStrategy.downloadCurrencyRates();
        }

        /// <summary>
        /// transforms the text into list of quotes
        /// </summary>
        public List<HistoricalQuote> createHistoricalQuotesFromString(string str)
        {
            return financeDataStrategy.createHistoricalQuotesFromString(str);
        }

        /// <summary>
        /// transforms the text into quote class
        /// </summary>
        public SingleQuote createSingleQuoteFromString(string str)
        {
            return financeDataStrategy.createSingleQuoteFromString(str);
        }

        /// <summary>
        /// Searches for symbol and returns single quote class
        /// </summary>
        public SingleQuote getLatestQuote()
        {
            string str = getLatestQuoteData();
            return financeDataStrategy.createSingleQuoteFromString(str);
        }

        /// <summary>
        /// Searches for the two symbols and returns current currency rate
        /// </summary>
        public CurrencyRate getCurrencyRate()
        {
            string str = getCurrencyRatesData();
            return financeDataStrategy.createCurrencyRateFromString(str);
        }

        /// <summary>
        /// Searches for the two symbols and returns current currency rates as a list
        /// </summary>
        public List<CurrencyRate> getCurrencyRates()
        {
            string str = getCurrencyRatesData();
            return financeDataStrategy.createCurrencyRatesFromString(str);
        }

        /// <summary>
        /// searches symbol and return quotes list
        /// </summary>
        public List<HistoricalQuote> getHistoricalQuotesList(DateTime startDate, DateTime endDate)
        {
            List<HistoricalQuote> result = new List<HistoricalQuote>();

            TimeSpan diff = endDate - startDate;
            double totalDays = diff.TotalDays;

            // Yahoo doesn't have the possibility to go further than 1 year, so we have to split the intervall
            if (strategy == FinanceStrategies.Yahoo && totalDays > 365)
            {
                totalDays = 0;
                var newStartDate = endDate.AddDays(-365);
                do
                {
                    TimeSpan diffs = endDate - startDate;
                    totalDays = diffs.TotalDays;
                    
                    var tmpResult = getHistoricalQuotesList(newStartDate, endDate);
                    result.AddRange(tmpResult);

                    endDate = endDate.AddDays(-366);
                    if(startDate <= newStartDate)
                    {
                        TimeSpan startDifference = newStartDate - startDate;
                        newStartDate = (startDifference.TotalDays >= 365) ? endDate.AddDays(-365) : startDate;
                    }

                } while (totalDays > 365);

            }
            else
            {
                string str = getHistoricalQuotesData(startDate,endDate);
                result = financeDataStrategy.createHistoricalQuotesFromString(str);
            }

            return result;
        }
    }
}
