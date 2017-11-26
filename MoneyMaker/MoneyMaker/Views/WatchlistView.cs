using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Helpers;
using System.Drawing;

namespace MoneyMaker.Views
{
    public partial class WatchlistView : MoneyMakerView
    {
        private DateTime startDate = DateTime.Now.AddMonths(-9);
        private DateTime endDate = DateTime.Now;
        
        private WatchList watchlist;
        private WatchlistModel model = new WatchlistModel();
        
        private StockListitem selectedStock = null;
        private SingleQuote stockLatestPrice;
        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();

        private ListViewColumnSorter lvwColumnSorter;

        /// <summary>
        /// Constructor
        /// </summary> 
        public WatchlistView(WatchList watchlist)
        {
            if(watchlist != null)
            {
                this.watchlist = watchlist;
                InitializeComponent();
                refreshWatchlistDataAsync();
                updateStockPricesInListView();
                mainForm.setHeadline("Watchlist : "+ watchlist.Name);
                setDefaultCurrencyInLabel();

                cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Google);
                cbxDataProvider.Items.Add(FinanceAPI.FinanceStrategies.Yahoo);
                cbxDataProvider.SelectedItem = webFinanceStrategy;

                lvwColumnSorter = new ListViewColumnSorter();
                lvWatchlist.ListViewItemSorter = lvwColumnSorter;

                dpEnddate.Value = endDate;
                dpStartdate.MaxDate = DateTime.Now;
                dpStartdate.Value = startDate;

                lvWatchlist.Columns.Add("Buchwert");
                lvWatchlist.Columns.Add("Marktkapitalisierung");
                lvWatchlist.Columns.Add("50 Tage");
                lvWatchlist.Columns.Add("250 Tage");

                dpEnddate.ValueChanged += new EventHandler(datetime_Changed);
                dpStartdate.ValueChanged += new EventHandler(datetime_Changed);
            }
        }

        /// <summary>
        /// Changes the datetime and refreshes the chart asynchronously
        /// </summary>
        private void datetime_Changed(object sender, EventArgs e)
        {
            if (selectedStock != null)
            {
                startDate = dpStartdate.Value;
                endDate = dpEnddate.Value;
                drawChart(selectedStock);
            }
        }

        /// <summary>
        /// Refresh the watchlist listview
        /// </summary>
        private async void refreshWatchlistDataAsync()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapierdaten werden geladen...");
            
            lvWatchlist.Items.Clear();
            
            Task<List<StockListitem>> task = Task.Run(() => model.getStocksByWatchlistID(watchlist.WatchListID));
            var stocks = await task;
            if(stocks != null)
            {
                foreach (StockListitem stock in stocks)
                {
                    var lvItem = new ListViewItem(stock.toStringArray());
                    lvItem.Tag = stock;
                    lvWatchlist.Items.Add(lvItem);
                }

                updateStockPricesInListView();

                if (!lvWatchlist.IsDisposed)
                {
                    lvWatchlist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvWatchlist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    lvWatchlist.Columns[2].Width = 120;
                }
            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        #region Button clicks
        /// <summary>
        /// Adds stock to watchlist
        /// </summary>
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            ComboBox cbMultiLine = stockSearchView.SearchBox;

            StockListitem watchlistStock = new StockListitem();
            YahooStockSearchResult selectedItem = (YahooStockSearchResult) cbMultiLine.SelectedItem;
           
            // Add Stock to List
            if (selectedItem != null)
            {
                watchlistStock = model.buildWatchlistStockItem(watchlist.WatchListID, selectedItem, nupStockQuantity.Value);
                 
                // Save to data
                insertStockAsync(watchlistStock);
                updateStockPricesInListView();
            }
        }

        /// <summary>
        /// Inserts the stock to the watchlist
        /// </summary>
        private async void insertStockAsync(StockListitem watchlistStock)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Aktie wird gespeichert...");

            FinanceAPI rest = new FinanceAPI(webFinanceStrategy, watchlistStock.symbol);
            Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
            stockLatestPrice = await taskStockData;

            if(stockLatestPrice != null)
            {
                watchlistStock.Change = stockLatestPrice.Change;
                watchlistStock.PurchaseDate = DateTime.Now;
                watchlistStock.PricePurchase = stockLatestPrice.CurrentPrice;
                watchlistStock.PriceCurrent = Convert.ToDouble(stockLatestPrice.CurrentPrice);
                watchlistStock.StocksMapID = model.insertStockToWatchlist(watchlistStock);

                if (webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                {
                    var yahooStock = stockLatestPrice as YahooSingleQuote;
                    watchlistStock.BookValue = yahooStock.BookValue;
                    watchlistStock.MarketCapitalization = yahooStock.MarketCapitalization;
                    watchlistStock.FiftydayMovingAverage = yahooStock.FiftydayMovingAverage;
                    watchlistStock.TwoHundreddayMovingAverage = yahooStock.TwoHundreddayMovingAverage;
                }
                selectedStock = watchlistStock;
                loadChartDataAsync(watchlistStock);

                // Add to listview
                var lvItem = new ListViewItem(watchlistStock.toStringArray());
                lvItem.Tag = watchlistStock;
                lvWatchlist.Items.Add(lvItem);
            }
            else
            {
                MessageBox.Show("Es konnten keine Preisinformationen für das Wertpapier gefunden werden.");
            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        /// <summary>
        /// Saves changes of stock in watchlist
        /// </summary>
        private async void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if(selectedStock != null)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapier wird gespeichert...");

                StocksMap wlm = selectedStock.toMap('w');
                wlm.PurchasePrice = Convert.ToInt32(nupPricePurchase.Value);
                wlm.Quantity = Convert.ToInt32(nupQuantity.Value);
                Task task = Task.Run(() => model.updateStocksMap(wlm,'w'));
                await task;

                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapierdaten werden aktualisiert...");

                refreshWatchlistDataAsync();

                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
            }
        }

        /// <summary>
        /// Removes stock from watchlist
        /// </summary>
        private async void btnDeleteStock_Click(object sender, EventArgs e)
        {
            btnDeleteStock.Visible = false;
            if (lvWatchlist.SelectedItems.Count > 0)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapiere werden aus der Watchlist entfernt...");

                var selected = lvWatchlist.SelectedItems;
                foreach (ListViewItem item in selected)
                {
                    StockListitem wls = (StockListitem)item.Tag;
                    Task task = Task.Run(()=> model.deleteStockFromWatchlist(wls));
                    await task;
                }
                selectedStock = null;
                refreshWatchlistDataAsync();
                cleanRightSidebar();
                panelChart.Controls.Clear();

                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
            }
        }

        #endregion

        /// <summary>
        /// Changes the selected item
        /// </summary>
        private void lvWatchlist_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = lvWatchlist.PointToClient(Control.MousePosition);
                ListViewHitTestInfo hitTest = lvWatchlist.HitTest(mousePos);

                var firstSelected = hitTest.Item;
                if (firstSelected?.Tag != null)
                {
                    btnDeleteStock.Visible = true;
                    selectedStock = (StockListitem)firstSelected.Tag;
                    loadChartDataAsync(selectedStock);
                }
                else
                {
                    cleanRightSidebar();
                }
            }
        }

        /// <summary>
        /// updates the latest stock prices in listview
        /// </summary>
        private async void updateStockPricesInListView()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Aktuellste Wertpapierdaten werden abgefragt...");

            for (int i = 0; i < lvWatchlist.Items.Count; i++)
            {
                StockListitem slItem = (StockListitem)lvWatchlist.Items[i].Tag;
                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, slItem.symbol);
                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                SingleQuote stockData = await taskStockData;
                if(stockData != null)
                {

                    if (webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                    {
                        var yahooStock = (YahooSingleQuote)stockData;
                        slItem.BookValue = yahooStock.BookValue;
                        slItem.MarketCapitalization = yahooStock.MarketCapitalization;
                        slItem.FiftydayMovingAverage = yahooStock.FiftydayMovingAverage;
                        slItem.TwoHundreddayMovingAverage = yahooStock.TwoHundreddayMovingAverage;
                    }

                    slItem.Change = stockData.Change;
                    slItem.PriceCurrent = Convert.ToDouble( stockData.CurrentPrice );
                    lvWatchlist.Items[i] = new ListViewItem(slItem.toStringArray(webFinanceStrategy));
                    lvWatchlist.Items[i].Tag = slItem;
                }
            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
        }

        /// <summary>
        /// Prepares data for stock chart and detail view
        /// </summary>
        private async void loadChartDataAsync(StockListitem selectedItem = null)
        {
            if(selectedItem != null)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Wertpapierdaten für "+ selectedItem.name +" werden abgefragt...");
            
                FinanceAPI rest = new FinanceAPI(webFinanceStrategy, selectedItem.symbol); 
            
                drawChart(selectedItem);
                Task<SingleQuote> taskStockData = Task.Run(() => rest.getLatestQuote());
                stockLatestPrice = await taskStockData; 
                fillRightSidebarWithData();

                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
            }
        }
        
        /// <summary>
        /// updates the stock details on the right sidebar
        /// </summary>
        private void fillRightSidebarWithData()
        { 

            btnSaveWatchlist.Enabled = false;
            if(selectedStock != null)
            { 
                additionalStockData(selectedStock);
                lblCreatedInput.Text = selectedStock.PurchaseDate.ToShortDateString(); 

                btnSaveWatchlist.Enabled = true;
                nupQuantity.Value = Convert.ToDecimal(selectedStock.Quantity);

                decimal pricePurchase = Convert.ToDecimal(selectedStock.PricePurchase);
                if(pricePurchase > 0)
                    nupPricePurchase.Value = pricePurchase;

            }

            if(stockLatestPrice != null)
            {
                stockLatestPrice.Name = (selectedStock != null) ? selectedStock.name : "";
                // stockDetailsView.refreshData(stockLatestPrice);
                gbDetails.Text = stockLatestPrice.Name;
                lblDateInput.Text = stockLatestPrice.Date.ToShortDateString();
                lblOpenInput.Text = stockLatestPrice.toPriceFormat(stockLatestPrice.Open);
                lblCloseInput.Text = stockLatestPrice.toPriceFormat(stockLatestPrice.CurrentPrice);
                lblVolumeInput.Text = stockLatestPrice.Volume.ToString();
                lblChangePercentageInput.Text = stockLatestPrice.ChangePercentage.ToString("+0.00%;-0.00%");
                lblChangePercentageInput.ForeColor = (stockLatestPrice.ChangePercentage >= 0) ? Color.Green : Color.Red;
            }
        }

        /// <summary>
        /// Additional stock data (book value, market capilization, etc.)
        /// </summary>
        private void additionalStockData(StockListitem selectedStock)
        {
            if (selectedStock != null)
            {
                int height = 30;
                var fullHeight = (height) * 4;

                if (gbDetails.Controls.ContainsKey("pnDetailsAdditional"))
                {
                    gbDetails.Controls.RemoveByKey("pnDetailsAdditional");
                    gbDetails.Size = new Size(gbDetails.Size.Width, (gbDetails.Size.Height - fullHeight));
                    pnDetails.Location = new Point(pnDetails.Location.X, pnDetails.Location.Y - fullHeight);
                    gbPortfolio.Location = new Point(gbPortfolio.Location.X, gbPortfolio.Location.Y - fullHeight); 
                }

                if (webFinanceStrategy == FinanceAPI.FinanceStrategies.Yahoo)
                {
                    var topControl = pnDetails.Location;
                    // Make box bigger
                    gbDetails.Size = new Size(gbDetails.Size.Width, (gbDetails.Size.Height + fullHeight));
                    pnDetails.Location = new Point(pnDetails.Location.X, pnDetails.Location.Y + fullHeight);
                    gbPortfolio.Location = new Point(gbPortfolio.Location.X, gbPortfolio.Location.Y + fullHeight); 

                    string[] additionalStockDataLabel = { "Buchwert", "Marktkap.", "50-Tage", "250-Tage" };
                    string[] additionalStockData = { selectedStock.BookValue.ToString(), selectedStock.MarketCapitalization, selectedStock.FiftydayMovingAverage.ToString(), selectedStock.TwoHundreddayMovingAverage.ToString() };

                    Panel pnDetailsAdditional = new Panel();
                    pnDetailsAdditional.Name = "pnDetailsAdditional";
                    pnDetailsAdditional.Location = new Point(10, topControl.Y + 7);
                    pnDetailsAdditional.Size = new Size(180, fullHeight);
                    gbDetails.Controls.Add(pnDetailsAdditional);

                    for (int i = 0; i < 4; i++)
                    {
                        Label labelInfo = new Label();
                        labelInfo.Size = new Size(60, height);
                        labelInfo.Text = additionalStockDataLabel[i];
                        labelInfo.Location = new Point(0, (height * i));
                        Label labelBox = new Label();
                        labelBox.Text = additionalStockData[i];
                        labelBox.AutoSize = true;
                        labelBox.Location = new Point(80, (height * i));
                        pnDetailsAdditional.Controls.Add(labelInfo);
                        pnDetailsAdditional.Controls.Add(labelBox);
                    }
                }
            }
        }

        /// <summary>
        /// Resets the right sidebar with its details
        /// </summary>
        private void cleanRightSidebar()
        {
            foreach (Control groupBox in panelRight.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control x in groupBox.Controls)
                    {
                        if (x is Label && ((Label)x).Name.Contains("Input"))
                        {
                            x.Text = "...";
                        }
                        else if (x is Panel)
                        {
                            foreach (Control y in x.Controls)
                            {
                                if (y is Label && ((Label)y).Name.Contains("Input"))
                                {
                                    y.Text = "...";
                                }
                            }
                        }
                    }
                }
            }
            gbDetails.Text = "Wertpapier";
            selectedStock = null;
            nupQuantity.Value = 1;
        }

        /// <summary>
        /// Draws the chart for stock in shared view
        /// </summary>
        private void drawChart(StockListitem stockItem)
        {
            if (stockItem != null)
            {
                UserControl view = new StockChartView(stockItem, webFinanceStrategy, startDate, endDate);
                view.Dock = DockStyle.Fill;
                panelChart.Controls.Clear();
                panelChart.Controls.Add(view);
            }
        }

        /// <summary>
        /// Gets the current prices and updates the list
        /// </summary>
        private void btnUpdatePrices_Click(object sender, EventArgs e)
        {
            updateStockPricesInListView();
        }

        /// <summary>
        /// Changes the data provider
        /// </summary>
        private void cbxDataProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            webFinanceStrategy = (FinanceAPI.FinanceStrategies) cbxDataProvider.SelectedItem;
            loadChartDataAsync(selectedStock);
        }

        /// <summary>
        /// Sorts the column on click
        /// </summary> 
        private void lvWatchlist_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        private void btnDrawLineToggle_Click(object sender, EventArgs e)
        {
            var controls = panelChart.Controls;
            if(controls != null)
            {
                foreach (Control control in controls)
                {
                    if(control is StockChartView)
                    {
                        var chart = (StockChartView)control;
                        var splitMain = chart.SplitContainer;
                        splitMain.Panel2Collapsed = !splitMain.Panel2Collapsed;
                        chart.DrawingAllowed = !chart.DrawingAllowed;
                        chart.CreateNewTrendlineChecked = !chart.CreateNewTrendlineChecked;
                    }
                }
            }
        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            drawChart(selectedStock);
        }
    }
}
