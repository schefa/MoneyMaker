namespace MoneyMaker.Libraries.Webservices.Entities
{

    /// <summary>
    ///  Entity for a single search result
    /// </summary> 

    public class YahooStockSearchResult
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string exch { get; set; }
        public string exchDisp { get; set; }
        public string type { get; set; }
        public string typeDisp { get; set; }
        
        /// <summary>
        /// the visible text in AutoComplete
        /// </summary>
        public string Display
        {
            get
            {
                var exchTitle = FinanceUnifier.getExchangeFullTitle(exch);
                return  name + "\n" + exchTitle + "\n"+ typeDisp;
            }
        }
    }
}
