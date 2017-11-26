namespace MoneyMaker.Models.Entities
{
    /// <summary>
    /// Single watchlist class which represents the database entity
    /// </summary>
    public class Watchlist
    {
        private string title;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        // etc.
    }
}
