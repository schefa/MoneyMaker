using MoneyMaker.Models.Database;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class BankAccountModel : DatabaseModel
    {

        private UserProfile user;

        /// <summary>
        /// Custom constructor accepts the user
        /// </summary>
        public BankAccountModel(UserProfile user)
        {
            this.user = user;
        }

        /// <summary>
        /// Returns the bank account of the user
        /// </summary> 
        public BankAccount getBank()
        {
            if (ConnectionState == true)
            { 
                var query = db.BankAccount.SingleOrDefault(x => x.UserID == user.UserID);
                if (query != null)
                {
                    return query;
                }
            }
            return null;
        }

        /// <summary>
        /// List of all transactions for the bank account
        /// </summary> 
        public List<TransactionItem> getTransactions(DateTime start, DateTime end)
        { 
            List<TransactionItem> result = new List<TransactionItem>();

            if (ConnectionState == true)
            {
                var bank = getBank();
                if(bank != null)
                {
                    var query = (from t in db.Transactions
                                 where t.BankAccountID == bank.BankAccountID
                                 where t.Created.Date >= start
                                 where t.Created.Date <= end
                                 orderby t.Created descending
                                 select t);

                    if (query.Any())
                    {
                        foreach (var item in query)
                        {
                            result.Add(new TransactionItem() {
                                Description = item.Description,
                                Amount = item.Amount,
                                BankAccountID = item.BankAccountID,
                                Created = item.Created,
                                TransactionType = item.TransactionType
                            });
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Inserts a new transaction
        /// </summary>
        public void saveTransaction(TransactionItem transaction)
        {
            if (ConnectionState == true && transaction.BankAccountID > 0)
            {
                decimal? change = 0;
                switch (transaction.TransactionType)
                {
                    case 's': case 'c': change += transaction.Amount; break; // sales, charge-up
                    case 't': case 'p': change -= transaction.Amount; break; // takeoff, purchase
                }

                var bank = getBank();
                char[] burden = { 't', 'p'};
                if (!(burden.Contains(transaction.TransactionType) && transaction.Amount > bank.AccountBalance))
                {
                    var bankQuery = (from bk in db.BankAccount
                                         where bk.BankAccountID == bank.BankAccountID
                                         select bk).First();

                    bankQuery.AccountBalance += (decimal) change;
                    db.SubmitChanges();
                    
                    db.Transactions.InsertOnSubmit(new Transactions
                    {
                        Description = transaction.Description,
                        BankAccountID = transaction.BankAccountID,
                        Created = transaction.Created,
                        Amount = transaction.Amount,
                        TransactionType = transaction.TransactionType,
                    });
                    db.SubmitChanges(); 
                }
            }
        }

    }
}
