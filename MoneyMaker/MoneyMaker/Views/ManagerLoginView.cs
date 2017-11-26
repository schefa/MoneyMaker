using System;
using System.Windows.Forms;
using System.Net.Mail;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Login;
using MoneyMaker.ViewModels;
using MoneyMaker.Libraries.Navigation;

namespace MoneyMaker.Views
{
    public partial class ManagerLoginView : LoginView
    {
        private Proxy proxy = new Proxy();       
        private int count = 1;
        private Timer timer;

        public ManagerLoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// the FrmLogin adds the view ManagerRegistrationView and remove the actual view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.ManagerRegistration));
            Parent.Controls.Remove(this);
        }
       
        // method that disables the password input after 3 attemps for a certain time
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // checking if the password was entered incorrectly more than 3 times
            if (count < 3)
            {
                count++;
                // tranfers the login request to the proxy
                proxy.request(ParentForm, tbxUserName.Text, tbxPassword.Text, null);
            }
            else
            {
                // writes a comment into the statusStrip
                parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Passwort zu oft falsch eingegeben! Bitte warten Sie eine Minute.");
                               
               
                // disables the password input for one minute
                timer = new Timer();
                timer.Interval = 6000;                
                timer.Tick += OnTimedEvent;                
                timer.Start();
                btnLogin.Enabled = false;
                count = 1;
                
            }
        }
        
        // event method that stops the timer and enables the password input
        public void OnTimedEvent(object sender, EventArgs e)
        {
            timer.Stop();

            btnLogin.Enabled = true;
        }

        // method that checks if the password should be hidden or not
        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPassword.Checked == true)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '\u25cf';
            }
        }

        // method that resets the password
        private void klblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbxUserName.Text != "")
            {
                ManagerProfile manager = ManagerModel.getInstance().getManagerByName(tbxUserName.Text);
                if(manager == null)
                {
                    // writes a comment into the statusStrip
                    parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Managerprofil existiert nicht!"); 
                }
                else
                {
                    // sends the user a mail with a temp password
                    string password = createTempPassword(8);
                    sendAutoMailAsync(manager.Email, password);

                    // writes the temp password into the database
                    ManagerModel.getInstance().setTempPassword(manager, password);
                    
                    // adds the view ManagerPasswordResetView to the FrmLogin and remove the actual view
                    Parent.Controls.Add(NavigationFactory.create(NavigationType.ManagerPasswordReset));
                    Parent.Controls.Remove(this);
                }
            }
            else
            {
                parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bitte Benutzernamen eingeben");                
            }                   
        }

        // creates a temp password
        public string createTempPassword(int passwordLength)
        {
            const string allowedChars = "abcdefhhijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string specialCharacters = @"!#$%&'(){}*+~,-./:;<=>?!@[\]_";

            char[] chars = new char[passwordLength];

            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                if (i % rd.Next(3, passwordLength) == 0)
                {
                    chars[i] = specialCharacters[rd.Next(0, specialCharacters.Length)];
                }
                else
                {
                    chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
                }
            }
            return new string(chars);
        }        

        // sends a mail to the user
        public async void sendAutoMailAsync(string email, string newPassword)
        {

            // writes a comment into the statusStrip
            parentLoginForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Email wird verschickt");
            
            // creates a mail
            using (MailMessage mail = new MailMessage("fjodor.schaefer@stud.fh-flensburg.de", email))
            {
                mail.Subject = "Automatische Mail von MoneyMaker: Neues Passwort";
                string body = "Hallo " + tbxUserName.Text + ","
                            + "<br /> Sie haben ein neues Passwort für ihren Account beantragt."
                            + "<br />Ihr temporäres Passwort lautet: " + newPassword
                            + "<br /> Bitte legen Sie ein neues Passwort fest!"
                            + "<br /> Ihr MoneyMaker-Team";
                mail.Body = body;
                mail.IsBodyHtml = true;

                // send a mail
                SmtpClient client = new SmtpClient("localhost");

                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "mail.stud.fh-flensburg.de";

                await client.SendMailAsync(mail);
                    
            }

            // writes a comment into the statusStrip
            parentLoginForm.notifyUser(FrmMain.NotifyType.StatusMessage);
            
        }

        // method that perfoms a button click
        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin.PerformClick();                               
            }
        }
    }
}
