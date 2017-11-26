using System;
using System.Collections.Generic;
using System.Linq;
using MoneyMaker.Models.Database;
using MoneyMaker.Helpers;

namespace MoneyMaker.ViewModels
{
    public class LeasingModel : FinancingModel<Models.LeasingData>
    {

        /// <summary>
        /// custom constructor to pass the correct userprofile
        /// </summary>
        public LeasingModel(UserProfile user) : base(user)
        { 
        }

        /// <summary>
        /// update the current leasingdata item in the database
        /// </summary>
        public override void updateItem(Models.LeasingData itemToSave)
        {
            if (ConnectionState == true)
            {
                LeasingData item = (from l in db.LeasingData
                                 where l.LeasingID == itemToSave.LeasingID
                                 select l).FirstOrDefault();

                if (item != null)
                {
                    //item = itemToSave.convertToLinq();
                    item.created = itemToSave.created;
                    item.deposit = itemToSave.deposit;
                    item.duration = itemToSave.duration;
                    item.durationMode = (int?)itemToSave.durationMode;
                    item.interestRate = itemToSave.interestRate;
                    item.leasingName = itemToSave.leasingName;
                    item.leasingRate = itemToSave.leasingRate;
                    item.leasingRateInterval = (int?)itemToSave.leasingRateInterval;
                    item.recoveryValue = itemToSave.recoveryValue;
                    item.startValue = itemToSave.startValue;
                    item.totalExpense = itemToSave.totalExpense;
                    item.totalInterest = itemToSave.totalInterest;
                    item.UserID = itemToSave.UserID;
                    item.UserProfile = item.UserProfile;
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// create a new leasingdata item in the database
        /// </summary>
        public override void createItem(Models.LeasingData itemToSave)
        {
            if (ConnectionState == true)
            {
                var newItem = itemToSave.convertToLinq();
                newItem.UserID = user.UserID;
                newItem.created = DateTime.Now;
                db.LeasingData.InsertOnSubmit(newItem);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// delete a leasingdata item from the database
        /// </summary>
        public override void deleteItem(int leasingID)
        {
            if (ConnectionState == true)
            {
                var item = db.LeasingData.FirstOrDefault(l => l.LeasingID == leasingID);
                db.LeasingData.DeleteOnSubmit(item);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// get a list of the leasingdata items in the database
        /// </summary>
        public override List<Models.LeasingData> getItems()
        {
            List<Models.LeasingData> result = new List<Models.LeasingData>();
            if (ConnectionState == true)
            {
                var query = (from l in db.LeasingData
                             where l.UserID == user.UserID
                             orderby l.LeasingID descending
                             select l);

                if (query.Any())
                {
                    foreach (LeasingData item in query)
                    {
                        result.Add(item.convertToEntity());
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// get a single leasingdata item from the database
        /// </summary>
        public override Models.LeasingData getItem(int id)
        {
            Models.LeasingData item = null;
            if (ConnectionState == true)
            {
                var query = db.LeasingData.FirstOrDefault(l => l.LeasingID == id);
                item = query.convertToEntity();
            }
            return item;
        }
    }
}
