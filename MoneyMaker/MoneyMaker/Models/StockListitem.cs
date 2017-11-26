using System;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.Libraries.Webservices.Entities;
using static MoneyMaker.Libraries.Webservices.FinanceAPI;
using System.Collections.Generic;

namespace MoneyMaker.Models
{
    public class StockListitem : YahooStockSearchResult
    {

        private int stocksMapID;
        public int StocksMapID
        {
            get { return stocksMapID; }
            set { stocksMapID = value; }
        }

        private int stockID;
        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private int? quantity;
        public int? Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private double? change;
        public double? Change
        {
            get { return change; }
            set { change = value; }
        }

        private double? bookValue;
        public double? BookValue
        {
            get { return bookValue; }
            set { bookValue = value; }
        }

        private string marketCapitalization;
        public string MarketCapitalization
        {
            get { return marketCapitalization; }
            set { marketCapitalization = value; }
        }

        private double? fiftydayMovingAverage;
        public double? FiftydayMovingAverage
        {
            get { return fiftydayMovingAverage; }
            set { fiftydayMovingAverage = value; }
        }

        private double? twoHundreddayMovingAverage;
        public double? TwoHundreddayMovingAverage
        {
            get { return twoHundreddayMovingAverage; }
            set { twoHundreddayMovingAverage = value; }
        }

        public string ChangePercentage
        {
            get {
                string currentPriceChange = "0.00%";
                if (Change != null)
                {
                    currentPriceChange = ((double)Change / PriceCurrent).ToString("+0.00%;-0.00%");
                }
                return currentPriceChange;
            }
        }

        private double currentPrice;
        public double PriceCurrent
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        private decimal? pricePurchase;
        public decimal? PricePurchase
        {
            get { return pricePurchase; }
            set { pricePurchase = value; }
        }
        
        private DateTime purchaseDate;
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public double CurrentValue
        {
            get
            {
                return ((double)Quantity * PriceCurrent);
            }
        }

        public double CurrentValueChange
        {
            get
            {
                double result = 0;
                if (CurrentValue > 0)
                {
                    result = (CurrentValue / ((double)Quantity * (double)PricePurchase)) - 1;
                }
                return result;
            }
        }

        public Currency Currency
        {
            get
            {
                return FinanceUnifier.getCurrencyByExchangeCode(exch);
            }
        }

        public string[] toStringArray(FinanceStrategies strategy = FinanceStrategies.Google)
        {
            List<string> result = new List<string>();
            result.Add(name);
            result.Add(symbol);
            result.Add(FinanceUnifier.getExchangeFullTitle(exch));
            result.Add((type != null) ? type : typeDisp);
            result.Add(Quantity.ToString());
            result.Add(((double)PricePurchase).ToString("0.00") + " " + Currency.Symbol);
            result.Add(PriceCurrent.ToString("0.00") + " " + Currency.Symbol);
            result.Add(ChangePercentage);
            result.Add(CurrentValue.ToString("0.00") + " " + Currency.Symbol);
            result.Add(CurrentValueChange.ToString("+0.00%;-0.00%"));
            result.Add((CurrentValue - ((double)Quantity * (double)PricePurchase)).ToString("+0.00;-0.00") + " " + Currency.Symbol);

            if(strategy == FinanceStrategies.Yahoo)
            {
                result.Add(BookValue.ToString() + " " + Currency.Symbol);
                result.Add(MarketCapitalization);
                result.Add(FiftydayMovingAverage.ToString());
                result.Add(TwoHundreddayMovingAverage.ToString());
            }

            return result.ToArray();
        }

        public StocksMap toMap(char category)
        {
            return new StocksMap()
            {
                StocksMapID = StocksMapID,
                Category = category,
                CategoryID = CategoryID,
                StockID = StockID,
                PurchaseDate = PurchaseDate,
                PurchasePrice = PricePurchase,
                Quantity = Quantity
            };
        }

    }
}
