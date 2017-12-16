namespace MoneyMaker.Views
{
    partial class SettingsView
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
            this.lblInfoText = new System.Windows.Forms.Label();
            this.lblDataProviderInfo = new System.Windows.Forms.Label();
            this.cbxDataProvider = new System.Windows.Forms.ComboBox();
            this.tbPasswordOld = new System.Windows.Forms.TextBox();
            this.tbPasswordNew1 = new System.Windows.Forms.TextBox();
            this.tbPasswordNew2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPasswordNew2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblCurrencyInfo = new System.Windows.Forms.Label();
            this.cbxCurrencies = new System.Windows.Forms.ComboBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudCapitalGainTax = new System.Windows.Forms.NumericUpDown();
            this.lblCapitalGainTax = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCharNote = new System.Windows.Forms.Label();
            this.tabSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalGainTax)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoText
            // 
            this.lblInfoText.AutoSize = true;
            this.lblInfoText.Location = new System.Drawing.Point(20, 39);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(273, 13);
            this.lblInfoText.TabIndex = 0;
            this.lblInfoText.Text = "Hier können Sie grundlegende Einstellungen vornehmen";
            // 
            // lblDataProviderInfo
            // 
            this.lblDataProviderInfo.AutoSize = true;
            this.lblDataProviderInfo.Location = new System.Drawing.Point(19, 80);
            this.lblDataProviderInfo.Name = "lblDataProviderInfo";
            this.lblDataProviderInfo.Size = new System.Drawing.Size(67, 13);
            this.lblDataProviderInfo.TabIndex = 1;
            this.lblDataProviderInfo.Text = "Börsendaten";
            // 
            // cbxDataProvider
            // 
            this.cbxDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataProvider.FormattingEnabled = true;
            this.cbxDataProvider.Location = new System.Drawing.Point(164, 77);
            this.cbxDataProvider.Name = "cbxDataProvider";
            this.cbxDataProvider.Size = new System.Drawing.Size(158, 21);
            this.cbxDataProvider.TabIndex = 2;
            // 
            // lblCurrencyInfo
            // 
            this.lblCurrencyInfo.AutoSize = true;
            this.lblCurrencyInfo.Location = new System.Drawing.Point(20, 108);
            this.lblCurrencyInfo.Name = "lblCurrencyInfo";
            this.lblCurrencyInfo.Size = new System.Drawing.Size(51, 13);
            this.lblCurrencyInfo.TabIndex = 10;
            this.lblCurrencyInfo.Text = "Währung";
            // 
            // cbxCurrencies
            // 
            this.cbxCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrencies.FormattingEnabled = true;
            this.cbxCurrencies.Location = new System.Drawing.Point(164, 108);
            this.cbxCurrencies.Name = "cbxCurrencies";
            this.cbxCurrencies.Size = new System.Drawing.Size(158, 21);
            this.cbxCurrencies.TabIndex = 11;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Controls.Add(this.tabPage2);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(708, 401);
            this.tabSettings.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCapitalGainTax);
            this.tabPage1.Controls.Add(this.lblCapitalGainTax);
            this.tabPage1.Controls.Add(this.lblInfoText);
            this.tabPage1.Controls.Add(this.cbxCurrencies);
            this.tabPage1.Controls.Add(this.lblDataProviderInfo);
            this.tabPage1.Controls.Add(this.lblCurrencyInfo);
            this.tabPage1.Controls.Add(this.cbxDataProvider);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Einstellungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudCapitalGainTax
            // 
            this.nudCapitalGainTax.Location = new System.Drawing.Point(164, 149);
            this.nudCapitalGainTax.Name = "nudCapitalGainTax";
            this.nudCapitalGainTax.Size = new System.Drawing.Size(158, 20);
            this.nudCapitalGainTax.TabIndex = 13;
            this.nudCapitalGainTax.ValueChanged += new System.EventHandler(this.nudCapitalGainTax_ValueChanged);
            // 
            // lblCapitalGainTax
            // 
            this.lblCapitalGainTax.AutoSize = true;
            this.lblCapitalGainTax.Location = new System.Drawing.Point(20, 151);
            this.lblCapitalGainTax.Name = "lblCapitalGainTax";
            this.lblCapitalGainTax.Size = new System.Drawing.Size(105, 13);
            this.lblCapitalGainTax.TabIndex = 12;
            this.lblCapitalGainTax.Text = "Kapitalerstragssteuer";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCharNote);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnChangePassword);
            this.tabPage2.Controls.Add(this.tbPasswordOld);
            this.tabPage2.Controls.Add(this.lblPasswordNew2);
            this.tabPage2.Controls.Add(this.tbPasswordNew1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbPasswordNew2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Passwort ändern";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCharNote
            // 
            this.lblCharNote.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharNote.Location = new System.Drawing.Point(185, 103);
            this.lblCharNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharNote.Name = "lblCharNote";
            this.lblCharNote.Size = new System.Drawing.Size(156, 12);
            this.lblCharNote.TabIndex = 10;
            this.lblCharNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tabSettings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(708, 401);
            this.tabSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalGainTax)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfoText;
        private System.Windows.Forms.Label lblDataProviderInfo;
        private System.Windows.Forms.ComboBox cbxDataProvider;
        private System.Windows.Forms.TextBox tbPasswordOld;
        private System.Windows.Forms.TextBox tbPasswordNew1;
        private System.Windows.Forms.TextBox tbPasswordNew2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPasswordNew2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblCurrencyInfo;
        private System.Windows.Forms.ComboBox cbxCurrencies;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCharNote;
        private System.Windows.Forms.NumericUpDown nudCapitalGainTax;
        private System.Windows.Forms.Label lblCapitalGainTax;
    }
}
