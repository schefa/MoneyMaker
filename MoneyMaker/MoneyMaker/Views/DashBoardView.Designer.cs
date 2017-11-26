namespace MoneyMaker.Views
{
    partial class DashBoardView
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
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnLeasingCalculator = new System.Windows.Forms.Button();
            this.btnLoanCalculator = new System.Windows.Forms.Button();
            this.btnWatchlists = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnUserProfiles = new System.Windows.Forms.Button();
            this.pbMMLogo = new System.Windows.Forms.PictureBox();
            this.lblMoneyMaker = new System.Windows.Forms.Label();
            this.pnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDashboard
            // 
            this.pnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDashboard.Controls.Add(this.btnBank);
            this.pnDashboard.Controls.Add(this.btnLeasingCalculator);
            this.pnDashboard.Controls.Add(this.btnLoanCalculator);
            this.pnDashboard.Controls.Add(this.btnWatchlists);
            this.pnDashboard.Controls.Add(this.btnDepot);
            this.pnDashboard.Controls.Add(this.btnUserProfiles);
            this.pnDashboard.Location = new System.Drawing.Point(20, 121);
            this.pnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(768, 287);
            this.pnDashboard.TabIndex = 32;
            // 
            // btnBank
            // 
            this.btnBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Image = global::MoneyMaker.Properties.Resources.BankIcon95;
            this.btnBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBank.Location = new System.Drawing.Point(490, 138);
            this.btnBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(234, 118);
            this.btnBank.TabIndex = 29;
            this.btnBank.Text = "Bank";
            this.btnBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnLeasingCalculator
            // 
            this.btnLeasingCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeasingCalculator.Image = global::MoneyMaker.Properties.Resources.LeasingIcon95;
            this.btnLeasingCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeasingCalculator.Location = new System.Drawing.Point(252, 138);
            this.btnLeasingCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeasingCalculator.Name = "btnLeasingCalculator";
            this.btnLeasingCalculator.Size = new System.Drawing.Size(234, 118);
            this.btnLeasingCalculator.TabIndex = 28;
            this.btnLeasingCalculator.Text = "Leasing\r\nRechner\r\n";
            this.btnLeasingCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeasingCalculator.UseVisualStyleBackColor = true;
            this.btnLeasingCalculator.Click += new System.EventHandler(this.btnLeasingCalculator_Click);
            // 
            // btnLoanCalculator
            // 
            this.btnLoanCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCalculator.Image = global::MoneyMaker.Properties.Resources.LoanIcon95;
            this.btnLoanCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoanCalculator.Location = new System.Drawing.Point(14, 138);
            this.btnLoanCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoanCalculator.Name = "btnLoanCalculator";
            this.btnLoanCalculator.Size = new System.Drawing.Size(234, 118);
            this.btnLoanCalculator.TabIndex = 27;
            this.btnLoanCalculator.Text = "Kredit\r\nRechner";
            this.btnLoanCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoanCalculator.UseVisualStyleBackColor = true;
            this.btnLoanCalculator.Click += new System.EventHandler(this.btnLoanCalculator_Click);
            // 
            // btnWatchlists
            // 
            this.btnWatchlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchlists.Image = global::MoneyMaker.Properties.Resources.WatchlistIcon95;
            this.btnWatchlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatchlists.Location = new System.Drawing.Point(490, 16);
            this.btnWatchlists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWatchlists.Name = "btnWatchlists";
            this.btnWatchlists.Size = new System.Drawing.Size(234, 118);
            this.btnWatchlists.TabIndex = 26;
            this.btnWatchlists.Text = "Watchlists";
            this.btnWatchlists.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWatchlists.UseVisualStyleBackColor = true;
            this.btnWatchlists.Click += new System.EventHandler(this.btnWatchlists_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepot.Image = global::MoneyMaker.Properties.Resources.DepotIcon95;
            this.btnDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepot.Location = new System.Drawing.Point(252, 16);
            this.btnDepot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(234, 118);
            this.btnDepot.TabIndex = 25;
            this.btnDepot.Text = "Depot";
            this.btnDepot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepot.UseVisualStyleBackColor = true;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // btnUserProfiles
            // 
            this.btnUserProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfiles.Image = global::MoneyMaker.Properties.Resources.UserProfilesIcon95;
            this.btnUserProfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserProfiles.Location = new System.Drawing.Point(14, 16);
            this.btnUserProfiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfiles.Name = "btnUserProfiles";
            this.btnUserProfiles.Size = new System.Drawing.Size(234, 118);
            this.btnUserProfiles.TabIndex = 24;
            this.btnUserProfiles.Text = "Benutzer\r\nProfile";
            this.btnUserProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserProfiles.UseVisualStyleBackColor = true;
            this.btnUserProfiles.Click += new System.EventHandler(this.btnUserProfiles_Click);
            // 
            // pbMMLogo
            // 
            this.pbMMLogo.Image = global::MoneyMaker.Properties.Resources.logo;
            this.pbMMLogo.Location = new System.Drawing.Point(20, 22);
            this.pbMMLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMMLogo.Name = "pbMMLogo";
            this.pbMMLogo.Size = new System.Drawing.Size(83, 82);
            this.pbMMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMMLogo.TabIndex = 30;
            this.pbMMLogo.TabStop = false;
            // 
            // lblMoneyMaker
            // 
            this.lblMoneyMaker.Font = new System.Drawing.Font("Tw Cen MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyMaker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMoneyMaker.Location = new System.Drawing.Point(108, 22);
            this.lblMoneyMaker.Name = "lblMoneyMaker";
            this.lblMoneyMaker.Size = new System.Drawing.Size(517, 82);
            this.lblMoneyMaker.TabIndex = 31;
            this.lblMoneyMaker.Text = "MoneyMaker";
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnDashboard);
            this.Controls.Add(this.pbMMLogo);
            this.Controls.Add(this.lblMoneyMaker);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoardView";
            this.Size = new System.Drawing.Size(788, 408);
            this.pnDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMMLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMoneyMaker;
        private System.Windows.Forms.PictureBox pbMMLogo;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnLeasingCalculator;
        private System.Windows.Forms.Button btnLoanCalculator;
        private System.Windows.Forms.Button btnWatchlists;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button btnUserProfiles;
    }
}
