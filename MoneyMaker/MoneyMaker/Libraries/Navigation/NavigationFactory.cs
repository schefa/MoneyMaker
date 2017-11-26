using System.Windows.Forms;

namespace MoneyMaker.Libraries.Navigation
{

    /// <summary>
    /// Factory pattern to create flawless navigation
    /// @author : Fjodor Schäfer
    /// </summary>
    public class NavigationFactory
    {

        public static UserControl create(NavigationType type, NavigationParams parameters = null)
        {
            NavigationParams navParams = (parameters != null) ? parameters : new NavigationParams();

            UserControl result;
            switch (type)
            {
                case NavigationType.BankAccount: result = new Views.BankAccountView(); break;
                default: case NavigationType.Dashboard: result = new Views.DashBoardView(); break;
                case NavigationType.CurrencyCalculator: result = new Views.CurrencyCalculatorView(); break;
                case NavigationType.Depot: result = new Views.DepotView(); break;
                case NavigationType.LoanCalculator: result = new Views.LoanCalculatorView(); break;
                case NavigationType.Loans: result = new Views.LoansView(); break;
                case NavigationType.Legal: result = new Views.LegalView(); break;
                case NavigationType.LeasingCalculator: result = new Views.LeasingCalculatorView(); break;
                case NavigationType.Leasings: result = new Views.LeasingsView(); break;
                case NavigationType.ManagerLogin: result = new Views.ManagerLoginView(); break;
                case NavigationType.ManagerRegistration: result = new Views.ManagerRegistrationView(); break;
                case NavigationType.ManagerPasswordReset: result = new Views.ManagerPasswordResetView(); break;
                case NavigationType.Redemptions: result = new Views.RedemptionsView(); break;
                case NavigationType.RedemptionCalculator: result = new Views.RedemptionCalculatorView(); break;
                case NavigationType.Settings: result = new Views.SettingsView(); break;
                case NavigationType.UserProfiles: result = new Views.UserProfilesView(); break;
                case NavigationType.Watchlist: result = new Views.WatchlistView(navParams.Watchlist); break;
                case NavigationType.Watchlists: result = new Views.WatchlistsView(); break;
            }
            result.Dock = DockStyle.Fill;
            return result;
        }
    }
    
    public enum NavigationType
    {
        BankAccount,
        CurrencyCalculator,
        Dashboard,
        Depot,
        Legal,
        LeasingCalculator,
        Leasings,
        LoanCalculator,
        Loans,
        ManagerLogin,
        ManagerRegistration,
        ManagerPasswordReset,
        RedemptionCalculator,
        Redemptions,
        Settings,
        UserProfiles,
        Watchlist,
        Watchlists,
    }
}
