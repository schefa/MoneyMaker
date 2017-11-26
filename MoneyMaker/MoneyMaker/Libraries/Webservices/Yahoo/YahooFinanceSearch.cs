using MoneyMaker.Libraries.Webservices.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.Libraries.Yahoo
{

    /// <summary>
    /// Yahoo stock search
    /// @author : Fjodor Schäfer
    /// </summary>
    public class YahooFinanceSearch : YahooURIBuilder
    {
        /// <summary>
        /// searches stock, returns JSON
        /// </summary>
        public static string searchStockJSON(string searchTerm)
        {
            string jsonString = "";
            if (searchTerm.Length >= 1)
            {
                string url = "http://autoc.finance.yahoo.com/autoc?query=" + Uri.EscapeUriString(searchTerm) + "&region=EU&lang=de-DE";
                jsonString = executeUrl(url);
            } 
            return jsonString;
        }

        /// <summary>
        /// searches for stock, returns list
        /// </summary>
        public static IList<YahooStockSearchResult> searchStockResultList(string searchTerm)
        {
            string jsonString = searchStockJSON(searchTerm);
            IList<YahooStockSearchResult> searchResultList = getSearchResultsList(jsonString);
            return searchResultList;
        }

        /// <summary>
        /// transforms the JSON string into a C# object
        /// </summary>
        public static IList<YahooStockSearchResult> getSearchResultsList(string jsonString)
        {
            IList<YahooStockSearchResult> result = new List<YahooStockSearchResult>();
            if(jsonString != null && jsonString.Length > 0)
            {
                JObject json = JObject.Parse(jsonString);
                var jsonResultSet = json["ResultSet"]["Result"];
                if(jsonResultSet != null)
                {
                    IList<JToken> jsonResults = jsonResultSet.Children().ToList();
                    if(jsonResults.Count > 0)
                    {
                        foreach (JToken jsonResult in jsonResults)
                        {
                            YahooStockSearchResult searchResult = JsonConvert.DeserializeObject<YahooStockSearchResult>(jsonResult.ToString());
                            result.Add(searchResult);
                        }
                    }
                }
            }
            return result;
        }

    }
}
