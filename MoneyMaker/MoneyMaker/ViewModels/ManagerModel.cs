using MoneyMaker.Helpers;
using MoneyMaker.Models.Database;
using System.Linq;
using System;

namespace MoneyMaker.ViewModels
{
    public class ManagerModel : DatabaseModel
    {
        private static ManagerModel instance = null;

        private ManagerModel() { }

        /// <summary>
        /// Singleton pattern 
        /// </summary>
        public static ManagerModel getInstance()
        {
            if (instance == null)
            {
                instance = new ManagerModel();
            }
            return instance;
        }

        /// <summary>
        /// Get a manager profile by his username
        /// </summary>
        public ManagerProfile getManagerByName(string name)
        {
            ManagerProfile result = null;
            if(ConnectionState == true)
            {
                result = db.ManagerProfile.FirstOrDefault(manager => manager.UserName == name);
            }
            return result;
        }

        /// <summary>
        /// Resets the password and sets a temporary one
        /// </summary>
        public void setTempPassword(ManagerProfile manager,string tmpPassword)
        {
            if (ConnectionState == true)
            {
                var user = db.ManagerProfile.FirstOrDefault(m => m.AccountID == manager.AccountID);
                user.TempPassword = MoneyMakerHelper.getHash(tmpPassword);
                user.Password = null;
                db.SubmitChanges();
            }
        }

        public ManagerProfile getDefaultManager()
        {
            ManagerProfile result = null;
            if(ConnectionState == true)
            {
                result = db.ManagerProfile.FirstOrDefault();
            }
            return result;
        }

        /// <summary>
        /// Resets the tempory password and sets a password
        /// </summary>
        public void setPassword(ManagerProfile manager, string password)
        {
            if (ConnectionState == true)
            {
                var user = db.ManagerProfile.FirstOrDefault(m => m.AccountID == manager.AccountID);
                user.TempPassword = null;
                user.Password = MoneyMakerHelper.getHash(password);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Add a new manager
        /// </summary>
        /// <param name="manager"></param>
        public void addManager(ManagerProfile manager)
        {
            if (ConnectionState == true)
            {
                db.ManagerProfile.InsertOnSubmit(manager);
                db.SubmitChanges();
            }
        }

        public bool getManagerProfileByTempPassword(string tmpPassword, string newPassword)
        {
            bool result = false;
            if (ConnectionState == true)
            {
                ManagerProfile manager = (from u in db.ManagerProfile
                                        where u.TempPassword == MoneyMakerHelper.getHash(tmpPassword)
                                        select u).FirstOrDefault();
                
                if(manager != null)
                {
                    manager.Password = MoneyMakerHelper.getHash(newPassword);
                    manager.TempPassword = null;

                    db.SubmitChanges();
                    result = true;
                }
            }
            return result;
        }
        
    }
}
