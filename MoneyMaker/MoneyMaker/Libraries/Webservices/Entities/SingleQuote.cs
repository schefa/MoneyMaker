using MoneyMaker.Models;
using System;

namespace MoneyMaker.Libraries.Webservices.Entities
{
    /// <summary>
    /// Entity for single stock data
    /// </summary>
    public class SingleQuote
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string symbol;
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }


        private string stockExchange;
        public virtual string StockExchange
        {
            get { return stockExchange; }
            set { stockExchange = value; }
        }

        private decimal? open;
        public virtual decimal? Open
        {
            get { return open; }
            set { open = value; }
        }

        private double? change;
        public virtual double? Change
        {
            get { return change; }
            set { change = value; }
        }

        public double ChangePercentage
        {
            get
            {
                double currentPriceChange = 0.0;
                if (Change != null && CurrentPrice != null)
                {
                    currentPriceChange = ((double) Change / (double) CurrentPrice);
                }
                return currentPriceChange;
            }
        }

        private decimal? currentPrice;
        public virtual decimal? CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        private int? volume;
        public virtual int? Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private DateTime date;
        public virtual DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Currency Currency
        {
            get
            {
                Currency result = FinanceUnifier.getCurrencyByExchangeCode(StockExchange);
                if(result.Name == null)
                {
                    result = FinanceUnifier.getCurrencyBySymbol(symbol);
                }
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Symbol);
        }
    }
}
