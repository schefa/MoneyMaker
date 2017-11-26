using System;

namespace MoneyMaker.Libraries.Webservices.Entities
{
    /// <summary>
    /// Entity for historical stock data
    /// </summary>
    public class HistoricalQuote
    {

        private DateTime date;
        public virtual DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private decimal open;
        public decimal Open
        {
            get { return open; }
            set { open = value; }
        }

        private decimal high;
        public decimal High
        {
            get { return high; }
            set { high = value; }
        }

        private decimal low;
        public decimal Low
        {
            get { return low; }
            set { low = value; }
        }

        private decimal close;
        public decimal Close
        {
            get { return close; }
            set { close = value; }
        }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
    }
}
