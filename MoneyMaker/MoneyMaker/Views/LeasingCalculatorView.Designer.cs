namespace MoneyMaker.Views
{
    partial class LeasingCalculatorView
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
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLeasingRateIntervall = new System.Windows.Forms.ComboBox();
            this.cbDurationMode = new System.Windows.Forms.ComboBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.tbRecoveryValue = new System.Windows.Forms.TextBox();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.splitLeasing = new System.Windows.Forms.SplitContainer();
            this.gpRedemptionTable = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLeasingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnShowAll = new System.Windows.Forms.Button();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.pnResultSplit = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStartValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLeasingRate = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeasing)).BeginInit();
            this.splitLeasing.Panel1.SuspendLayout();
            this.splitLeasing.Panel2.SuspendLayout();
            this.splitLeasing.SuspendLayout();
            this.gpRedemptionTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.Location = new System.Drawing.Point(199, 382);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(49, 28);
            this.lblTotalExpense.TabIndex = 34;
            this.lblTotalExpense.Text = "0,00";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 28);
            this.label14.TabIndex = 32;
            this.label14.Text = "Gesamtaufwand: ";
            // 
            // cbLeasingRateIntervall
            // 
            this.cbLeasingRateIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeasingRateIntervall.FormattingEnabled = true;
            this.cbLeasingRateIntervall.Items.AddRange(new object[] {
            "monatlich",
            "vierteljährlich",
            "halbjährlich",
            "jährlich"});
            this.cbLeasingRateIntervall.Location = new System.Drawing.Point(324, 146);
            this.cbLeasingRateIntervall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeasingRateIntervall.Name = "cbLeasingRateIntervall";
            this.cbLeasingRateIntervall.Size = new System.Drawing.Size(125, 28);
            this.cbLeasingRateIntervall.TabIndex = 5;
            // 
            // cbDurationMode
            // 
            this.cbDurationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationMode.FormattingEnabled = true;
            this.cbDurationMode.Items.AddRange(new object[] {
            "Monate",
            "Jahre"});
            this.cbDurationMode.Location = new System.Drawing.Point(324, 229);
            this.cbDurationMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDurationMode.Name = "cbDurationMode";
            this.cbDurationMode.Size = new System.Drawing.Size(125, 28);
            this.cbDurationMode.TabIndex = 7;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(195, 229);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(120, 27);
            this.tbDuration.TabIndex = 6;
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(195, 66);
            this.tbDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(120, 27);
            this.tbDeposit.TabIndex = 2;
            this.tbDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // tbRecoveryValue
            // 
            this.tbRecoveryValue.Location = new System.Drawing.Point(195, 270);
            this.tbRecoveryValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRecoveryValue.Name = "tbRecoveryValue";
            this.tbRecoveryValue.Size = new System.Drawing.Size(120, 27);
            this.tbRecoveryValue.TabIndex = 8;
            this.tbRecoveryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(195, 106);
            this.tbInterestRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(120, 27);
            this.tbInterestRate.TabIndex = 3;
            this.tbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // splitLeasing
            // 
            this.splitLeasing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeasing.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitLeasing.Location = new System.Drawing.Point(0, 0);
            this.splitLeasing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitLeasing.Name = "splitLeasing";
            this.splitLeasing.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeasing.Panel1
            // 
            this.splitLeasing.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitLeasing.Panel1.Controls.Add(this.gpRedemptionTable);
            this.splitLeasing.Panel1.Controls.Add(this.tbnShowAll);
            this.splitLeasing.Panel1MinSize = 60;
            // 
            // splitLeasing.Panel2
            // 
            this.splitLeasing.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitLeasing.Panel2.Controls.Add(this.lblPercent);
            this.splitLeasing.Panel2.Controls.Add(this.lblTotalInterest);
            this.splitLeasing.Panel2.Controls.Add(this.label6);
            this.splitLeasing.Panel2.Controls.Add(this.btnShowTable);
            this.splitLeasing.Panel2.Controls.Add(this.pnResultSplit);
            this.splitLeasing.Panel2.Controls.Add(this.btnCalculate);
            this.splitLeasing.Panel2.Controls.Add(this.label7);
            this.splitLeasing.Panel2.Controls.Add(this.label1);
            this.splitLeasing.Panel2.Controls.Add(this.label8);
            this.splitLeasing.Panel2.Controls.Add(this.label14);
            this.splitLeasing.Panel2.Controls.Add(this.tbDuration);
            this.splitLeasing.Panel2.Controls.Add(this.tbRecoveryValue);
            this.splitLeasing.Panel2.Controls.Add(this.lblTotalExpense);
            this.splitLeasing.Panel2.Controls.Add(this.label5);
            this.splitLeasing.Panel2.Controls.Add(this.tbInterestRate);
            this.splitLeasing.Panel2.Controls.Add(this.tbDeposit);
            this.splitLeasing.Panel2.Controls.Add(this.tbStartValue);
            this.splitLeasing.Panel2.Controls.Add(this.cbDurationMode);
            this.splitLeasing.Panel2.Controls.Add(this.label2);
            this.splitLeasing.Panel2.Controls.Add(this.label4);
            this.splitLeasing.Panel2.Controls.Add(this.cbLeasingRateIntervall);
            this.splitLeasing.Panel2.Controls.Add(this.tbLeasingRate);
            this.splitLeasing.Panel2MinSize = 10;
            this.splitLeasing.Size = new System.Drawing.Size(1067, 547);
            this.splitLeasing.SplitterDistance = 68;
            this.splitLeasing.SplitterWidth = 3;
            this.splitLeasing.TabIndex = 1;
            // 
            // gpRedemptionTable
            // 
            this.gpRedemptionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpRedemptionTable.Controls.Add(this.btnSave);
            this.gpRedemptionTable.Controls.Add(this.tbLeasingName);
            this.gpRedemptionTable.Controls.Add(this.label3);
            this.gpRedemptionTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRedemptionTable.Location = new System.Drawing.Point(633, 8);
            this.gpRedemptionTable.Name = "gpRedemptionTable";
            this.gpRedemptionTable.Size = new System.Drawing.Size(406, 57);
            this.gpRedemptionTable.TabIndex = 52;
            this.gpRedemptionTable.TabStop = false;
            this.gpRedemptionTable.Text = "Möchten sie ihre Ergebnisse speichern?";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(304, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbLeasingName
            // 
            this.tbLeasingName.Location = new System.Drawing.Point(101, 25);
            this.tbLeasingName.Name = "tbLeasingName";
            this.tbLeasingName.Size = new System.Drawing.Size(197, 29);
            this.tbLeasingName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Beschreibung:";
            // 
            // tbnShowAll
            // 
            this.tbnShowAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnShowAll.Location = new System.Drawing.Point(20, 15);
            this.tbnShowAll.Name = "tbnShowAll";
            this.tbnShowAll.Size = new System.Drawing.Size(259, 33);
            this.tbnShowAll.TabIndex = 51;
            this.tbnShowAll.Text = "Gespeicherte Rechner anzeigen";
            this.tbnShowAll.UseVisualStyleBackColor = true;
            this.tbnShowAll.Click += new System.EventHandler(this.tbnShowAll_Click);
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(199, 418);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(49, 28);
            this.lblTotalInterest.TabIndex = 54;
            this.lblTotalInterest.Text = "0,00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 53;
            this.label6.Text = "davon Zinsen: ";
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(520, 271);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(215, 30);
            this.btnShowTable.TabIndex = 10;
            this.btnShowTable.Text = "Tabelle anzeigen";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Visible = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // pnResultSplit
            // 
            this.pnResultSplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnResultSplit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnResultSplit.Location = new System.Drawing.Point(-5, 348);
            this.pnResultSplit.Name = "pnResultSplit";
            this.pnResultSplit.Size = new System.Drawing.Size(1076, 5);
            this.pnResultSplit.TabIndex = 52;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(520, 209);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(215, 46);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Restwert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Anfangswert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Laufzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Leasingrate";
            // 
            // tbStartValue
            // 
            this.tbStartValue.Location = new System.Drawing.Point(195, 26);
            this.tbStartValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStartValue.Name = "tbStartValue";
            this.tbStartValue.Size = new System.Drawing.Size(120, 27);
            this.tbStartValue.TabIndex = 1;
            this.tbStartValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zinssatz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Anzahlung";
            // 
            // tbLeasingRate
            // 
            this.tbLeasingRate.Location = new System.Drawing.Point(195, 146);
            this.tbLeasingRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeasingRate.Name = "tbLeasingRate";
            this.tbLeasingRate.Size = new System.Drawing.Size(120, 27);
            this.tbLeasingRate.TabIndex = 4;
            this.tbLeasingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(320, 109);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(21, 20);
            this.lblPercent.TabIndex = 55;
            this.lblPercent.Text = "%";
            // 
            // LeasingCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLeasing);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeasingCalculatorView";
            this.Size = new System.Drawing.Size(1067, 547);
            this.splitLeasing.Panel1.ResumeLayout(false);
            this.splitLeasing.Panel2.ResumeLayout(false);
            this.splitLeasing.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeasing)).EndInit();
            this.splitLeasing.ResumeLayout(false);
            this.gpRedemptionTable.ResumeLayout(false);
            this.gpRedemptionTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbLeasingRateIntervall;
        private System.Windows.Forms.ComboBox cbDurationMode;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.TextBox tbRecoveryValue;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.SplitContainer splitLeasing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLeasingRate;
        private System.Windows.Forms.TextBox tbStartValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Panel pnResultSplit;
        private System.Windows.Forms.Button tbnShowAll;
        private System.Windows.Forms.GroupBox gpRedemptionTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbLeasingName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPercent;
    }
}
