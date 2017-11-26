using MoneyMaker.Models.Database;
using System.Linq;

namespace MoneyMaker.ViewModels
{
    public class UserProfileModel : DatabaseModel
    {
        /// <summary>
        /// Gets a list of all users connected to a manager
        /// </summary>
        public IQueryable<UserProfile> getItems(int managerId)
        {
            if (ConnectionState == true)
            {
                var query = (from user in db.UserProfile
                             where user.AccountID == managerId
                             select user);

                if (query.Any())
                {
                    return query;
                }
            }
            return null;
        }

        /// <summary>
        /// Updates an existing user profile by replacing it with the new one
        /// </summary>
        public void updateItem(UserProfile profile)
        {
            if (ConnectionState == true)
            {
                var item = (from mp in db.UserProfile
                                  where mp.UserID == profile.UserID
                                  select mp).First();
                item = profile;
                db.SubmitChanges();
            }
        }
        
        /// <summary>
        /// Deletes an existing user profile
        /// </summary>
        public void deleteItem(UserProfile profile)
        {
            if (ConnectionState == true)
            {

                var bank = (from dp in db.BankAccount
                            where dp.UserID == profile.UserID
                            select dp).FirstOrDefault();
                
                var depot = (from dp in db.Depot
                             where dp.UserID == profile.UserID
                             select dp).First();

                var watchlistsIds = (from wl in db.WatchList
                             where wl.UserID == profile.UserID
                             select wl.WatchListID);
                
                var stocksmap = (from dp in db.StocksMap
                                where dp.CategoryID == depot.DepotID
                                || watchlistsIds.Contains(dp.CategoryID)
                                select dp);

                db.StocksMap.DeleteAllOnSubmit(stocksmap);

                db.Depot.DeleteOnSubmit(depot);
                db.WatchList.DeleteAllOnSubmit(profile.WatchList);

                db.Transactions.DeleteAllOnSubmit(bank.Transactions);
                db.BankAccount.DeleteOnSubmit(bank);

                db.UserLines.DeleteAllOnSubmit(profile.UserLines);

                db.LoanData.DeleteAllOnSubmit(profile.LoanData);
                db.LeasingData.DeleteAllOnSubmit(profile.LeasingData);
                db.RedemptionData.DeleteAllOnSubmit(profile.RedemptionData);
                
                db.UserProfile.DeleteOnSubmit(profile);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Creates a new profile + depot
        /// </summary>
        public void createItem(UserProfile profile)
        {
            if (ConnectionState == true)
            {
                db.UserProfile.InsertOnSubmit(profile);
                db.SubmitChanges();

                db.BankAccount.InsertOnSubmit(new BankAccount() { UserID = profile.UserID });
                db.SubmitChanges();

                db.Depot.InsertOnSubmit(new Depot() { UserID = profile.UserID });
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Select a user profile
        /// </summary>
        public UserProfile getItem(int managerId, int id = 0)
        {
            UserProfile user = new UserProfile();
            if (ConnectionState == true && id > 0)
            {
                user = (from u in db.UserProfile
                        where u.UserID == id
                        where u.AccountID == managerId
                        select u).FirstOrDefault();
            }
            return user;
        }

    }
}
