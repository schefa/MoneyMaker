namespace MoneyMaker.Libraries.Webservices.Entities
{
    public class YahooCurrencyRate : CurrencyRate
    {
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string ask;
        public string Ask
        {
            get { return ask; }
            set { ask = value; }
        }

        private string bid;
        public string Bid
        {
            get { return bid; }
            set { bid = value; }
        }
    }
}
