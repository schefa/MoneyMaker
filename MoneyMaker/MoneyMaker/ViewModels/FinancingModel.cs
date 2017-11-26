using MoneyMaker.Models.Database;
using MoneyMaker.Models;
using System.Collections.Generic;

namespace MoneyMaker.ViewModels
{
    /// <summary>
    /// abstract base class for all financing models, demands a generic type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FinancingModel<T> : DatabaseModel where T : FinancingItem
    {
        
        protected UserProfile user;

        public FinancingModel(UserProfile user)
        {
            this.user = user;
        }

        public abstract T getItem(int id);

        public abstract void updateItem(T itemToSave);

        public abstract void createItem(T itemToSave);

        public abstract void deleteItem(int id);

        public abstract List<T> getItems();
    }
}
