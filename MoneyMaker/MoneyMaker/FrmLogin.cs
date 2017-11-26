using MoneyMaker.Libraries.Navigation;
using System.Drawing;
using System.Windows.Forms;

namespace MoneyMaker
{
    public partial class FrmLogin : Form
    {
        private static FrmLogin current = null;
        public static FrmLogin Current
        {
            get { return current; }
        }

        public FrmLogin()
        {
            InitializeComponent();
            if(current == null)
            {
                current = this;
            }
            Icon = Properties.Resources.LogoIcon;
            panelLogin.Controls.Add(NavigationFactory.create(NavigationType.ManagerLogin));
        }


        #region Status Messages
        public void notifyUser(FrmMain.NotifyType type, string strMessage = "")
        {
            switch (type)
            {
                case FrmMain.NotifyType.StatusMessage:
                    strMessage = (strMessage.Length > 0) ? strMessage : "";
                    this.Cursor = Cursors.Default;
                    break;
                case FrmMain.NotifyType.PrepareMessage:
                    this.Cursor = Cursors.WaitCursor;
                    break;
                case FrmMain.NotifyType.ErrorMessage:
                    statusStrip.BackColor = Color.Red;
                    statusLabel.ForeColor = Color.White;
                    break;
            }

            statusLabel.Text = strMessage;
        }
        
        #endregion    
    }
}
