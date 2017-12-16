using MoneyMaker.Libraries.Webservices;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using MoneyMaker.Libraries.Webservices.Entities;
using Newtonsoft.Json;

namespace MoneyMaker.Libraries.Yahoo
{
    /// <summary>
    /// Processes the data from Yahoo and transforms it into something more readable.
    /// @author : Fjodor Schäfer
    /// </summary>
    public class YahooDataTransformer : IFinanceDataTransformer
    {

        /// <summary>
        /// Parses a string into a JSON object
        /// </summary>
        public static IList<JToken> getQuoteList(string jsonString)
        {
            IList<JToken> list = new List<JToken>();
            if (jsonString != null)
            {
                JObject json = JObject.Parse(jsonString);
                JToken results = json["query"]["results"];
                int cnt = json["query"]["count"].ToObject<int>();
                if (results.HasValues)
                {
                    if(cnt > 1)
                    {
                        list = results["quote"].ToList();
                    }
                    else
                    {
                        list.Add( results["quote"] );
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Creates a list of historical quotes from a JSON formatted string data
        /// </summary>
        public List<HistoricalQuote> createHistoricalQuotesFromString(string jsonData)
        {
            List<HistoricalQuote> result = new List<HistoricalQuote>();
            IList<JToken> quotesResultList = getQuoteList(jsonData);
            if(quotesResultList != null)
            {
                foreach (JToken quote in quotesResultList)
                {
                    var quoteString = quote.ToString();
                    YahooHistoricalQuote stockData = JsonConvert.DeserializeObject<YahooHistoricalQuote>(quoteString);
                    result.Add(stockData);
                }
            }
            return result;
        }

        /// <summary>
        /// Parses a string into a JSON object
        /// </summary>
        public SingleQuote createSingleQuoteFromString(string data)
        {
            SingleQuote quote = new YahooSingleQuote();

            if (data != null)
            {
                JObject json = JObject.Parse(data);
                var results = json["query"]["results"];

                if (results != null && results["quote"] != null)
                {
                    JToken result = results["quote"];
                    quote = JsonConvert.DeserializeObject<YahooSingleQuote>(result.ToString());
                }
            }
            return quote;
        }

        /// <summary>
        /// Creates a single currency rate from a JSON formatted string
        /// </summary>
        public CurrencyRate createCurrencyRateFromString(string data)
        {
            CurrencyRate quote = new YahooCurrencyRate();

            if (data != null)
            {
                JObject json = JObject.Parse(data);
                var results = json["query"]["results"];
                if (results != null)
                {
                    JToken result = results["rate"];
                    quote = JsonConvert.DeserializeObject<YahooCurrencyRate>(result.ToString());
                }
            }
            return quote;
        }

        /// <summary>
        /// Parses a string into a JSON object
        /// </summary>
        public static IList<JToken> getRatesList(string jsonString)
        {
            IList<JToken> list = default(IList<JToken>);
            if (jsonString != null)
            {
                JObject json = JObject.Parse(jsonString);
                var results = json["query"]["results"];
                if (results.HasValues)
                {
                    list = json["query"]["results"]["rate"].ToList();
                }
            }
            return list;
        }

        /// <summary>
        /// Creates a list of currency rates from a JSON formatted string data
        /// </summary>
        public List<CurrencyRate> createCurrencyRatesFromString(string data)
        {
            List<CurrencyRate> result = new List<CurrencyRate>();
            IList<JToken> resultsList = getRatesList(data);
            if (resultsList != null)
            {
                foreach (JToken quote in resultsList)
                {
                    CurrencyRate stockData = JsonConvert.DeserializeObject<YahooCurrencyRate>(quote.ToString());
                    result.Add(stockData);
                }
            }
            return result;
        }
    }
}
