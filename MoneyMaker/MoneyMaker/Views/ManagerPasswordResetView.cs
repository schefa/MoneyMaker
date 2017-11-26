using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.ViewModels;
using MoneyMaker.Libraries.Navigation;
using System.Drawing;
using MoneyMaker.Helpers;

namespace MoneyMaker.Views
{
    public partial class ManagerPasswordResetView : LoginView
    {
        private bool passwortStrength = false;

        public ManagerPasswordResetView()
        {
            InitializeComponent();
        }

        // method that resets the password
        private async void btnSavePassword_Click(object sender, EventArgs e)
        {
            // ckecks if the password is the same as the confirmPassword 
            if (txtNewPassword.Text.Equals(txtConfirmPassword.Text) && passwortStrength == true)
            {
                // writes a comment into the statusstrip
                parentLoginForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Passwort wird geändert");
                Task<bool> task = Task.Run(() => ManagerModel.getInstance().getManagerProfileByTempPassword(txtTempPassword.Text,txtNewPassword.Text));
                var success = await task;
                if(success)
                {
                    // opens the form FrmLogin and closes the current form
                    Parent.Controls.Add(NavigationFactory.create(NavigationType.ManagerLogin));
                    Parent.Controls.Remove(this);
                    
                    parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Passwort geändert");
                }
                else
                {
                    parentLoginForm.notifyUser(FrmMain.NotifyType.ErrorMessage, "Passwort konnte nicht geändert werden");
                }
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                lblCharNote.Text = "";
            }
            else if (MoneyMakerHelper.isPasswordStrength(txtNewPassword.Text) == false)
            {
                lblCharNote.ForeColor = Color.DarkRed;
                lblCharNote.Text = "Passwort ist zu schwach";
                passwortStrength = false;
            }
            else if (MoneyMakerHelper.isPasswordStrength(txtNewPassword.Text) == true)
            {
                lblCharNote.ForeColor = Color.DarkGreen;
                lblCharNote.Text = "";
                passwortStrength = true;
            }
        }
    }
}
