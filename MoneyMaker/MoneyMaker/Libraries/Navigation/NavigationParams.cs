using MoneyMaker.Models.Database;

namespace MoneyMaker.Libraries.Navigation
{
    /// <summary>
    /// Part of Factory pattern. Some views need parameters
    /// @author : Fjodor Schäfer
    /// </summary>
    public class NavigationParams
    {
        private WatchList watchlist = new WatchList();
        public WatchList Watchlist
        {
            get { return watchlist; }
            set { watchlist = value; }
        }
    }
}
