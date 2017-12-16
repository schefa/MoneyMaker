using MoneyMaker.Models;

namespace MoneyMaker.Libraries.Webservices.Entities
{

    /// <summary>
    /// Entity for internal data structure of fixed exchanges
    /// </summary>
    public class ExchangeCode
    {

        private string region;
        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string yahooExch;
        public string YahooExch
        {
            get { return yahooExch; }
            set { yahooExch = value; }
        }

        private string yahooSuffix;
        public string YahooSuffix
        {
            get { return yahooSuffix; }
            set { yahooSuffix = value; }
        }

        private string googleExch;
        public string GoogleExch
        {
            get { return googleExch; }
            set { googleExch = value; }
        }

        private Currency.CurrencyCode currency;
        public Currency.CurrencyCode Currency
        {
            get { return currency; }
            set { currency = value; }
        }

    }
}
