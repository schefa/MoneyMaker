namespace MoneyMaker.Views
{
    partial class CurrencyCalculatorView
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
            this.components = new System.ComponentModel.Container();
            this.cbxCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.nupCurrencyFrom = new System.Windows.Forms.NumericUpDown();
            this.lblMyCurrency = new System.Windows.Forms.Label();
            this.panelCurrencies = new System.Windows.Forms.Panel();
            this.lblRates = new System.Windows.Forms.Label();
            this.currencyTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupCurrencyFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCurrencyFrom
            // 
            this.cbxCurrencyFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrencyFrom.FormattingEnabled = true;
            this.cbxCurrencyFrom.Location = new System.Drawing.Point(14, 35);
            this.cbxCurrencyFrom.Name = "cbxCurrencyFrom";
            this.cbxCurrencyFrom.Size = new System.Drawing.Size(104, 23);
            this.cbxCurrencyFrom.TabIndex = 12;
            // 
            // nupCurrencyFrom
            // 
            this.nupCurrencyFrom.DecimalPlaces = 2;
            this.nupCurrencyFrom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupCurrencyFrom.Location = new System.Drawing.Point(14, 66);
            this.nupCurrencyFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupCurrencyFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupCurrencyFrom.Name = "nupCurrencyFrom";
            this.nupCurrencyFrom.Size = new System.Drawing.Size(105, 23);
            this.nupCurrencyFrom.TabIndex = 15;
            this.nupCurrencyFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currencyTooltip.SetToolTip(this.nupCurrencyFrom, "Ihre Anzahl der Währungseinheiten. Setzen Sie die Pfeile hoch/runter oder tippen " +
        "Sie eine Zahl ein und drücken auf Enter");
            this.nupCurrencyFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMyCurrency
            // 
            this.lblMyCurrency.AutoSize = true;
            this.lblMyCurrency.Location = new System.Drawing.Point(12, 14);
            this.lblMyCurrency.Name = "lblMyCurrency";
            this.lblMyCurrency.Size = new System.Drawing.Size(92, 15);
            this.lblMyCurrency.TabIndex = 17;
            this.lblMyCurrency.Text = "Meine Währung";
            // 
            // panelCurrencies
            // 
            this.panelCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrencies.AutoScroll = true;
            this.panelCurrencies.Location = new System.Drawing.Point(140, 35);
            this.panelCurrencies.Name = "panelCurrencies";
            this.panelCurrencies.Size = new System.Drawing.Size(259, 355);
            this.panelCurrencies.TabIndex = 18;
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(147, 14);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(79, 15);
            this.lblRates.TabIndex = 19;
            this.lblRates.Text = "Wechselkurse";
            // 
            // currencyTooltip
            // 
            this.currencyTooltip.AutoPopDelay = 5000;
            this.currencyTooltip.InitialDelay = 200;
            this.currencyTooltip.ReshowDelay = 100;
            // 
            // CurrencyCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.panelCurrencies);
            this.Controls.Add(this.lblMyCurrency);
            this.Controls.Add(this.nupCurrencyFrom);
            this.Controls.Add(this.cbxCurrencyFrom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CurrencyCalculatorView";
            this.Size = new System.Drawing.Size(422, 413);
            ((System.ComponentModel.ISupportInitialize)(this.nupCurrencyFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCurrencyFrom;
        private System.Windows.Forms.NumericUpDown nupCurrencyFrom;
        private System.Windows.Forms.Label lblMyCurrency;
        private System.Windows.Forms.Panel panelCurrencies;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.ToolTip currencyTooltip;
    }
}
