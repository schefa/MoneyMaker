using System;

namespace MoneyMaker.Libraries.Webservices.Entities
{
    /// <summary>
    ///  Entity for a single quote result
    /// </summary> 

    public class YahooSingleQuote : SingleQuote
    {

        private int? averageDailyVolume;
        public int? AverageDailyVolume
        {
            get { return averageDailyVolume; }
            set { averageDailyVolume = value; }
        }

        private double? bookValue;
        public double? BookValue
        {
            get { return bookValue; }
            set { bookValue = value; }
        }

        private DateTime? lastTradeDate;
        public DateTime? LastTradeDate
        {
            get { return lastTradeDate; }
            set { lastTradeDate = value; }
        }

        public override DateTime Date {
            get { return Convert.ToDateTime(lastTradeDate); }
        }

        private double? daysLow;
        public double? DaysLow
        {
            get { return daysLow; }
            set { daysLow = value; }
        }

        private double? daysHigh;
        public double? DaysHigh
        {
            get { return daysHigh; }
            set { daysHigh = value; }
        }

        private double? yearLow;
        public double? YearLow
        {
            get { return yearLow; }
            set { yearLow = value; }
        }

        private double? yearHigh;
        public double? YearHigh
        {
            get { return yearHigh; }
            set { yearHigh = value; }
        }

        private string marketCapitalization;
        public string MarketCapitalization
        {
            get { return marketCapitalization; }
            set { marketCapitalization = value; }
        }

        private double? lastTradePriceOnly;
        public double? LastTradePriceOnly
        {
            get { return lastTradePriceOnly; }
            set { lastTradePriceOnly = value; }
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

        private string daysRange;
        public string DaysRange
        {
            get { return daysRange; }
            set { daysRange = value; }
        }

        private string stockExchange;
        public override string StockExchange
        {
            get { return stockExchange; }
            set { stockExchange = value; }
        }

        private int? volume;
        public override int? Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private decimal? currentPrice;
        public override decimal? CurrentPrice
        {
            get { return Convert.ToDecimal(LastTradePriceOnly); }
            set { currentPrice = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", 
                AverageDailyVolume, Change, DaysHigh, DaysLow, YearLow, YearHigh, MarketCapitalization, LastTradePriceOnly, DaysRange, Volume, StockExchange);
        }
    }
}
