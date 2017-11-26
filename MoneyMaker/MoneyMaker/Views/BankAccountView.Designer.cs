namespace MoneyMaker.Views
{
    partial class BankAccountView
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
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.btnUpdateDepot = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lblCurrency2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.lblDepotBalance = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblDepotValue = new System.Windows.Forms.Label();
            this.splitListChart = new System.Windows.Forms.SplitContainer();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOutcome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.dpCreated = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxTransactionType = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.bankTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitListChart)).BeginInit();
            this.splitListChart.Panel1.SuspendLayout();
            this.splitListChart.Panel2.SuspendLayout();
            this.splitListChart.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            this.splitContainerMain.Panel1MinSize = 400;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelDetails);
            this.splitContainerMain.Panel2MinSize = 300;
            this.splitContainerMain.Size = new System.Drawing.Size(927, 493);
            this.splitContainerMain.SplitterDistance = 623;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 1;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerLeft.Panel1.Controls.Add(this.btnUpdateDepot);
            this.splitContainerLeft.Panel1.Controls.Add(this.btnAddTransaction);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblCurrency2);
            this.splitContainerLeft.Panel1.Controls.Add(this.splitter1);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblCurrency1);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblDepotBalance);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblBankBalance);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblAccountBalance);
            this.splitContainerLeft.Panel1.Controls.Add(this.lblDepotValue);
            this.splitContainerLeft.Panel1MinSize = 100;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.splitListChart);
            this.splitContainerLeft.Size = new System.Drawing.Size(623, 493);
            this.splitContainerLeft.SplitterDistance = 100;
            this.splitContainerLeft.SplitterWidth = 3;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // btnUpdateDepot
            // 
            this.btnUpdateDepot.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepot.Location = new System.Drawing.Point(251, 56);
            this.btnUpdateDepot.Name = "btnUpdateDepot";
            this.btnUpdateDepot.Size = new System.Drawing.Size(136, 28);
            this.btnUpdateDepot.TabIndex = 34;
            this.btnUpdateDepot.Text = "Depot aktualisieren";
            this.bankTooltip.SetToolTip(this.btnUpdateDepot, "Berechnet den aktuellsten Depotwert. Dabei werden Wertpapierdaten abgefragt");
            this.btnUpdateDepot.UseVisualStyleBackColor = true;
            this.btnUpdateDepot.Click += new System.EventHandler(this.btnUpdateDepot_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.Location = new System.Drawing.Point(425, 8);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(191, 27);
            this.btnAddTransaction.TabIndex = 33;
            this.btnAddTransaction.Text = "Neue Transaktion erfassen";
            this.bankTooltip.SetToolTip(this.btnAddTransaction, "Öffnet im rechten Bereich ein Formular, wo Sie eine neue Transaktion einpflegen k" +
        "önnen");
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // lblCurrency2
            // 
            this.lblCurrency2.AutoSize = true;
            this.lblCurrency2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency2.Location = new System.Drawing.Point(223, 58);
            this.lblCurrency2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency2.Name = "lblCurrency2";
            this.lblCurrency2.Size = new System.Drawing.Size(18, 20);
            this.lblCurrency2.TabIndex = 31;
            this.lblCurrency2.Text = "€";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 100);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblCurrency1
            // 
            this.lblCurrency1.AutoSize = true;
            this.lblCurrency1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency1.Location = new System.Drawing.Point(223, 17);
            this.lblCurrency1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency1.Name = "lblCurrency1";
            this.lblCurrency1.Size = new System.Drawing.Size(18, 20);
            this.lblCurrency1.TabIndex = 30;
            this.lblCurrency1.Text = "€";
            // 
            // lblDepotBalance
            // 
            this.lblDepotBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepotBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepotBalance.Location = new System.Drawing.Point(117, 52);
            this.lblDepotBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepotBalance.Name = "lblDepotBalance";
            this.lblDepotBalance.Size = new System.Drawing.Size(102, 34);
            this.lblDepotBalance.TabIndex = 3;
            this.lblDepotBalance.Text = "0,00";
            this.lblDepotBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bankTooltip.SetToolTip(this.lblDepotBalance, "Der aktuell berechnete Depotwert");
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBankBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalance.Location = new System.Drawing.Point(14, 16);
            this.lblBankBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(83, 19);
            this.lblBankBalance.TabIndex = 0;
            this.lblBankBalance.Text = "Kontostand:";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(117, 10);
            this.lblAccountBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(102, 34);
            this.lblAccountBalance.TabIndex = 2;
            this.lblAccountBalance.Text = "0,00";
            this.lblAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bankTooltip.SetToolTip(this.lblAccountBalance, "Der aktuelle Stand des Verrechnungskontos");
            // 
            // lblDepotValue
            // 
            this.lblDepotValue.AutoSize = true;
            this.lblDepotValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepotValue.Location = new System.Drawing.Point(17, 59);
            this.lblDepotValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepotValue.Name = "lblDepotValue";
            this.lblDepotValue.Size = new System.Drawing.Size(65, 15);
            this.lblDepotValue.TabIndex = 1;
            this.lblDepotValue.Text = "Depotwert:";
            // 
            // splitListChart
            // 
            this.splitListChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitListChart.Location = new System.Drawing.Point(0, 0);
            this.splitListChart.Name = "splitListChart";
            this.splitListChart.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitListChart.Panel1
            // 
            this.splitListChart.Panel1.Controls.Add(this.lvTransactions);
            this.splitListChart.Panel1.Controls.Add(this.panelToolbar);
            // 
            // splitListChart.Panel2
            // 
            this.splitListChart.Panel2.Controls.Add(this.chart);
            this.splitListChart.Size = new System.Drawing.Size(623, 390);
            this.splitListChart.SplitterDistance = 195;
            this.splitListChart.TabIndex = 7;
            // 
            // lvTransactions
            // 
            this.lvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colDesc,
            this.colIncome,
            this.colOutcome,
            this.colType});
            this.lvTransactions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTransactions.FullRowSelect = true;
            this.lvTransactions.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12});
            this.lvTransactions.Location = new System.Drawing.Point(0, 44);
            this.lvTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.lvTransactions.MultiSelect = false;
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.Size = new System.Drawing.Size(623, 149);
            this.lvTransactions.TabIndex = 1;
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Datum";
            this.colDate.Width = 156;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Beschreibung";
            this.colDesc.Width = 206;
            // 
            // colIncome
            // 
            this.colIncome.Text = "Zugang";
            this.colIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colIncome.Width = 86;
            // 
            // colOutcome
            // 
            this.colOutcome.Text = "Abgang";
            this.colOutcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colOutcome.Width = 93;
            // 
            // colType
            // 
            this.colType.Text = "Typ";
            this.colType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToolbar.BackColor = System.Drawing.SystemColors.Window;
            this.panelToolbar.Controls.Add(this.btnShowChart);
            this.panelToolbar.Controls.Add(this.endDate);
            this.panelToolbar.Controls.Add(this.lblTo);
            this.panelToolbar.Controls.Add(this.startDate);
            this.panelToolbar.Controls.Add(this.btnUpdate);
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(623, 44);
            this.panelToolbar.TabIndex = 6;
            // 
            // btnShowChart
            // 
            this.btnShowChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowChart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowChart.Location = new System.Drawing.Point(384, 6);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(127, 25);
            this.btnShowChart.TabIndex = 33;
            this.btnShowChart.Text = "Chart ausblenden";
            this.bankTooltip.SetToolTip(this.btnShowChart, "Blendet den Chart im unteren Bereich aus");
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(143, 8);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(100, 23);
            this.endDate.TabIndex = 4;
            this.bankTooltip.SetToolTip(this.endDate, "Enddatum");
            this.endDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(114, 12);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 15);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "bis";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(8, 8);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(101, 23);
            this.startDate.TabIndex = 3;
            this.bankTooltip.SetToolTip(this.startDate, "Startdatum");
            this.startDate.Value = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(515, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 25);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Aktualisieren";
            this.bankTooltip.SetToolTip(this.btnUpdate, "Aktualisiert die Liste");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chart
            // 
            chartArea12.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea12.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea12.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea12.BorderColor = System.Drawing.Color.Gray;
            chartArea12.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea12);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Alignment = System.Drawing.StringAlignment.Center;
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Name = "Legend1";
            this.chart.Legends.Add(legend12);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series23.BorderWidth = 5;
            series23.ChartArea = "ChartArea";
            series23.Color = System.Drawing.Color.ForestGreen;
            series23.Legend = "Legend1";
            series23.Name = "Zugang";
            series23.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series24.BorderWidth = 5;
            series24.ChartArea = "ChartArea";
            series24.Color = System.Drawing.Color.Tomato;
            series24.Legend = "Legend1";
            series24.Name = "Abgang";
            series24.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart.Series.Add(series23);
            this.chart.Series.Add(series24);
            this.chart.Size = new System.Drawing.Size(623, 191);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.SystemColors.Control;
            this.panelDetails.Controls.Add(this.gbDetails);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(301, 493);
            this.panelDetails.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.btnSaveTransaction);
            this.gbDetails.Controls.Add(this.dpCreated);
            this.gbDetails.Controls.Add(this.lblAmount);
            this.gbDetails.Controls.Add(this.lblDescription);
            this.gbDetails.Controls.Add(this.tbAmount);
            this.gbDetails.Controls.Add(this.btnClose);
            this.gbDetails.Controls.Add(this.cbxTransactionType);
            this.gbDetails.Controls.Add(this.tbDescription);
            this.gbDetails.Location = new System.Drawing.Point(14, 16);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(273, 312);
            this.gbDetails.TabIndex = 8;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTransaction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveTransaction.Location = new System.Drawing.Point(12, 268);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(129, 29);
            this.btnSaveTransaction.TabIndex = 4;
            this.btnSaveTransaction.Text = "Speichern";
            this.btnSaveTransaction.UseVisualStyleBackColor = false;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // dpCreated
            // 
            this.dpCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpCreated.Location = new System.Drawing.Point(12, 182);
            this.dpCreated.Name = "dpCreated";
            this.dpCreated.Size = new System.Drawing.Size(242, 23);
            this.dpCreated.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 225);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(48, 15);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Summe";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 64);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 15);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Beschreibung";
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(70, 222);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(184, 23);
            this.tbAmount.TabIndex = 3;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(150, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.bankTooltip.SetToolTip(this.btnClose, "Das Dialogformular schließen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxTransactionType
            // 
            this.cbxTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTransactionType.BackColor = System.Drawing.SystemColors.Window;
            this.cbxTransactionType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransactionType.FormattingEnabled = true;
            this.cbxTransactionType.Location = new System.Drawing.Point(12, 32);
            this.cbxTransactionType.Name = "cbxTransactionType";
            this.cbxTransactionType.Size = new System.Drawing.Size(242, 23);
            this.cbxTransactionType.TabIndex = 0;
            this.bankTooltip.SetToolTip(this.cbxTransactionType, "Transaktionstyp: Einzahlung auf das Konto oder Auszahlung");
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(12, 82);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(242, 81);
            this.tbDescription.TabIndex = 1;
            this.bankTooltip.SetToolTip(this.tbDescription, "Hier können Sie optional eine Beschreibung eingeben");
            // 
            // bankTooltip
            // 
            this.bankTooltip.AutoPopDelay = 5000;
            this.bankTooltip.InitialDelay = 200;
            this.bankTooltip.ReshowDelay = 100;
            // 
            // BankAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BankAccountView";
            this.Size = new System.Drawing.Size(927, 493);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel1.PerformLayout();
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitListChart.Panel1.ResumeLayout(false);
            this.splitListChart.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitListChart)).EndInit();
            this.splitListChart.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvTransactions;
        private System.Windows.Forms.Label lblDepotValue;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Label lblDepotBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblCurrency2;
        private System.Windows.Forms.Label lblCurrency1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.DateTimePicker dpCreated;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbxTransactionType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colIncome;
        private System.Windows.Forms.ColumnHeader colOutcome;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnUpdateDepot;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.SplitContainer splitListChart;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ToolTip bankTooltip;
    }
}
