using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class WatchlistModel : DatabaseModel
    {
        /// <summary>
        /// Select all stocks for a watchlist
        /// </summary>
        public List<StockListitem> getStocksByWatchlistID(int watchlistID)
        {
            List<StockListitem> result = new List<StockListitem>();

            if (ConnectionState == true)
            {
                var sequenz = (from st in db.Stocks
                                join wlm in db.StocksMap on st.StockID equals wlm.StockID
                                where wlm.CategoryID == watchlistID
                                where wlm.Category == 'w'
                                select new { wlm, st } );

                if (sequenz.Count() > 0)
                {
                    foreach (var item in sequenz)
                    {
                        result.Add(new StockListitem() {
                            StocksMapID = item.wlm.StocksMapID,
                            CategoryID = item.wlm.CategoryID,
                            StockID = item.wlm.StockID,
                            symbol = item.st.Symbol,
                            name = item.st.Name,
                            exch = item.st.StockExchange,
                            type = item.st.Typ,
                            Quantity = item.wlm.Quantity,
                            PriceCurrent = 0,
                            PricePurchase = item.wlm.PurchasePrice,
                            PurchaseDate = Convert.ToDateTime(item.wlm.PurchaseDate)
                        });
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Inserts stock into database and maps with watchlist
        /// </summary>
        /// <param name="stock">the stock data</param>
        public int insertStockToWatchlist(StockListitem stock)
        {
            int insertID = 0;
            if (ConnectionState == true)
            {
                // Stock exists?
                Stocks existingItem;

                // Non existing, then insert
                existingItem = checkExistingStocksItem(stock);
                if (existingItem == null)
                {
                    db.Stocks.InsertOnSubmit(new Stocks
                    {
                        Symbol = stock.symbol,
                        Name = stock.name,
                        StockExchange = stock.exch,
                        Typ = stock.typeDisp
                    });
                    db.SubmitChanges();

                    existingItem = checkExistingStocksItem(stock);
                }

                int stockID = existingItem.StockID;
                var stocksMap = new StocksMap
                {
                    Category = 'w',
                    CategoryID = stock.CategoryID,
                    StockID = stockID,
                    Quantity = stock.Quantity,
                    PurchaseDate = DateTime.Now,
                    PurchasePrice = Convert.ToDecimal(stock.PricePurchase),
                };
                
                // Map stock with watchlist
                db.StocksMap.InsertOnSubmit(stocksMap);
                db.SubmitChanges();

                insertID = stocksMap.StocksMapID;
            }

            return insertID;
        }

        /// <summary>
        /// Updates watchlist , e.g. new quantity
        /// </summary>
        public void updateStocksMap(StocksMap stocksMap, char category)
        {
            if (ConnectionState == true)
            {
                var item = (from sm in db.StocksMap
                            where sm.StocksMapID == stocksMap.StocksMapID
                            where sm.Category == category
                            select sm).FirstOrDefault();
                if(item != null)
                {
                    item.Quantity = stocksMap.Quantity;
                    item.PurchasePrice = stocksMap.PurchasePrice;
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// Check if the stock already exists
        /// </summary>
        /// <param name="stock">the stock data to check</param>
        /// <returns>Stocks database entity</returns>
        private Stocks checkExistingStocksItem(StockListitem stock)
        {
            Stocks result = null;
            if (ConnectionState == true)
            {
                result = (from st in db.Stocks
                        where st.Symbol == stock.symbol
                        select st).FirstOrDefault();
            }
            return result;
        }
        
        public StockListitem buildWatchlistStockItem(int watchlistID, YahooStockSearchResult selectedItem, decimal quantity, double price = 0, decimal pricePurchase = 0)
        {
            return new StockListitem() {
                    CategoryID = watchlistID,
                    symbol = selectedItem.symbol,
                    name = selectedItem.name,
                    exch = selectedItem.exch,
                    exchDisp = selectedItem.exchDisp,
                    typeDisp = selectedItem.typeDisp,
                    Quantity = Convert.ToInt32(quantity),
                    PriceCurrent = price,
                    PricePurchase = pricePurchase
                }; 
        }
        
        /// <summary>
        /// Deletes stock-watchlist mapping
        /// </summary>
        /// <param name="item">WatchlistStock entity</param>
        public void deleteStockFromWatchlist(StockListitem item)
        {
            if (ConnectionState == true)
            {
                if (item.StockID == 0)
                {
                    var a = checkExistingStocksItem(item);
                    item.StockID = a.StockID;
                }

                var sequenzT = (from mp in db.UserLines
                               where mp.StocksMapID == item.StocksMapID
                               select mp); 

                db.UserLines.DeleteAllOnSubmit(sequenzT);
                db.SubmitChanges();

                var sequenz = (from mp in db.StocksMap
                                where mp.Category == 'w'
                                where mp.StocksMapID == item.StocksMapID
                                select mp);

                if (sequenz.Any() && sequenz.First() != null)
                {
                    db.StocksMap.DeleteOnSubmit(sequenz.First());
                    db.SubmitChanges();
                }
            }
        }
        
    }
}
