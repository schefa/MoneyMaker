using MoneyMaker.Models.Database;
using MoneyMaker.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class WatchlistsModel : DatabaseModel
    {  

        /// <summary>
        /// Gets a list of stocks for a watchlist
        /// </summary>
        public List<WatchListViewItem> getWatchlists()
        {
            List<WatchListViewItem> result = new List<WatchListViewItem>();

            if (ConnectionState == true)
            {
                var query = (from wl in db.WatchList
                             join sm in db.StocksMap on wl.WatchListID equals sm.CategoryID into stocks
                             select new {
                                 Watchlist = wl,
                                 StocksCount = stocks.Where(x => x.Category == 'w').Count()
                             });

                if (query != null && query.Any())
                {
                    foreach (var item in query)
                    {
                        result.Add(new WatchListViewItem { Name = item.Watchlist.Name , StocksCount = item.StocksCount, Watchlist = item.Watchlist });
                    }
                }
            }

            return result;
        }
        
        /// <summary>
        /// Inserts a new watchlist to database
        /// </summary>
        /// <param name="wl">the watchlist data</param>
        public void saveWatchlist(WatchList wl)
        {
            if (ConnectionState == true)
            {
                db.WatchList.InsertOnSubmit(new WatchList
                {
                    Name = wl.Name
                });
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Updates an existing watchlist
        /// </summary>
        /// <param name="wl">the watchlist to replace with</param>
        public void updateWatchlist(WatchList wl)
        {
            if (ConnectionState == true)
            {
                WatchList item = (from mp in db.WatchList
                                  where mp.WatchListID == wl.WatchListID
                                  select mp).First();
                item = wl;
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Deletes an existing watchlist with its connections
        /// </summary>
        /// <param name="watchlistID">the id of the existing watchlist</param>
        public void deleteWatchlist(int watchlistID)
        {
            if (ConnectionState == true)
            {
                WatchList item = (from mp in db.WatchList
                                  where mp.WatchListID == watchlistID
                                  select mp).First();
            
                if(item != null)
                {
                    var stocksMap = (from mp in db.StocksMap
                                      where mp.CategoryID == watchlistID
                                      where mp.Category == 'w'
                                      select mp);
                    
                    if (stocksMap.Any())
                    {
                        db.StocksMap.DeleteAllOnSubmit(stocksMap);
                    }

                    db.WatchList.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
            }
             
        }
    }
}
