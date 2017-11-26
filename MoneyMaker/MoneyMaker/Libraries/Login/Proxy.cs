using MoneyMaker.Models.Database;
using MoneyMaker.ViewModels;
using MoneyMaker.Views;
using System.Windows.Forms;
using MoneyMaker.Helpers;

namespace MoneyMaker.Libraries.Login
{
    /// <summary>
    /// Proxy Pattern for login procedure
    /// @author : Niclas Janßen
    /// </summary>
    public class Proxy
    {
        private RealProgram realProgram = new RealProgram();
        public void request(Form parentForm, string txtUserName, string txtPassword, ManagerProfile managerProfile)
        {
            string output = "Login fehlgeschlagen";
            
            ManagerProfile manager = ManagerModel.getInstance().getManagerByName(txtUserName);          

            if (manager != null && manager.Password != null && manager.Password.Equals(MoneyMakerHelper.getHash(txtPassword)))
            {
                realProgram.request(parentForm, txtUserName, txtPassword, manager);
            }
            else
            {                
                MessageBox.Show(output);
            }
        }
    }
}
