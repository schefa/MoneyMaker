using MoneyMaker.Helpers;
using MoneyMaker.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker.ViewModels
{
    public class RedemptionModel : FinancingModel<Models.RedemptionData>
    {

        /// <summary>
        /// custom constructor to pass the correct userprofile
        /// </summary>
        public RedemptionModel(UserProfile user) : base(user)
        {
        }
        /// <summary>
        /// update the current redemptiondata item in  the database
        /// </summary>
        public override void updateItem(Models.RedemptionData itemToSave)
        {
            if (ConnectionState == true)
            {
                RedemptionData item = (from l in db.RedemptionData
                                 where l.RedemptionID == itemToSave.RedemptionID
                                 select l).FirstOrDefault();

                if (item != null)
                {
                    //item = itemToSave.convertToLinq();
                    item.calculateOption = (int?) itemToSave.calculateOption;
                    item.created = itemToSave.created;
                    item.interestRate = itemToSave.interestRate;
                    item.interestRateInterval = (int?) itemToSave.interestRateInterval;
                    item.loanAmount = itemToSave.loanAmount;
                    item.redemptionDuration = itemToSave.redemptionDuration;
                    item.redemptionDurationMode = (int?)itemToSave.redemptionDurationMode;
                    item.redemptionName = itemToSave.redemptionName;
                    item.redemptionRate = itemToSave.redemptionRate;
                    item.redemptionRateInterval = (int?)itemToSave.redemptionRateInterval;
                    item.remainingDebt = itemToSave.remainingDebt;
                    item.totalExpense = itemToSave.totalExpense;
                    item.UserID = itemToSave.UserID;
                    db.SubmitChanges();
                }
            }
        }
        /// <summary>
        /// create a new redemptiondata item in the database
        /// </summary>
        public override void createItem(Models.RedemptionData itemToSave)
        {
            if (ConnectionState == true)
            {
                var newItem = itemToSave.convertToLinq();
                newItem.UserID = user.UserID;
                newItem.created = DateTime.Now;
                db.RedemptionData.InsertOnSubmit(newItem);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// delete a remdeptiondate item in the database
        /// </summary>
        public override void deleteItem(int id)
        {
            if (ConnectionState == true)
            {
                var item = db.RedemptionData.FirstOrDefault(l => l.RedemptionID == id);
                db.RedemptionData.DeleteOnSubmit(item);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// get a list of redemptiondata items in the database
        /// </summary>
        public override List<Models.RedemptionData> getItems()
        {
            List<Models.RedemptionData> result = new List<Models.RedemptionData>();
            if (ConnectionState == true)
            {
                var query = (from l in db.RedemptionData
                             where l.UserID == user.UserID
                             orderby l.RedemptionID descending
                             select l);

                if (query.Any())
                {
                    foreach (RedemptionData item in query)
                    {
                        result.Add(item.convertToEntity());
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// get a single redemptiondate item of the database
        /// </summary>
        public override Models.RedemptionData getItem(int id)
        {
            Models.RedemptionData item = null;
            if (ConnectionState == true)
            {
                var query = db.RedemptionData.FirstOrDefault(l => l.RedemptionID == id);
                item = query.convertToEntity();
            }
            return item;
        }

    }
}
