namespace MoneyMaker.Views
{
    partial class WatchlistView
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
            this.btnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdatePrices = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.nupStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnGetStock = new System.Windows.Forms.Button();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.btnDrawLineToggle = new System.Windows.Forms.Button();
            this.dpEnddate = new System.Windows.Forms.DateTimePicker();
            this.dpStartdate = new System.Windows.Forms.DateTimePicker();
            this.nupPricePurchase = new System.Windows.Forms.NumericUpDown();
            this.btnSaveWatchlist = new System.Windows.Forms.Button();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbxDataProvider = new System.Windows.Forms.ComboBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftTop = new System.Windows.Forms.SplitContainer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.stockSearchView = new MoneyMaker.Views.StockSearchView();
            this.lvWatchlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDatetimePicker = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.lblLoadingInfo = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.gbPortfolio = new System.Windows.Forms.GroupBox();
            this.lblCreatedInput = new System.Windows.Forms.Label();
            this.lblCreatedInfo = new System.Windows.Forms.Label();
            this.lblQuantityInfo = new System.Windows.Forms.Label();
            this.lblPricePurchaseInfo = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.lblVolumeInput = new System.Windows.Forms.Label();
            this.lblChangePercentageInput = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblCloseInput = new System.Windows.Forms.Label();
            this.lblOpenInput = new System.Windows.Forms.Label();
            this.lblDataProvider = new System.Windows.Forms.Label();
            this.lblDateInput = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPricePurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftTop)).BeginInit();
            this.splitContainerLeftTop.Panel1.SuspendLayout();
            this.splitContainerLeftTop.Panel2.SuspendLayout();
            this.splitContainerLeftTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.gbDatetimePicker.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.gbPortfolio.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.pnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToolTip
            // 
            this.btnToolTip.AutoPopDelay = 5000;
            this.btnToolTip.InitialDelay = 200;
            this.btnToolTip.ReshowDelay = 100;
            // 
            // btnUpdatePrices
            // 
            this.btnUpdatePrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePrices.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrices.Location = new System.Drawing.Point(423, 5);
            this.btnUpdatePrices.Name = "btnUpdatePrices";
            this.btnUpdatePrices.Size = new System.Drawing.Size(117, 22);
            this.btnUpdatePrices.TabIndex = 13;
            this.btnUpdatePrices.Text = "Preise akualisieren";
            this.btnToolTip.SetToolTip(this.btnUpdatePrices, "Aktualisiert alle Preise in der Liste");
            this.btnUpdatePrices.UseVisualStyleBackColor = true;
            this.btnUpdatePrices.Click += new System.EventHandler(this.btnUpdatePrices_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Location = new System.Drawing.Point(320, 5);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteStock.TabIndex = 11;
            this.btnDeleteStock.Text = "Entfernen";
            this.btnToolTip.SetToolTip(this.btnDeleteStock, "Entfernen Sie ein ausgewähltes Wertpapier aus der Liste");
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Visible = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // nupStockQuantity
            // 
            this.nupStockQuantity.Location = new System.Drawing.Point(230, 7);
            this.nupStockQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupStockQuantity.Name = "nupStockQuantity";
            this.nupStockQuantity.Size = new System.Drawing.Size(50, 21);
            this.nupStockQuantity.TabIndex = 10;
            this.btnToolTip.SetToolTip(this.nupStockQuantity, "Geben Sie hier die Anzahl der Wertpapiere an, die Sie aufnehmen möchten");
            this.nupStockQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGetStock
            // 
            this.btnGetStock.Location = new System.Drawing.Point(286, 6);
            this.btnGetStock.Name = "btnGetStock";
            this.btnGetStock.Size = new System.Drawing.Size(28, 21);
            this.btnGetStock.TabIndex = 8;
            this.btnGetStock.Text = "+";
            this.btnToolTip.SetToolTip(this.btnGetStock, "Wertpapier in Watchlist hinzufügen");
            this.btnGetStock.UseVisualStyleBackColor = true;
            this.btnGetStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshChart.Location = new System.Drawing.Point(342, 4);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshChart.TabIndex = 18;
            this.btnRefreshChart.Text = "Neu laden";
            this.btnToolTip.SetToolTip(this.btnRefreshChart, "Chart vollständig neu laden");
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // btnDrawLineToggle
            // 
            this.btnDrawLineToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrawLineToggle.Location = new System.Drawing.Point(423, 4);
            this.btnDrawLineToggle.Name = "btnDrawLineToggle";
            this.btnDrawLineToggle.Size = new System.Drawing.Size(117, 23);
            this.btnDrawLineToggle.TabIndex = 17;
            this.btnDrawLineToggle.Text = "Neue Trendlinie";
            this.btnToolTip.SetToolTip(this.btnDrawLineToggle, "Neue Trendlinie zeichnen. Öffnet ein Formular, wo Sie die Gestalt einstellen könn" +
        "en");
            this.btnDrawLineToggle.UseVisualStyleBackColor = true;
            this.btnDrawLineToggle.Click += new System.EventHandler(this.btnDrawLineToggle_Click);
            // 
            // dpEnddate
            // 
            this.dpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnddate.Location = new System.Drawing.Point(128, 18);
            this.dpEnddate.Name = "dpEnddate";
            this.dpEnddate.Size = new System.Drawing.Size(92, 21);
            this.dpEnddate.TabIndex = 1;
            this.btnToolTip.SetToolTip(this.dpEnddate, "Enddatum");
            // 
            // dpStartdate
            // 
            this.dpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartdate.Location = new System.Drawing.Point(7, 18);
            this.dpStartdate.Name = "dpStartdate";
            this.dpStartdate.Size = new System.Drawing.Size(91, 21);
            this.dpStartdate.TabIndex = 0;
            this.btnToolTip.SetToolTip(this.dpStartdate, "Startdatum");
            // 
            // nupPricePurchase
            // 
            this.nupPricePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupPricePurchase.DecimalPlaces = 2;
            this.nupPricePurchase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupPricePurchase.Location = new System.Drawing.Point(74, 51);
            this.nupPricePurchase.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupPricePurchase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupPricePurchase.Name = "nupPricePurchase";
            this.nupPricePurchase.Size = new System.Drawing.Size(123, 21);
            this.nupPricePurchase.TabIndex = 20;
            this.nupPricePurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnToolTip.SetToolTip(this.nupPricePurchase, "Kaufpreis des Wertpapiers");
            this.nupPricePurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // btnSaveWatchlist
            // 
            this.btnSaveWatchlist.Enabled = false;
            this.btnSaveWatchlist.Location = new System.Drawing.Point(12, 117);
            this.btnSaveWatchlist.Name = "btnSaveWatchlist";
            this.btnSaveWatchlist.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWatchlist.TabIndex = 17;
            this.btnSaveWatchlist.Text = "Speichern";
            this.btnToolTip.SetToolTip(this.btnSaveWatchlist, "Speichern Sie Ihre Änderungen");
            this.btnSaveWatchlist.UseVisualStyleBackColor = true;
            this.btnSaveWatchlist.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // nupQuantity
            // 
            this.nupQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupQuantity.Location = new System.Drawing.Point(74, 83);
            this.nupQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nupQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(123, 21);
            this.nupQuantity.TabIndex = 16;
            this.nupQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnToolTip.SetToolTip(this.nupQuantity, "Anzahl des Wertpapiers");
            this.nupQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxDataProvider
            // 
            this.cbxDataProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataProvider.FormattingEnabled = true;
            this.cbxDataProvider.Location = new System.Drawing.Point(53, 27);
            this.cbxDataProvider.Name = "cbxDataProvider";
            this.cbxDataProvider.Size = new System.Drawing.Size(146, 23);
            this.cbxDataProvider.TabIndex = 12;
            this.btnToolTip.SetToolTip(this.cbxDataProvider, "Wählen Sie hier ihre Datenquelle. Falls es Probleme mit einer gibt, so können Sie" +
        " diese hier ändern.");
            this.cbxDataProvider.SelectedIndexChanged += new System.EventHandler(this.cbxDataProvider_SelectedIndexChanged);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel2.Controls.Add(this.panelRight);
            this.splitContainerMain.Panel2MinSize = 180;
            this.splitContainerMain.Size = new System.Drawing.Size(765, 406);
            this.splitContainerMain.SplitterDistance = 545;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 1;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.splitContainerLeftTop);
            this.splitContainerLeft.Panel1MinSize = 140;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerLeft.Panel2.Controls.Add(this.btnRefreshChart);
            this.splitContainerLeft.Panel2.Controls.Add(this.btnDrawLineToggle);
            this.splitContainerLeft.Panel2.Controls.Add(this.gbDatetimePicker);
            this.splitContainerLeft.Panel2.Controls.Add(this.panelChart);
            this.splitContainerLeft.Panel2MinSize = 100;
            this.splitContainerLeft.Size = new System.Drawing.Size(545, 406);
            this.splitContainerLeft.SplitterDistance = 140;
            this.splitContainerLeft.SplitterWidth = 3;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // splitContainerLeftTop
            // 
            this.splitContainerLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftTop.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerLeftTop.Name = "splitContainerLeftTop";
            this.splitContainerLeftTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeftTop.Panel1
            // 
            this.splitContainerLeftTop.Panel1.Controls.Add(this.panelTop);
            this.splitContainerLeftTop.Panel1MinSize = 40;
            // 
            // splitContainerLeftTop.Panel2
            // 
            this.splitContainerLeftTop.Panel2.Controls.Add(this.lvWatchlist);
            this.splitContainerLeftTop.Panel2MinSize = 60;
            this.splitContainerLeftTop.Size = new System.Drawing.Size(545, 140);
            this.splitContainerLeftTop.SplitterDistance = 48;
            this.splitContainerLeftTop.SplitterWidth = 3;
            this.splitContainerLeftTop.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.btnUpdatePrices);
            this.panelTop.Controls.Add(this.stockSearchView);
            this.panelTop.Controls.Add(this.btnDeleteStock);
            this.panelTop.Controls.Add(this.nupStockQuantity);
            this.panelTop.Controls.Add(this.btnGetStock);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.MinimumSize = new System.Drawing.Size(0, 32);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(545, 48);
            this.panelTop.TabIndex = 10;
            // 
            // stockSearchView
            // 
            this.stockSearchView.Location = new System.Drawing.Point(7, 5);
            this.stockSearchView.Margin = new System.Windows.Forms.Padding(2);
            this.stockSearchView.Name = "stockSearchView";
            this.stockSearchView.Size = new System.Drawing.Size(215, 28);
            this.stockSearchView.TabIndex = 12;
            // 
            // lvWatchlist
            // 
            this.lvWatchlist.AllowColumnReorder = true;
            this.lvWatchlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWatchlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWatchlist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWatchlist.FullRowSelect = true;
            this.lvWatchlist.Location = new System.Drawing.Point(0, 0);
            this.lvWatchlist.MultiSelect = false;
            this.lvWatchlist.Name = "lvWatchlist";
            this.lvWatchlist.Size = new System.Drawing.Size(545, 89);
            this.lvWatchlist.TabIndex = 0;
            this.lvWatchlist.UseCompatibleStateImageBehavior = false;
            this.lvWatchlist.View = System.Windows.Forms.View.Details;
            this.lvWatchlist.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvWatchlist_ColumnClick);
            this.lvWatchlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvWatchlist_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Symbol";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Börse";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Typ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Anzahl";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kaufpreis";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Preis aktuell";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Preis %";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gesamtwert";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Entwicklung %";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Entwicklung Total";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbDatetimePicker
            // 
            this.gbDatetimePicker.BackColor = System.Drawing.SystemColors.Window;
            this.gbDatetimePicker.Controls.Add(this.label1);
            this.gbDatetimePicker.Controls.Add(this.dpEnddate);
            this.gbDatetimePicker.Controls.Add(this.dpStartdate);
            this.gbDatetimePicker.Location = new System.Drawing.Point(6, 4);
            this.gbDatetimePicker.Name = "gbDatetimePicker";
            this.gbDatetimePicker.Size = new System.Drawing.Size(224, 43);
            this.gbDatetimePicker.TabIndex = 16;
            this.gbDatetimePicker.TabStop = false;
            this.gbDatetimePicker.Text = "Zeitraum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "bis";
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.SystemColors.Window;
            this.panelChart.Controls.Add(this.lblLoadingInfo);
            this.panelChart.Location = new System.Drawing.Point(0, 54);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(545, 211);
            this.panelChart.TabIndex = 0;
            // 
            // lblLoadingInfo
            // 
            this.lblLoadingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadingInfo.AutoSize = true;
            this.lblLoadingInfo.Location = new System.Drawing.Point(131, 102);
            this.lblLoadingInfo.Name = "lblLoadingInfo";
            this.lblLoadingInfo.Size = new System.Drawing.Size(312, 15);
            this.lblLoadingInfo.TabIndex = 12;
            this.lblLoadingInfo.Text = "Keine Chartdaten vorhanden. Bitte eine Aktie auswählen";
            this.lblLoadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.Controls.Add(this.gbPortfolio);
            this.panelRight.Controls.Add(this.gbDetails);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(217, 406);
            this.panelRight.TabIndex = 20;
            // 
            // gbPortfolio
            // 
            this.gbPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPortfolio.Controls.Add(this.nupPricePurchase);
            this.gbPortfolio.Controls.Add(this.lblCreatedInput);
            this.gbPortfolio.Controls.Add(this.lblCreatedInfo);
            this.gbPortfolio.Controls.Add(this.btnSaveWatchlist);
            this.gbPortfolio.Controls.Add(this.lblQuantityInfo);
            this.gbPortfolio.Controls.Add(this.nupQuantity);
            this.gbPortfolio.Controls.Add(this.lblPricePurchaseInfo);
            this.gbPortfolio.Location = new System.Drawing.Point(5, 210);
            this.gbPortfolio.Name = "gbPortfolio";
            this.gbPortfolio.Size = new System.Drawing.Size(205, 151);
            this.gbPortfolio.TabIndex = 19;
            this.gbPortfolio.TabStop = false;
            // 
            // lblCreatedInput
            // 
            this.lblCreatedInput.AutoSize = true;
            this.lblCreatedInput.Location = new System.Drawing.Point(72, 21);
            this.lblCreatedInput.Name = "lblCreatedInput";
            this.lblCreatedInput.Size = new System.Drawing.Size(16, 15);
            this.lblCreatedInput.TabIndex = 19;
            this.lblCreatedInput.Text = "...";
            // 
            // lblCreatedInfo
            // 
            this.lblCreatedInfo.AutoSize = true;
            this.lblCreatedInfo.Location = new System.Drawing.Point(11, 21);
            this.lblCreatedInfo.Name = "lblCreatedInfo";
            this.lblCreatedInfo.Size = new System.Drawing.Size(26, 15);
            this.lblCreatedInfo.TabIndex = 18;
            this.lblCreatedInfo.Text = "seit";
            // 
            // lblQuantityInfo
            // 
            this.lblQuantityInfo.AutoSize = true;
            this.lblQuantityInfo.Location = new System.Drawing.Point(10, 85);
            this.lblQuantityInfo.Name = "lblQuantityInfo";
            this.lblQuantityInfo.Size = new System.Drawing.Size(44, 15);
            this.lblQuantityInfo.TabIndex = 14;
            this.lblQuantityInfo.Text = "Anzahl";
            // 
            // lblPricePurchaseInfo
            // 
            this.lblPricePurchaseInfo.AutoSize = true;
            this.lblPricePurchaseInfo.Location = new System.Drawing.Point(9, 51);
            this.lblPricePurchaseInfo.Name = "lblPricePurchaseInfo";
            this.lblPricePurchaseInfo.Size = new System.Drawing.Size(59, 15);
            this.lblPricePurchaseInfo.TabIndex = 13;
            this.lblPricePurchaseInfo.Text = "Kaufpreis";
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.pnDetails);
            this.gbDetails.Controls.Add(this.lblDataProvider);
            this.gbDetails.Controls.Add(this.cbxDataProvider);
            this.gbDetails.Controls.Add(this.lblDateInput);
            this.gbDetails.Controls.Add(this.lblDate);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(5, 8);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(205, 196);
            this.gbDetails.TabIndex = 18;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Wertpapier";
            // 
            // pnDetails
            // 
            this.pnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetails.Controls.Add(this.pnLine);
            this.pnDetails.Controls.Add(this.lblVolumeInput);
            this.pnDetails.Controls.Add(this.lblChangePercentageInput);
            this.pnDetails.Controls.Add(this.lblOpen);
            this.pnDetails.Controls.Add(this.lblClose);
            this.pnDetails.Controls.Add(this.lblVolume);
            this.pnDetails.Controls.Add(this.lblCloseInput);
            this.pnDetails.Controls.Add(this.lblOpenInput);
            this.pnDetails.Location = new System.Drawing.Point(6, 87);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(193, 104);
            this.pnDetails.TabIndex = 44;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnLine.Location = new System.Drawing.Point(1, 51);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(200, 1);
            this.pnLine.TabIndex = 44;
            // 
            // lblVolumeInput
            // 
            this.lblVolumeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumeInput.Location = new System.Drawing.Point(70, 3);
            this.lblVolumeInput.Name = "lblVolumeInput";
            this.lblVolumeInput.Size = new System.Drawing.Size(120, 16);
            this.lblVolumeInput.TabIndex = 6;
            this.lblVolumeInput.Text = "...";
            // 
            // lblChangePercentageInput
            // 
            this.lblChangePercentageInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangePercentageInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePercentageInput.Location = new System.Drawing.Point(70, 79);
            this.lblChangePercentageInput.Name = "lblChangePercentageInput";
            this.lblChangePercentageInput.Size = new System.Drawing.Size(120, 22);
            this.lblChangePercentageInput.TabIndex = 43;
            this.lblChangePercentageInput.Text = "...";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(3, 28);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(36, 15);
            this.lblOpen.TabIndex = 9;
            this.lblOpen.Text = "Open";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(3, 57);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 15);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "Preis";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(3, 2);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(47, 15);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume";
            // 
            // lblCloseInput
            // 
            this.lblCloseInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseInput.Location = new System.Drawing.Point(70, 57);
            this.lblCloseInput.Name = "lblCloseInput";
            this.lblCloseInput.Size = new System.Drawing.Size(120, 19);
            this.lblCloseInput.TabIndex = 5;
            this.lblCloseInput.Text = "...";
            // 
            // lblOpenInput
            // 
            this.lblOpenInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpenInput.Location = new System.Drawing.Point(70, 28);
            this.lblOpenInput.Name = "lblOpenInput";
            this.lblOpenInput.Size = new System.Drawing.Size(120, 16);
            this.lblOpenInput.TabIndex = 4;
            this.lblOpenInput.Text = "...";
            // 
            // lblDataProvider
            // 
            this.lblDataProvider.AutoSize = true;
            this.lblDataProvider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataProvider.Location = new System.Drawing.Point(10, 31);
            this.lblDataProvider.Name = "lblDataProvider";
            this.lblDataProvider.Size = new System.Drawing.Size(38, 15);
            this.lblDataProvider.TabIndex = 13;
            this.lblDataProvider.Text = "Daten";
            // 
            // lblDateInput
            // 
            this.lblDateInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateInput.Location = new System.Drawing.Point(77, 67);
            this.lblDateInput.Name = "lblDateInput";
            this.lblDateInput.Size = new System.Drawing.Size(119, 16);
            this.lblDateInput.TabIndex = 3;
            this.lblDateInput.Text = "...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(10, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 15);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Datum";
            // 
            // WatchlistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainerMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WatchlistView";
            this.Size = new System.Drawing.Size(765, 406);
            ((System.ComponentModel.ISupportInitialize)(this.nupStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPricePurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitContainerLeftTop.Panel1.ResumeLayout(false);
            this.splitContainerLeftTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftTop)).EndInit();
            this.splitContainerLeftTop.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.gbDatetimePicker.ResumeLayout(false);
            this.gbDatetimePicker.PerformLayout();
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.gbPortfolio.ResumeLayout(false);
            this.gbPortfolio.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.SplitContainer splitContainerLeftTop;
        private System.Windows.Forms.ListView lvWatchlist;
        private System.Windows.Forms.Button btnGetStock;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVolumeInput;
        private System.Windows.Forms.Label lblCloseInput;
        private System.Windows.Forms.Label lblOpenInput;
        private System.Windows.Forms.Label lblDateInput;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.NumericUpDown nupStockQuantity;
        private System.Windows.Forms.Label lblLoadingInfo;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Label lblQuantityInfo;
        private System.Windows.Forms.Label lblPricePurchaseInfo;
        private System.Windows.Forms.Button btnSaveWatchlist;
        private StockSearchView stockSearchView;
        private System.Windows.Forms.Button btnUpdatePrices;
        private System.Windows.Forms.GroupBox gbPortfolio;
        private System.Windows.Forms.Label lblCreatedInfo;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblCreatedInput;
        private System.Windows.Forms.ComboBox cbxDataProvider;
        private System.Windows.Forms.Label lblDataProvider;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown nupPricePurchase;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox gbDatetimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpEnddate;
        private System.Windows.Forms.DateTimePicker dpStartdate;
        private System.Windows.Forms.Button btnDrawLineToggle;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.Label lblChangePercentageInput;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.ToolTip btnToolTip;
    }
}
