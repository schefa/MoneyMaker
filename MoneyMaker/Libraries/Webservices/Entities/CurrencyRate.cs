using System;

namespace MoneyMaker.Libraries.Webservices.Entities
{
    /// <summary>
    /// Entity for currency rate data
    /// </summary>
    public class CurrencyRate
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
