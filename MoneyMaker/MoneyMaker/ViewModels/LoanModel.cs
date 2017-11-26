using MoneyMaker.Helpers;
using MoneyMaker.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class LoanModel : FinancingModel<Models.LoanData>
    {
        /// <summary>
        /// custom constructor to pass the correct userprofile
        /// </summary>
        public LoanModel(UserProfile user) : base(user)
        {
        }

        /// <summary>
        /// gets a single loan from the database
        /// </summary>
        public override Models.LoanData getItem(int id)
        {
            Models.LoanData item = null;
            if (ConnectionState == true)
            {
                var query = db.LoanData.FirstOrDefault(l => l.LoanID == id);
                item = query.convertToEntity();
            }
            return item;
        }

        /// <summary>
        /// stores a single loan to the database
        /// </summary>
        public override void createItem(Models.LoanData itemToSave)
        {
            if (ConnectionState == true)
            {
                var newItem = itemToSave.convertToLinq();
                newItem.UserID = user.UserID;
                newItem.created = DateTime.Now;
                db.LoanData.InsertOnSubmit(newItem);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// updates a loan from the database 
        /// </summary>
        public override void updateItem(Models.LoanData loan)
        {
            if (ConnectionState == true)
            {
                LoanData item = (from l in db.LoanData
                                 where l.LoanID == loan.LoanID
                                 select l).SingleOrDefault();
                
                if (item != null)
                {
                    // item = loan.convertToLinq();
                    item.loanName = loan.loanName;
                    item.calculateOption = (int?) loan.calculateOption;
                    item.created = loan.created;
                    item.duration = loan.duration;
                    item.durationMode = (int?)loan.durationMode;
                    item.interestRate = loan.interestRate;
                    item.loanAmount = loan.loanAmount;
                    item.loanName = loan.loanName;
                    item.repaymentRate = loan.repaymentRate;
                    item.repaymentRateInterval = (int?) loan.repaymentRateInterval;
                    item.totalExpense = loan.totalExpense;
                    item.UserID = loan.UserID;
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// gets a list of loans in the database 
        /// </summary>
        public override List<Models.LoanData> getItems()
        {
            List<Models.LoanData> result = new List<Models.LoanData>();
            if (ConnectionState == true)
            {
                var query = (from l in db.LoanData
                                where l.UserID == user.UserID                                
                                orderby l.LoanID descending
                                select l);

                if (query.Any())
                { 
                    foreach (LoanData item in query)
                    {
                        result.Add(item.convertToEntity());
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// deletes a loan in the database
        /// </summary>
        public override void deleteItem(int id)
        {
            if (ConnectionState == true)
            {
                var item = db.LoanData.FirstOrDefault(l => l.LoanID == id);
                db.LoanData.DeleteOnSubmit(item);
                db.SubmitChanges();
            }
        }
    }
}
