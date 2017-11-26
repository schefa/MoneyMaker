using System.Windows.Forms;

namespace MoneyMaker.Libraries.Login
{
    /// <summary>
    /// Proxy Pattern for login procedure
    /// @author : Niclas Janßen
    /// </summary>
    public interface ILogin
    {
        void request(Form parentForm, string txtUserName, string txtPassword);
    }
}
