using System;
using System.Drawing;
using System.Windows.Forms;
using MoneyMaker.Models.Database;
using MoneyMaker.ViewModels;
using MoneyMaker.Helpers;
using System.Net.Mail;

namespace MoneyMaker.Views
{
    public partial class ManagerRegistrationView : LoginView
    {
        private bool passwortStrength = false;
        public ManagerRegistrationView()
        {
            InitializeComponent();            
        }

        // method that creates and saves a new manager in the database  
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // gets the current manager from the database
            var manager = ManagerModel.getInstance().getManagerByName(txtUserName.Text);

            DatabaseModel dbModel = new DatabaseModel();    
            
            // if the database connection is true and if the manger is not existing
            if (dbModel.ConnectionState == true && manager == null && txtPassword.Text != string.Empty)
            {
                if(!IsValidEmailAddress(txtEmail.Text))
                {
                    parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Falsche Emailadresse");                    
                }
                else
                {
                    if (passwortStrength == true)
                    {
                        if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                        {
                            // creates a new manager
                            manager = new ManagerProfile()
                            {
                                UserName = txtUserName.Text,
                                Password = MoneyMakerHelper.getHash(txtPassword.Text),
                                Email = txtEmail.Text
                            };

                            // adds the manager to the database
                            ManagerModel.getInstance().addManager(manager);                       

                            MessageBox.Show($"Benutzer \"{txtUserName.Text}\" wurde erfolgreich angelegt.");

                            // opens the FrmMain form and closes the current form
                            ParentForm.Hide();
                            Form frmMain = new FrmMain(manager);
                            frmMain.ShowDialog();
                            ParentForm.Close();
                        }
                        else
                        {
                            parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Die Passwörter sind unterschiedlich");                            
                        }
                    }
                    else
                    {
                        parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Passwort ist zu schwach");
                        
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = string.Empty;
                    }     
                }         
            }
            else
            {
                parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Benuter kann nicht angelegt werden.");                
            }           
        }

        // ckecks if the string is a email address
        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ckecks if the password is strength enough
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {   
            // checks if the textbox txtpassword ist null or empty         
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblCharNote.Text = "";
            }
            else if (MoneyMakerHelper.isPasswordStrength(txtPassword.Text) == false)
            {
                lblCharNote.ForeColor = Color.DarkRed;
                lblCharNote.Text = "Passwort ist zu schwach";
                passwortStrength = false;              
            }
            else if (MoneyMakerHelper.isPasswordStrength(txtPassword.Text) == true)
            {
                lblCharNote.ForeColor = Color.DarkGreen;
                lblCharNote.Text = "";
                passwortStrength = true;
            }
        }
    }
}
