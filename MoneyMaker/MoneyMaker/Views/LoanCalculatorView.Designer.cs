namespace MoneyMaker.Views
{
    partial class LoanCalculatorView
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
            this.splitLoan = new System.Windows.Forms.SplitContainer();
            this.gpRedemptionTable = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLoanName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbnShowAll = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.pnResultSplit = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalExpense = new System.Windows.Forms.Label();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbDuration = new System.Windows.Forms.RadioButton();
            this.rbRepaymentMode = new System.Windows.Forms.RadioButton();
            this.rbLoanAmount = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbRepaymentRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLoanAmount = new System.Windows.Forms.TextBox();
            this.cbDurationMode = new System.Windows.Forms.ComboBox();
            this.cbRepaymentInterval = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitLoan)).BeginInit();
            this.splitLoan.Panel1.SuspendLayout();
            this.splitLoan.Panel2.SuspendLayout();
            this.splitLoan.SuspendLayout();
            this.gpRedemptionTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitLoan
            // 
            this.splitLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLoan.Location = new System.Drawing.Point(0, 0);
            this.splitLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitLoan.Name = "splitLoan";
            this.splitLoan.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLoan.Panel1
            // 
            this.splitLoan.Panel1.AccessibleName = "";
            this.splitLoan.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitLoan.Panel1.Controls.Add(this.gpRedemptionTable);
            this.splitLoan.Panel1.Controls.Add(this.tbnShowAll);
            this.splitLoan.Panel1MinSize = 70;
            // 
            // splitLoan.Panel2
            // 
            this.splitLoan.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitLoan.Panel2.Controls.Add(this.lblPercent);
            this.splitLoan.Panel2.Controls.Add(this.pnResultSplit);
            this.splitLoan.Panel2.Controls.Add(this.label12);
            this.splitLoan.Panel2.Controls.Add(this.label1);
            this.splitLoan.Panel2.Controls.Add(this.lblFees);
            this.splitLoan.Panel2.Controls.Add(this.label2);
            this.splitLoan.Panel2.Controls.Add(this.lbltotalExpense);
            this.splitLoan.Panel2.Controls.Add(this.tbInterestRate);
            this.splitLoan.Panel2.Controls.Add(this.groupBox1);
            this.splitLoan.Panel2.Controls.Add(this.label14);
            this.splitLoan.Panel2.Controls.Add(this.tbDuration);
            this.splitLoan.Panel2.Controls.Add(this.tbRepaymentRate);
            this.splitLoan.Panel2.Controls.Add(this.label4);
            this.splitLoan.Panel2.Controls.Add(this.label5);
            this.splitLoan.Panel2.Controls.Add(this.label8);
            this.splitLoan.Panel2.Controls.Add(this.tbLoanAmount);
            this.splitLoan.Panel2.Controls.Add(this.cbDurationMode);
            this.splitLoan.Panel2.Controls.Add(this.cbRepaymentInterval);
            this.splitLoan.Panel2MinSize = 0;
            this.splitLoan.Size = new System.Drawing.Size(811, 421);
            this.splitLoan.SplitterDistance = 70;
            this.splitLoan.SplitterWidth = 3;
            this.splitLoan.TabIndex = 0;
            // 
            // gpRedemptionTable
            // 
            this.gpRedemptionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpRedemptionTable.Controls.Add(this.btnSave);
            this.gpRedemptionTable.Controls.Add(this.tbLoanName);
            this.gpRedemptionTable.Controls.Add(this.label11);
            this.gpRedemptionTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRedemptionTable.Location = new System.Drawing.Point(398, 7);
            this.gpRedemptionTable.Name = "gpRedemptionTable";
            this.gpRedemptionTable.Size = new System.Drawing.Size(406, 57);
            this.gpRedemptionTable.TabIndex = 51;
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
            // tbLoanName
            // 
            this.tbLoanName.Location = new System.Drawing.Point(101, 25);
            this.tbLoanName.Name = "tbLoanName";
            this.tbLoanName.Size = new System.Drawing.Size(197, 33);
            this.tbLoanName.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Beschreibung:";
            // 
            // tbnShowAll
            // 
            this.tbnShowAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnShowAll.Location = new System.Drawing.Point(19, 16);
            this.tbnShowAll.Name = "tbnShowAll";
            this.tbnShowAll.Size = new System.Drawing.Size(259, 33);
            this.tbnShowAll.TabIndex = 50;
            this.tbnShowAll.Text = "Gespeicherte Kredite anzeigen";
            this.tbnShowAll.UseVisualStyleBackColor = true;
            this.tbnShowAll.Click += new System.EventHandler(this.tbnShowAll_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(289, 101);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(27, 25);
            this.lblPercent.TabIndex = 52;
            this.lblPercent.Text = "%";
            // 
            // pnResultSplit
            // 
            this.pnResultSplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnResultSplit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnResultSplit.Location = new System.Drawing.Point(0, 270);
            this.pnResultSplit.Name = "pnResultSplit";
            this.pnResultSplit.Size = new System.Drawing.Size(811, 4);
            this.pnResultSplit.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 38;
            this.label12.Text = "Gesamtaufwand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Kreditbetrag";
            // 
            // lblFees
            // 
            this.lblFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(312, 318);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(59, 32);
            this.lblFees.TabIndex = 34;
            this.lblFees.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Zinssatz";
            // 
            // lbltotalExpense
            // 
            this.lbltotalExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalExpense.AutoSize = true;
            this.lbltotalExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalExpense.Location = new System.Drawing.Point(312, 283);
            this.lbltotalExpense.Name = "lbltotalExpense";
            this.lbltotalExpense.Size = new System.Drawing.Size(59, 32);
            this.lbltotalExpense.TabIndex = 39;
            this.lbltotalExpense.Text = "0,00";
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(166, 98);
            this.tbInterestRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(120, 31);
            this.tbInterestRate.TabIndex = 2;
            this.tbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShowTable);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.rbDuration);
            this.groupBox1.Controls.Add(this.rbRepaymentMode);
            this.groupBox1.Controls.Add(this.rbLoanAmount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(550, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(254, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Was berechnen?";
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.Location = new System.Drawing.Point(5, 187);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(242, 32);
            this.btnShowTable.TabIndex = 6;
            this.btnShowTable.Text = "Tabelle der Ergebnisse";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Visible = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(5, 138);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(242, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbDuration
            // 
            this.rbDuration.AutoSize = true;
            this.rbDuration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDuration.Location = new System.Drawing.Point(20, 99);
            this.rbDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDuration.Name = "rbDuration";
            this.rbDuration.Size = new System.Drawing.Size(112, 30);
            this.rbDuration.TabIndex = 71;
            this.rbDuration.Text = "Laufzeit";
            this.rbDuration.UseVisualStyleBackColor = true;
            this.rbDuration.CheckedChanged += new System.EventHandler(this.rbDuration_CheckedChanged);
            // 
            // rbRepaymentMode
            // 
            this.rbRepaymentMode.AutoSize = true;
            this.rbRepaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRepaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRepaymentMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRepaymentMode.Location = new System.Drawing.Point(20, 64);
            this.rbRepaymentMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRepaymentMode.Name = "rbRepaymentMode";
            this.rbRepaymentMode.Size = new System.Drawing.Size(209, 30);
            this.rbRepaymentMode.TabIndex = 72;
            this.rbRepaymentMode.Text = "Rückzahlungsrate";
            this.rbRepaymentMode.UseVisualStyleBackColor = true;
            this.rbRepaymentMode.CheckedChanged += new System.EventHandler(this.rbRepaymentMode_CheckedChanged);
            // 
            // rbLoanAmount
            // 
            this.rbLoanAmount.AutoSize = true;
            this.rbLoanAmount.Checked = true;
            this.rbLoanAmount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanAmount.Location = new System.Drawing.Point(20, 29);
            this.rbLoanAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLoanAmount.Name = "rbLoanAmount";
            this.rbLoanAmount.Size = new System.Drawing.Size(153, 30);
            this.rbLoanAmount.TabIndex = 73;
            this.rbLoanAmount.TabStop = true;
            this.rbLoanAmount.Text = "Kreditbetrag";
            this.rbLoanAmount.UseVisualStyleBackColor = true;
            this.rbLoanAmount.CheckedChanged += new System.EventHandler(this.rbLoanAmount_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(338, 32);
            this.label14.TabIndex = 32;
            this.label14.Text = "Zinsen und Gebühren gesamt:";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(166, 187);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(120, 31);
            this.tbDuration.TabIndex = 5;
            this.tbDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // tbRepaymentRate
            // 
            this.tbRepaymentRate.Location = new System.Drawing.Point(166, 144);
            this.tbRepaymentRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRepaymentRate.Name = "tbRepaymentRate";
            this.tbRepaymentRate.Size = new System.Drawing.Size(120, 31);
            this.tbRepaymentRate.TabIndex = 3;
            this.tbRepaymentRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Rückzahlungsrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Laufzeit";
            // 
            // tbLoanAmount
            // 
            this.tbLoanAmount.Location = new System.Drawing.Point(166, 12);
            this.tbLoanAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoanAmount.Name = "tbLoanAmount";
            this.tbLoanAmount.ReadOnly = true;
            this.tbLoanAmount.Size = new System.Drawing.Size(120, 31);
            this.tbLoanAmount.TabIndex = 1;
            this.tbLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // cbDurationMode
            // 
            this.cbDurationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurationMode.FormattingEnabled = true;
            this.cbDurationMode.Items.AddRange(new object[] {
            "Monate",
            "Jahre"});
            this.cbDurationMode.Location = new System.Drawing.Point(293, 187);
            this.cbDurationMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDurationMode.Name = "cbDurationMode";
            this.cbDurationMode.Size = new System.Drawing.Size(125, 33);
            this.cbDurationMode.TabIndex = 6;
            // 
            // cbRepaymentInterval
            // 
            this.cbRepaymentInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRepaymentInterval.FormattingEnabled = true;
            this.cbRepaymentInterval.Items.AddRange(new object[] {
            "monatlich",
            "vierteljährlich",
            "halbjährlich",
            "jährlich"});
            this.cbRepaymentInterval.Location = new System.Drawing.Point(293, 144);
            this.cbRepaymentInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRepaymentInterval.Name = "cbRepaymentInterval";
            this.cbRepaymentInterval.Size = new System.Drawing.Size(125, 33);
            this.cbRepaymentInterval.TabIndex = 4;
            // 
            // LoanCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLoan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanCalculatorView";
            this.Size = new System.Drawing.Size(811, 421);
            this.splitLoan.Panel1.ResumeLayout(false);
            this.splitLoan.Panel2.ResumeLayout(false);
            this.splitLoan.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLoan)).EndInit();
            this.splitLoan.ResumeLayout(false);
            this.gpRedemptionTable.ResumeLayout(false);
            this.gpRedemptionTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitLoan;
        private System.Windows.Forms.ComboBox cbRepaymentInterval;
        private System.Windows.Forms.ComboBox cbDurationMode;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.TextBox tbRepaymentRate;
        private System.Windows.Forms.TextBox tbLoanAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbDuration;
        private System.Windows.Forms.RadioButton rbRepaymentMode;
        private System.Windows.Forms.RadioButton rbLoanAmount;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbltotalExpense;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button tbnShowAll;
        private System.Windows.Forms.Panel pnResultSplit;
        private System.Windows.Forms.GroupBox gpRedemptionTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbLoanName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPercent;
    }
}
