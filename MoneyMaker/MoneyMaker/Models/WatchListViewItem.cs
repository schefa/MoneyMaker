using MoneyMaker.Models.Database;

namespace MoneyMaker.Models
{
    public class WatchListViewItem
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private int stocksCount;
        public int StocksCount
        {
            get { return stocksCount; }
            set { stocksCount = value; }
        }

        private WatchList watchlist;
        public WatchList Watchlist
        {
            get { return watchlist; }
            set { watchlist = value; }
        }

        public string[] ToStringArray()
        {
            return new string[]
            {
                Name,
                StocksCount.ToString(),
            };
        }
    }
}
