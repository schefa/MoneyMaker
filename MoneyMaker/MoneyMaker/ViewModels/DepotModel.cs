using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class DepotModel : DatabaseModel
    {

        public StockListitem buildWatchlistStockItem(YahooStockSearchResult selectedItem, decimal quantity, double price = 0, decimal pricePurchase = 0)
        {
            var depot = getUserDepot();
            return new StockListitem()
            {
                CategoryID = depot.DepotID,
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

        private Stocks getExistingItem()
        {
            return null;
        }

        /// <summary>
        /// Inserts stock into database and maps with watchlist
        /// </summary>
        /// <param name="stock">the stock data</param>
        public int insertStockToDepot(StockListitem stock)
        {
            int insertID = 0;
            if (ConnectionState == true)
            {
                // Stock exists?
                Stocks existingItem = null;
                
                // Non existing, then insert
                if(db.Stocks.Any())
                {
                    existingItem = db.Stocks.Where(st => st.Symbol == stock.symbol).SingleOrDefault();
                    db.SubmitChanges();
                }

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

                    existingItem = db.Stocks.FirstOrDefault(st => st.Symbol == stock.symbol);
                }

                int stockID = existingItem.StockID;
                var stocksMap = new StocksMap {
                    Category = 'd',
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
        /// Returns the depot of the current user
        /// </summary>
        public Depot getUserDepot()
        {
            if (ConnectionState == true)
            { 
                var query = (from depot in db.Depot
                               select depot).FirstOrDefault();
                return query;
            }
            return null;
        }
        
        /// <summary>
        /// List of all stocks for the user depot
        /// </summary> 
        public List<StockListitem> getStocks()
        {
            List<StockListitem> result = new List<StockListitem>();
            var depot = getUserDepot();

            if (ConnectionState == true && depot != null)
            {
                var query = (from st in db.Stocks
                               join wlm in db.StocksMap on st.StockID equals wlm.StockID
                               where wlm.CategoryID == depot.DepotID
                               where wlm.Category == 'd'
                               select new { wlm, st });

                if (query.Count() > 0)
                {
                    foreach (var item in query)
                    {
                        result.Add(new StockListitem()
                        {
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
        /// Saves the transaction (purchase or sale)
        /// </summary>
        /// <param name="type">The transaction type : s(ales), c(harge), t(akeoff), p(urchase)</param>
        /// <param name="stock">the stock data</param>
        public void saveTransaction(TransactionItem.TransactionTypeEnum type, StockListitem stock)
        {
            BankAccountModel bankModel = new BankAccountModel();
            var bank = bankModel.getBank();
            var ttype = (type == TransactionItem.TransactionTypeEnum.Purchase) ? 'p' : 's';
            var totalSum = (decimal) stock.PricePurchase * (decimal) stock.Quantity;

            if (ConnectionState == true && bank != null)
            {
                if(totalSum <= bank.AccountBalance)
                {
                    decimal change = 0;
                    switch (type)
                    {
                        case TransactionItem.TransactionTypeEnum.Sales: change += totalSum; break;
                        case TransactionItem.TransactionTypeEnum.Purchase: change -= totalSum; break;
                    }

                    var bankQuery = (from bk in db.BankAccount
                                     where bk.BankAccountID == bank.BankAccountID
                                     select bk).First();

                    bankQuery.AccountBalance += change;
                    db.SubmitChanges();

                    db.Transactions.InsertOnSubmit(new Transactions
                    {
                        Description = stock.Quantity +" - "+ stock.name,
                        BankAccountID = bank.BankAccountID,
                        Created = DateTime.Now,
                        Amount = totalSum,
                        TransactionType = ttype,
                    });
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// Sales the stock and saves the transaction
        /// </summary>
        public void removeStock(StockListitem stock, decimal quantity)
        {
            if (ConnectionState == true)
            {
                var query = (from ds in db.StocksMap
                                where ds.StocksMapID == stock.StocksMapID
                                select ds).FirstOrDefault();

                if(query != null)
                {
                    if (quantity < stock.Quantity)
                    {
                        query.Quantity -= (int) quantity;
                    }
                    else if(quantity == stock.Quantity)
                    {
                        db.UserLines.DeleteAllOnSubmit(query.UserLines);
                        db.StocksMap.DeleteOnSubmit(query);
                    }
                    db.SubmitChanges();
                    
                    BankAccountModel bankModel = new BankAccountModel();
                    var bank = bankModel.getBank();
                    var valueBought = quantity * query.PurchasePrice;
                    var valueSold = quantity * Convert.ToDecimal( stock.PriceCurrent );
                    
                    db.Transactions.InsertOnSubmit(new Transactions
                    {
                        Description = quantity +" - "+ stock.name,
                        BankAccountID = bank.BankAccountID,
                        Created = DateTime.Now,
                        Amount = valueSold,
                        TransactionType = 's',
                    });

                    var capitalGainTax = SettingsModel.getInstance().getCapitalGainTax();
                    if(capitalGainTax > 0)
                    {
                        decimal valueTax = 0;
                        var taxType = "";
                        char taxTransType = 'x';
                        if (valueSold > valueBought) // Profit
                        {
                            valueTax = Convert.ToDecimal(valueSold - valueBought) * (capitalGainTax / 100);
                            taxType = "Kapitalerstragssteuer nach Verkauf - " + stock.name;
                        }
                        else if(valueSold < valueBought) // Loss
                        {
                            valueTax = Convert.ToDecimal(valueBought - valueSold) * (capitalGainTax / 100);
                            taxType = "Steuergutschrift durch Verkauf - " + stock.name;
                            taxTransType = 'y';
                        }

                        db.Transactions.InsertOnSubmit(new Transactions
                        {
                            Description = taxType,
                            BankAccountID = bank.BankAccountID,
                            Created = DateTime.Now,
                            Amount = valueTax,
                            TransactionType = taxTransType,
                        });
                    }
                    db.SubmitChanges();
                }
            }
        }

    }
}
