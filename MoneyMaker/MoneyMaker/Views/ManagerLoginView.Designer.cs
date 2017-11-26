namespace MoneyMaker.Views
{
    partial class ManagerLoginView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistration = new System.Windows.Forms.Button();
            this.klblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblRegistrationInfo = new System.Windows.Forms.Label();
            this.panelHorzLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.Location = new System.Drawing.Point(234, 107);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(127, 31);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "Registrieren";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // klblForgotPassword
            // 
            this.klblForgotPassword.AutoSize = true;
            this.klblForgotPassword.LinkColor = System.Drawing.Color.RoyalBlue;
            this.klblForgotPassword.Location = new System.Drawing.Point(45, 173);
            this.klblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.klblForgotPassword.Name = "klblForgotPassword";
            this.klblForgotPassword.Size = new System.Drawing.Size(201, 30);
            this.klblForgotPassword.TabIndex = 5;
            this.klblForgotPassword.TabStop = true;
            this.klblForgotPassword.Text = "Passwort vergessen";
            this.klblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblForgotPassword_LinkClicked);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(30, 81);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.Size = new System.Drawing.Size(140, 37);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Benutzername";
            // 
            // cbxPassword
            // 
            this.cbxPassword.AutoSize = true;
            this.cbxPassword.Location = new System.Drawing.Point(30, 107);
            this.cbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.Size = new System.Drawing.Size(222, 34);
            this.cbxPassword.TabIndex = 3;
            this.cbxPassword.Text = "Passwort anzeigen";
            this.cbxPassword.UseVisualStyleBackColor = true;
            this.cbxPassword.CheckedChanged += new System.EventHandler(this.cbxPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(30, 137);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(30, 34);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(140, 37);
            this.tbxUserName.TabIndex = 1;
            // 
            // lblRegistrationInfo
            // 
            this.lblRegistrationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrationInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationInfo.Location = new System.Drawing.Point(223, 77);
            this.lblRegistrationInfo.Name = "lblRegistrationInfo";
            this.lblRegistrationInfo.Size = new System.Drawing.Size(166, 22);
            this.lblRegistrationInfo.TabIndex = 36;
            this.lblRegistrationInfo.Text = "Neuen Benutzer anmelden";
            // 
            // panelHorzLine
            // 
            this.panelHorzLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHorzLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorzLine.Location = new System.Drawing.Point(196, 17);
            this.panelHorzLine.Name = "panelHorzLine";
            this.panelHorzLine.Size = new System.Drawing.Size(1, 180);
            this.panelHorzLine.TabIndex = 37;
            // 
            // ManagerLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHorzLine);
            this.Controls.Add(this.lblRegistrationInfo);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.klblForgotPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerLoginView";
            this.Size = new System.Drawing.Size(391, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.LinkLabel klblForgotPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblRegistrationInfo;
        private System.Windows.Forms.Panel panelHorzLine;
    }
}
