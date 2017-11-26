using MoneyMaker.Models.Database;
using System.Windows.Forms;

namespace MoneyMaker.Libraries.Login
{
    /// <summary>
    /// Proxy Pattern for login procedure
    /// @author : Niclas Janßen
    /// </summary>
    public class RealProgram
    {
        public void request(Form parentForm, string txtUserName, string txtPassword, ManagerProfile managerProfile)
        {
            parentForm.Hide();            
            Form frmMain = new FrmMain(managerProfile);
            frmMain.ShowDialog();
            parentForm.Close();
        }
    }
}
