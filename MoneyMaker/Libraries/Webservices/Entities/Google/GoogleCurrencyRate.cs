namespace MoneyMaker.Libraries.Webservices.Entities
{
    public class GoogleCurrencyRate : CurrencyRate
    {
        private decimal? open;
        public decimal? Open
        {
            get { return open; }
            set { open = value; }
        }

        private decimal? high;
        public decimal? High
        {
            get { return high; }
            set { high = value; }
        }

        private decimal? low;
        public decimal? Low
        {
            get { return low; }
            set { low = value; }
        }

        private decimal? close;
        public decimal? Close
        {
            get { return close; }
            set { close = value; }
        }
    }
}
