namespace MoneyMaker.Libraries.Webservices.Entities
{
    /// <summary>
    /// Entity for historical stock data
    /// </summary>
    public class YahooHistoricalQuote : HistoricalQuote
    {
        private decimal adj_close;
        public decimal Adj_close
        {
            get { return adj_close; }
            set { adj_close = value; }
        }
    }
}
