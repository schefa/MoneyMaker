using System;

namespace MoneyMaker.Libraries.Webservices.Entities
{
    public class GoogleSingleQuote : SingleQuote
    {

        private DateTime date;
        public override DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        
        private decimal? open;
        public override decimal? Open
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

        private decimal? currentPrice;
        public override decimal? CurrentPrice {
            get { return Close; }
            set { currentPrice = value; }
        }

        private int? volume;
        public override int? Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", Date.ToString("yyyy.MM.dd"), Open, High, Low, Close, Volume);
        }
    }
}
