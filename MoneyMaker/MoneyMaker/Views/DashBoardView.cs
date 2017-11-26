using System;
using System.Drawing;
using System.Windows.Forms;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Navigation;

namespace MoneyMaker.Views
{
    public partial class DashBoardView : MoneyMakerView
    { 

        public DashBoardView()
        { 
            InitializeComponent();
            mainForm.setHeadline("Dashboard");
        }
        
        private void navigate(UserControl view)
        {
            Cursor = Cursors.AppStarting;
            Parent.Controls.Add(view);
            Parent.Controls.Remove(this);
        }

        private void btnUserProfiles_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.UserProfiles));
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.Depot));
        }

        private void btnWatchlists_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.Watchlists));
        }

        private void btnLoanCalculator_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.LoanCalculator));
        }

        private void btnLeasingCalculator_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.LeasingCalculator));
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            navigate(NavigationFactory.create(NavigationType.BankAccount));
        }
    }
}
