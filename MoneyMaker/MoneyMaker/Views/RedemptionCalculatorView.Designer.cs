namespace MoneyMaker.Views
{
    partial class RedemptionCalculatorView
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
            this.rbRedemptionDuration = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.splitRedemption = new System.Windows.Forms.SplitContainer();
            this.gpRedemptionTable = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.pnResultSplit = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRemainingDebt = new System.Windows.Forms.RadioButton();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.rbRedemption = new System.Windows.Forms.RadioButton();
            this.rbLoanAmount = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRedemptionDurationMode = new System.Windows.Forms.ComboBox();
            this.tbRedemptionDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRedemptionRateIntervall = new System.Windows.Forms.ComboBox();
            this.cbInterestRateIntervall = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbRemainingDebt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRedemptionRate = new System.Windows.Forms.TextBox();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLoanAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitRedemption)).BeginInit();
            this.splitRedemption.Panel1.SuspendLayout();
            this.splitRedemption.Panel2.SuspendLayout();
            this.splitRedemption.SuspendLayout();
            this.gpRedemptionTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRedemptionDuration
            // 
            this.rbRedemptionDuration.AutoSize = true;
            this.rbRedemptionDuration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRedemptionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRedemptionDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRedemptionDuration.Location = new System.Drawing.Point(10, 120);
            this.rbRedemptionDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRedemptionDuration.Name = "rbRedemptionDuration";
            this.rbRedemptionDuration.Size = new System.Drawing.Size(173, 30);
            this.rbRedemptionDuration.TabIndex = 2;
            this.rbRedemptionDuration.TabStop = true;
            this.rbRedemptionDuration.Text = "Tilgungsdauer";
            this.rbRedemptionDuration.UseVisualStyleBackColor = true;
            this.rbRedemptionDuration.CheckedChanged += new System.EventHandler(this.rbRedemptionDuration_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(6, 235);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(229, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // splitRedemption
            // 
            this.splitRedemption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRedemption.Location = new System.Drawing.Point(0, 0);
            this.splitRedemption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitRedemption.Name = "splitRedemption";
            this.splitRedemption.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRedemption.Panel1
            // 
            this.splitRedemption.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitRedemption.Panel1.Controls.Add(this.gpRedemptionTable);
            this.splitRedemption.Panel1.Controls.Add(this.btnShowAll);
            this.splitRedemption.Panel1MinSize = 80;
            // 
            // splitRedemption.Panel2
            // 
            this.splitRedemption.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitRedemption.Panel2.Controls.Add(this.lblTotalExpense);
            this.splitRedemption.Panel2.Controls.Add(this.pnResultSplit);
            this.splitRedemption.Panel2.Controls.Add(this.label20);
            this.splitRedemption.Panel2.Controls.Add(this.groupBox1);
            this.splitRedemption.Panel2.Controls.Add(this.label14);
            this.splitRedemption.Panel2.Controls.Add(this.label1);
            this.splitRedemption.Panel2.Controls.Add(this.lblTotalInterest);
            this.splitRedemption.Panel2.Controls.Add(this.label6);
            this.splitRedemption.Panel2.Controls.Add(this.cbRedemptionDurationMode);
            this.splitRedemption.Panel2.Controls.Add(this.tbRedemptionDuration);
            this.splitRedemption.Panel2.Controls.Add(this.label2);
            this.splitRedemption.Panel2.Controls.Add(this.label8);
            this.splitRedemption.Panel2.Controls.Add(this.cbRedemptionRateIntervall);
            this.splitRedemption.Panel2.Controls.Add(this.cbInterestRateIntervall);
            this.splitRedemption.Panel2.Controls.Add(this.label21);
            this.splitRedemption.Panel2.Controls.Add(this.tbRemainingDebt);
            this.splitRedemption.Panel2.Controls.Add(this.label5);
            this.splitRedemption.Panel2.Controls.Add(this.tbRedemptionRate);
            this.splitRedemption.Panel2.Controls.Add(this.tbInterestRate);
            this.splitRedemption.Panel2.Controls.Add(this.label7);
            this.splitRedemption.Panel2.Controls.Add(this.tbLoanAmount);
            this.splitRedemption.Panel2MinSize = 410;
            this.splitRedemption.Size = new System.Drawing.Size(916, 605);
            this.splitRedemption.SplitterDistance = 80;
            this.splitRedemption.SplitterWidth = 3;
            this.splitRedemption.TabIndex = 2;
            // 
            // gpRedemptionTable
            // 
            this.gpRedemptionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpRedemptionTable.Controls.Add(this.btnSave);
            this.gpRedemptionTable.Controls.Add(this.tbTitle);
            this.gpRedemptionTable.Controls.Add(this.label4);
            this.gpRedemptionTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRedemptionTable.Location = new System.Drawing.Point(494, 9);
            this.gpRedemptionTable.Name = "gpRedemptionTable";
            this.gpRedemptionTable.Size = new System.Drawing.Size(406, 57);
            this.gpRedemptionTable.TabIndex = 50;
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
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(101, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(197, 33);
            this.tbTitle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Beschreibung:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(18, 9);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(319, 32);
            this.btnShowAll.TabIndex = 48;
            this.btnShowAll.Text = "Gespeicherte Tilgungskredite anzeigen";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.Location = new System.Drawing.Point(402, 482);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(59, 32);
            this.lblTotalExpense.TabIndex = 49;
            this.lblTotalExpense.Text = "0,00";
            // 
            // pnResultSplit
            // 
            this.pnResultSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnResultSplit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnResultSplit.Location = new System.Drawing.Point(0, 444);
            this.pnResultSplit.Name = "pnResultSplit";
            this.pnResultSplit.Size = new System.Drawing.Size(916, 3);
            this.pnResultSplit.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 450);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(345, 32);
            this.label20.TabIndex = 33;
            this.label20.Text = "Zinsen und Gebühren gesamt :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.rbRemainingDebt);
            this.groupBox1.Controls.Add(this.btnShowTable);
            this.groupBox1.Controls.Add(this.rbRedemptionDuration);
            this.groupBox1.Controls.Add(this.rbRedemption);
            this.groupBox1.Controls.Add(this.rbLoanAmount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(660, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 318);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Was berechnen?";
            // 
            // rbRemainingDebt
            // 
            this.rbRemainingDebt.AutoSize = true;
            this.rbRemainingDebt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRemainingDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemainingDebt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRemainingDebt.Location = new System.Drawing.Point(10, 163);
            this.rbRemainingDebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRemainingDebt.Name = "rbRemainingDebt";
            this.rbRemainingDebt.Size = new System.Drawing.Size(143, 30);
            this.rbRemainingDebt.TabIndex = 3;
            this.rbRemainingDebt.TabStop = true;
            this.rbRemainingDebt.Text = "Restschuld";
            this.rbRemainingDebt.UseVisualStyleBackColor = true;
            this.rbRemainingDebt.CheckedChanged += new System.EventHandler(this.rbRemainingDebt_CheckedChanged);
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.Location = new System.Drawing.Point(6, 278);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(228, 35);
            this.btnShowTable.TabIndex = 6;
            this.btnShowTable.Text = "Tabelle der Ergebnisse";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Visible = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // rbRedemption
            // 
            this.rbRedemption.AutoSize = true;
            this.rbRedemption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRedemption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRedemption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRedemption.Location = new System.Drawing.Point(10, 76);
            this.rbRedemption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRedemption.Name = "rbRedemption";
            this.rbRedemption.Size = new System.Drawing.Size(155, 30);
            this.rbRedemption.TabIndex = 1;
            this.rbRedemption.TabStop = true;
            this.rbRedemption.Text = "Tilgungsrate";
            this.rbRedemption.UseVisualStyleBackColor = true;
            this.rbRedemption.CheckedChanged += new System.EventHandler(this.rbRedemption_CheckedChanged);
            // 
            // rbLoanAmount
            // 
            this.rbLoanAmount.AutoSize = true;
            this.rbLoanAmount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoanAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLoanAmount.Location = new System.Drawing.Point(10, 31);
            this.rbLoanAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLoanAmount.Name = "rbLoanAmount";
            this.rbLoanAmount.Size = new System.Drawing.Size(195, 30);
            this.rbLoanAmount.TabIndex = 0;
            this.rbLoanAmount.TabStop = true;
            this.rbLoanAmount.Text = "Darlehensbetrag";
            this.rbLoanAmount.UseVisualStyleBackColor = true;
            this.rbLoanAmount.CheckedChanged += new System.EventHandler(this.rbLoanAmount_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 32);
            this.label14.TabIndex = 32;
            this.label14.Text = "Gesamtaufwand :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Darlehensbetrag";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(402, 450);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(59, 32);
            this.lblTotalInterest.TabIndex = 35;
            this.lblTotalInterest.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tilgungsrate";
            // 
            // cbRedemptionDurationMode
            // 
            this.cbRedemptionDurationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRedemptionDurationMode.FormattingEnabled = true;
            this.cbRedemptionDurationMode.Items.AddRange(new object[] {
            "Monate",
            "Jahre"});
            this.cbRedemptionDurationMode.Location = new System.Drawing.Point(333, 258);
            this.cbRedemptionDurationMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRedemptionDurationMode.Name = "cbRedemptionDurationMode";
            this.cbRedemptionDurationMode.Size = new System.Drawing.Size(128, 33);
            this.cbRedemptionDurationMode.TabIndex = 7;
            // 
            // tbRedemptionDuration
            // 
            this.tbRedemptionDuration.Location = new System.Drawing.Point(201, 259);
            this.tbRedemptionDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRedemptionDuration.Name = "tbRedemptionDuration";
            this.tbRedemptionDuration.Size = new System.Drawing.Size(127, 31);
            this.tbRedemptionDuration.TabIndex = 6;
            this.tbRedemptionDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Zinsrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tilgungsintervall";
            // 
            // cbRedemptionRateIntervall
            // 
            this.cbRedemptionRateIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRedemptionRateIntervall.FormattingEnabled = true;
            this.cbRedemptionRateIntervall.Items.AddRange(new object[] {
            "monatlich",
            "vierteljährlich",
            "halbjährlich",
            "jährlich"});
            this.cbRedemptionRateIntervall.Location = new System.Drawing.Point(201, 209);
            this.cbRedemptionRateIntervall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRedemptionRateIntervall.Name = "cbRedemptionRateIntervall";
            this.cbRedemptionRateIntervall.Size = new System.Drawing.Size(125, 33);
            this.cbRedemptionRateIntervall.TabIndex = 5;
            // 
            // cbInterestRateIntervall
            // 
            this.cbInterestRateIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterestRateIntervall.FormattingEnabled = true;
            this.cbInterestRateIntervall.Items.AddRange(new object[] {
            "monatlich",
            "vierteljährlich",
            "halbjährlich",
            "jährlich"});
            this.cbInterestRateIntervall.Location = new System.Drawing.Point(201, 111);
            this.cbInterestRateIntervall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInterestRateIntervall.Name = "cbInterestRateIntervall";
            this.cbInterestRateIntervall.Size = new System.Drawing.Size(125, 33);
            this.cbInterestRateIntervall.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 25);
            this.label21.TabIndex = 20;
            this.label21.Text = "Restschuld";
            // 
            // tbRemainingDebt
            // 
            this.tbRemainingDebt.Location = new System.Drawing.Point(201, 308);
            this.tbRemainingDebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRemainingDebt.Name = "tbRemainingDebt";
            this.tbRemainingDebt.Size = new System.Drawing.Size(127, 31);
            this.tbRemainingDebt.TabIndex = 8;
            this.tbRemainingDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zinszahlungsintervall";
            // 
            // tbRedemptionRate
            // 
            this.tbRedemptionRate.Location = new System.Drawing.Point(201, 160);
            this.tbRedemptionRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRedemptionRate.Name = "tbRedemptionRate";
            this.tbRedemptionRate.Size = new System.Drawing.Size(125, 31);
            this.tbRedemptionRate.TabIndex = 4;
            this.tbRedemptionRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(200, 61);
            this.tbInterestRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(125, 31);
            this.tbInterestRate.TabIndex = 2;
            this.tbInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tilgungsdauer";
            // 
            // tbLoanAmount
            // 
            this.tbLoanAmount.Location = new System.Drawing.Point(201, 12);
            this.tbLoanAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoanAmount.Name = "tbLoanAmount";
            this.tbLoanAmount.Size = new System.Drawing.Size(125, 31);
            this.tbLoanAmount.TabIndex = 1;
            this.tbLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCheckDigital);
            // 
            // RedemptionCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitRedemption);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RedemptionCalculatorView";
            this.Size = new System.Drawing.Size(916, 605);
            this.splitRedemption.Panel1.ResumeLayout(false);
            this.splitRedemption.Panel2.ResumeLayout(false);
            this.splitRedemption.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRedemption)).EndInit();
            this.splitRedemption.ResumeLayout(false);
            this.gpRedemptionTable.ResumeLayout(false);
            this.gpRedemptionTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRedemptionDuration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.SplitContainer splitRedemption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInterestRateIntervall;
        private System.Windows.Forms.ComboBox cbRedemptionDurationMode;
        private System.Windows.Forms.TextBox tbRedemptionDuration;
        private System.Windows.Forms.TextBox tbRemainingDebt;
        private System.Windows.Forms.TextBox tbLoanAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRemainingDebt;
        private System.Windows.Forms.RadioButton rbRedemption;
        private System.Windows.Forms.RadioButton rbLoanAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRedemptionRate;
        private System.Windows.Forms.ComboBox cbRedemptionRateIntervall;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gpRedemptionTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel pnResultSplit;
        private System.Windows.Forms.Label lblTotalExpense;
    }
}
