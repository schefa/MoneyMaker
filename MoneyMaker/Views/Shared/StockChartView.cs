using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Libraries.Webservices;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Models.Database;

namespace MoneyMaker.Views
{
    public partial class StockChartView : MoneyMakerView
    {

        #region Attributes

        private FinanceAPI.FinanceStrategies webFinanceStrategy = SettingsModel.getInstance().getFinanceDataProvider();
        private string currencySymbol = SettingsModel.getInstance().getCurrency().ToString();

        private StockListitem stock = null;
        private List<HistoricalQuote> stockHistoricalPrices;
        private DateTime startDate = DateTime.Now.AddMonths(-9);
        private DateTime endDate = DateTime.Now;
        private Dictionary<double, HistoricalQuote> seriesDict = new Dictionary<double, HistoricalQuote>();

        private int dotCount = 0;
        private DataPoint selectedDot = null;
        private Series selectedSeries = null;
        private UserLines selectedLine = null;

        private PictureBox pbLoader;
        private List<UserLines> userlines = new List<UserLines>();

        private SplitContainer splitContainer;
        public SplitContainer SplitContainer
        {
            get { return splitContainer; }
        }

        public bool CreateNewTrendlineChecked
        {
            get { return createNewTrendlineToolStripMenuItem.Checked; }
            set { createNewTrendlineToolStripMenuItem.Checked = value; }
        }

        private bool drawingAllowed = false;
        public bool DrawingAllowed
        {
            get { return drawingAllowed; }
            set { drawingAllowed = value; }
        }

        private Color lineColor = Color.Gray;
        private int lineThickness = 1;
        
        private double mousePosX = 0;
        private double mousePosY = 0;

        private int pointNr = 1;
        private ToolTip tooltip = new ToolTip();
        private Point? currentMouseLocation = null;
        private DataPoint currentPoint;
        private DataPoint lastPoint;
        
        #endregion

        #region Constructors & Pre-Settings
        public StockChartView(StockListitem stock, FinanceAPI.FinanceStrategies webFinanceStrategy)
        {
            InitializeComponent();
            this.stock = stock;
            this.webFinanceStrategy = webFinanceStrategy;
            setParameters();
            drawChartAsync();
            getAllLinesAsync();
        }

        public StockChartView(StockListitem stock, FinanceAPI.FinanceStrategies webFinanceStrategy, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.stock = stock;
            this.webFinanceStrategy = webFinanceStrategy;
            this.startDate = startDate;
            this.endDate = endDate;
            setParameters();
            drawChartAsync();
            getAllLinesAsync();
        }
        
        private void setParameters()
        {
            splitMain.Panel2Collapsed = true;
            pbLoader = getLoaderImage();
            currencySymbol = FinanceUnifier.getCurrencyBySymbol(stock.symbol).Symbol;
            splitContainer = splitMain;
        }

        Graphics graphDrawingArea;
        Bitmap bmpDrawingArea;

        /// <summary>
        /// When the chart if fully loaded attach the mousemove method. Otherwise error occurs on hover
        /// </summary>
        private void chartStock_Paint(object sender, PaintEventArgs e)
        {
            chartStock.MouseMove += new MouseEventHandler(chartStock_MouseMove);

            bmpDrawingArea = new Bitmap(Width, Height);
            graphDrawingArea = Graphics.FromImage(bmpDrawingArea);
        }

        #endregion
        
        #region Draw Chart

        /// <summary>
        /// Draws trend lines asynchronously
        /// </summary>
        private async void drawLinesAsync()
        {

            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Userlines werden geladen...");

            var model = new UserlineModel(stock);
            Task<List<UserLines>> task = Task.Run(() => model.getAllUserlines());
            var userlines = await task;

            if(userlines != null)
            { 

                foreach (var userline in userlines)
                {
                    var pointStart = new DataPoint(userline.TimePoint1, userline.PricePoint1);
                    var pointEnd = new DataPoint(userline.TimePoint2, userline.PricePoint2);
                    var color = ColorTranslator.FromHtml(userline.LineColor);
                    
                    var line = new Series("Line_" + pointNr);
                    line.ChartType = SeriesChartType.Line;
                    line.BorderWidth = (int) userline.Thickness;
                    line.Color = color;
                    line.Tag = userline;
                    
                    line.Points.Add(pointStart);
                    line.Points[0].MarkerSize = (int) (userline.Thickness * 2);
                    line.Points[0].MarkerStyle = MarkerStyle.Circle;
                    line.Points.Add(pointEnd);
                    line.Points[1].MarkerSize = (int) (userline.Thickness * 2);
                    line.Points[1].MarkerStyle = MarkerStyle.Circle;

                    chartStock.Series.Add(line);

                    pointNr += 2;
                }

            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
        }
        
        /// <summary>
        /// Draws the chart asynchronously
        /// </summary>
        private async void drawChartAsync(SeriesChartType chartType = SeriesChartType.Line)
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Aktiendaten werden geladen...");

            splitMain.Panel1.Controls.Add(pbLoader);
            pbLoader.BringToFront();
            
            FinanceAPI rest = new FinanceAPI(webFinanceStrategy, stock.symbol);
            Task<List<HistoricalQuote>> taskHistoricalData = Task.Run(() => rest.getHistoricalQuotesList(startDate, endDate));
            stockHistoricalPrices = await taskHistoricalData;
            
            chartStock.Series.Clear();
            if (stockHistoricalPrices != null)
            {

                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Chart wird gezeichnet...");
                
                var series = new Series();
                series.ChartArea = chartStock.ChartAreas[0].Name;

                var volumes = new Series();
                volumes.ChartArea = chartStock.ChartAreas[1].Name;

                series.ChartType = chartType;
                series.BorderWidth = 3;

                foreach (HistoricalQuote stockData in stockHistoricalPrices)
                { 
                    series.Points.AddXY(stockData.Date, stockData.Close);
                    if(!seriesDict.ContainsKey(stockData.Date.ToOADate()))
                        seriesDict.Add(stockData.Date.ToOADate(), stockData);
                    volumes.Points.AddXY(stockData.Date, stockData.Volume);
                }

                chartStock.Series.Add(series);
                chartStock.Series.Add(volumes);
                
                drawChartStockAxis();
                drawLinesAsync();

                splitMain.Panel1.Controls.Remove(pbLoader);

                if (series.Points.Count == 0)
                {
                    splitMain.Panel1.Controls.Clear();
                    var info = new Label();
                    info.Text = "Abruf historischer Daten war nicht möglich";
                    info.Size = new Size(300, 30);
                    info.Location = new Point(20, 30);
                    splitMain.Panel1.Controls.Add(info);
                }

            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage);
             
        }

        /// <summary>
        /// Draws the chart axes
        /// </summary>
        private void drawChartStockAxis()
        {
            DateTime minDate = startDate.AddSeconds(-1);
            DateTime maxDate = endDate;
            
            // X Axis Prices
            chartStock.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartStock.ChartAreas[0].AxisX.Interval = 1;
            chartStock.ChartAreas[0].AxisX.IntervalOffset = 1;
            chartStock.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chartStock.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chartStock.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            // X Axis Volumes
            chartStock.ChartAreas[1].AxisX.Interval = 1;
            chartStock.ChartAreas[1].AxisX.IntervalOffset = 1;
            chartStock.ChartAreas[1].AxisX.IntervalType = DateTimeIntervalType.Months;
            
            chartStock.ChartAreas[1].AxisX.Minimum = minDate.ToOADate();
            chartStock.ChartAreas[1].AxisX.Maximum = maxDate.ToOADate();

            string volFormat = "{0}";
            if (chartStock.Series.Count >= 1 && chartStock.Series[1].Points.Count > 0)
            {
                DataPoint maxVolumePoint = chartStock.Series[1].Points.FindMaxByValue();
                if (maxVolumePoint.YValues[0] > 10000 && maxVolumePoint.YValues[0] < 1000000)
                {
                    volFormat = "{0:0,}K";
                }
                else if(maxVolumePoint.YValues[0] >= 1000000)
                {
                    volFormat = "{0:0,,}M";
                }
            }
            chartStock.ChartAreas[1].AxisY.LabelStyle.Format = volFormat;
            
            // Y Axis Prices
            double minValue = 0;
            double maxValue = 1;
            if (chartStock.Series.Count > 1 && chartStock.Series[0].Points.Count > 0)
            {
                DataPoint minY = chartStock.Series[0].Points.FindMinByValue();
                minValue = Math.Round( minY.YValues[0] - (minY.YValues[0] * 0.01) , 2)* 0.95;

                DataPoint maxY = chartStock.Series[0].Points.FindMaxByValue();
                maxValue = Math.Round(maxY.YValues[0] + (maxY.YValues[0] * 0.01), 2) * 1.05;
            }

            int decimals = (maxValue < 10) ? 2 : 0;

            chartStock.ChartAreas[0].AxisY.Minimum = Math.Round(minValue, decimals);
            chartStock.ChartAreas[0].AxisY.Maximum = Math.Round(maxValue, decimals);
            
        }

        /// <summary>
        /// Creates the loader image
        /// </summary>
        private PictureBox getLoaderImage()
        {
            PictureBox pbLoader = new PictureBox();
            pbLoader.Dock = DockStyle.Fill;
            pbLoader.BackColor = SystemColors.Window;
            pbLoader.Image = Properties.Resources.loader;
            pbLoader.Size = splitMain.Panel1.Size;
            pbLoader.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLoader.Location = new Point(0, 0);
            return pbLoader;
        }

        /// <summary>
        /// Refreshes the chart asynchronously
        /// </summary>
        private void refreshChartAsync(string searchSymbol)
        {
            tooltip.RemoveAll();
            MoneyMakerView view = new StockChartView(stock, webFinanceStrategy, startDate, endDate);
            view.Dock = DockStyle.Fill;
            Parent.Controls.Add(view);
            Parent.Controls.Remove(this);
        }

        #endregion

        #region Chart methods
        
        /// <summary>
        /// Mouse click event
        /// </summary>
        private void chartStock_MouseDown(object sender, MouseEventArgs e)
        {

            if (DrawingAllowed && e.Location != null && selectedLine == null) // Open edit form to create new line
            {
                drawSingleLineAsync(e);
            }
            else if (selectedLine != null)   // Click on end point of line
            {
                var results = chartStock.HitTest(currentMouseLocation.Value.X, currentMouseLocation.Value.Y, false, ChartElementType.DataPoint);
                foreach (var result in results)
                {
                    if (result.ChartElementType == ChartElementType.DataPoint)
                    {
                        var index = result.Series.Points.IndexOf((DataPoint)result.Object);
                        selectedDot = (index >= 0) ? result.Series.Points[index] : null;
                    }
                }
                chartStock.Invalidate();
            }
            else // Click and test if line is  selected
            {
                btnDeleteLine.Visible = false;
                btnLineSubmitChanges.Visible = false;
                testUserlineClick();
            }
        }
        
        /// <summary>
        /// Creates tooltip or crosshair
        /// </summary>
        private void chartStock_MouseMove(object sender, MouseEventArgs e)
        {
            if ((crosshairToolStripMenuItem.Checked || tooltipToolStripMenuItem.Checked) 
                && currentMouseLocation != e.Location && e.X > 0 && e.Y > 0 
                && e.X < (chartStock.Width-1) )
            {
                tooltip.RemoveAll();
                currentMouseLocation = e.Location;

                if(selectedSeries != null && selectedDot != null )
                {
                    double dateOLE = chartStock.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                    double price = chartStock.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                    
                    int index = selectedSeries.Points.IndexOf(selectedDot);
                    if(index >= 0)
                    {
                        selectedSeries.Points[index].XValue = dateOLE;
                        selectedSeries.Points[index].YValues[0] = price;
                        var currentItem = (UserLines) selectedSeries.Tag;
                        if(index == 0)
                        {
                            currentItem.TimePoint1 = dateOLE;
                            currentItem.PricePoint1 = price;
                        }
                        else if(index == 1)
                        {
                            currentItem.TimePoint2 = dateOLE;
                            currentItem.PricePoint2 = price;
                        }
                        selectedLine = currentItem;
                        selectedSeries.Tag = selectedLine;
                    }

                    chartStock.Invalidate();
                }
                else if (!DrawingAllowed)
                {
                    double dateOLE = chartStock.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                    if(!double.IsInfinity(dateOLE))
                    {
                        double cursorX = Math.Round(dateOLE,0 );
                        double cursorY = .0;
                        decimal price = 0;
                        decimal volume = 0;

                        if (seriesDict.ContainsKey(cursorX) && seriesDict[cursorX] != null)
                        {
                            cursorY = (double) seriesDict[cursorX].Close;
                            price = seriesDict[cursorX].Close;
                            volume = seriesDict[cursorX].Volume;
                        }
                
                        if(crosshairToolStripMenuItem.Checked)
                        {
                            double verticalLinePos = chartStock.ChartAreas[0].AxisY.ValueToPixelPosition(cursorY);
                            chartStock.ChartAreas[0].CursorX.SetCursorPixelPosition(new Point(e.X, e.Y), true);
                            chartStock.ChartAreas[1].CursorX.SetCursorPixelPosition(new Point(e.X, e.Y), true);
                            chartStock.ChartAreas[0].CursorY.SetCursorPixelPosition(new Point(e.X, (int) verticalLinePos), true);
                        }

                        if(tooltipToolStripMenuItem.Checked)
                        {
                            var toolTipText = String.Format(Math.Round(price,2) + " " + currencySymbol
                                + Environment.NewLine + "Volumen: " + String.Format("{0:#,#,0}", volume) 
                                + Environment.NewLine + DateTime.FromOADate(dateOLE).ToShortDateString());
                            tooltip.Show(toolTipText, chartStock, e.Location.X + 10, e.Location.Y - 15);
                        }
                    }
                }
            }
        }

        private void chartStock_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedDot != null)
                selectedDot = null;
        }

        /// <summary>
        /// Method when mouse leaves the chart - clear controls
        /// </summary>
        private void chartStock_MouseLeave(object sender, EventArgs e)
        {
            tooltip.RemoveAll();
            chartStock.ChartAreas[0].CursorX.SetCursorPosition(0);
            chartStock.ChartAreas[1].CursorX.SetCursorPosition(0);
            chartStock.ChartAreas[0].CursorY.SetCursorPosition(0); 
        }

        #endregion

        #region Lines

        /// <summary>
        /// Opens the infobox and replaces fields with selected user line
        /// </summary>
        private void createUserlineInfobox(UserLines line)
        {
            splitMain.Panel2Collapsed = false;
            tbLineThickness.Value = (line?.Thickness >= 1) ? Convert.ToInt16( line?.Thickness ) : 1;
            lineThickness = tbLineThickness.Value;
            lblLineThickness.Text = "Breite : " + tbLineThickness.Value;
            btnLinecolor.BackColor = ColorTranslator.FromHtml(line?.LineColor);
            lineColor = btnLinecolor.BackColor;
            btnDeleteLine.Visible = true;
        }

        /// <summary>
        /// When user click on the chart element, check if userline was selected
        /// </summary>

        private void testUserlineClick()
        {
            splitMain.Panel2Collapsed = true;
            selectedSeries = null;
            selectedLine = null;
            DrawingAllowed = false;

            if (userlines != null)
            {
                var pos = currentMouseLocation; 
                var results = chartStock.HitTest(pos.Value.X, pos.Value.Y, false, ChartElementType.DataPoint);
                foreach (var result in results)
                {
                    if (result.ChartElementType == ChartElementType.DataPoint && result.Series.Name.Contains("Line"))
                    {
                        selectedSeries = result.Series;
                        var item = (UserLines) result.Series.Tag;

                        DrawingAllowed = true;
                        selectedLine = item;
                        createUserlineInfobox(selectedLine);

                        btnLineSubmitChanges.Visible = true;

                        result.Series.BorderWidth = (int) item?.Thickness;
                    }
                } 

                chartStock.Invalidate();
            }
        }
        
        private void drawSingleDot(Color color, DataPoint point)
        {
            Series singleDot = new Series("Dot" + dotCount);
            singleDot.ChartType = SeriesChartType.Bubble;
            singleDot.MarkerStyle = MarkerStyle.Circle;
            singleDot.MarkerSize = 10;
            singleDot.Color = color;
            singleDot.Points.Add(point);
            chartStock.Series.Add(singleDot);
            dotCount++;
        }

        /// <summary>
        /// Draws single line
        /// </summary>
        private async void drawSingleLineAsync(MouseEventArgs e)
        {
            mousePosX = chartStock.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            mousePosY = chartStock.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y);

            currentPoint = new DataPoint(mousePosX, mousePosY);

            chartStock.Series.Add("Point_" + pointNr);
            chartStock.Series["Point_" + pointNr].Points.Add(currentPoint);
            chartStock.Series["Point_" + pointNr].ChartType = SeriesChartType.Point;
            chartStock.Series["Point_" + pointNr].Color = lineColor;

            if (pointNr % 2 == 0 && (currentPoint != null && lastPoint != null))
            {
                chartStock.Series.Add("Line" + pointNr);
                chartStock.Series["Line" + pointNr].Points.Add(lastPoint);
                chartStock.Series["Line" + pointNr].Points[0].MarkerSize = (int)(lineThickness * 2);
                chartStock.Series["Line" + pointNr].Points[0].MarkerStyle = MarkerStyle.Circle;
                chartStock.Series["Line" + pointNr].Points.Add(currentPoint);
                chartStock.Series["Line" + pointNr].Points[1].MarkerSize = (int)(lineThickness * 2);
                chartStock.Series["Line" + pointNr].Points[1].MarkerStyle = MarkerStyle.Circle;
                chartStock.Series["Line" + pointNr].ChartType = SeriesChartType.Line;
                chartStock.Series["Line" + pointNr].Color = lineColor;
                chartStock.Series["Line" + pointNr].BorderWidth = lineThickness;
                
                UserlineModel ulModel = new UserlineModel(stock, lineColor, lineThickness); 
                Task<UserLines> task = Task.Run(() => ulModel.insertUserline(lastPoint, currentPoint));
                var line = await task;

                if(line != null)
                {
                    chartStock.Series["Line" + pointNr].Tag = line;

                    createNewTrendlineToolStripMenuItem.Checked = false;
                    splitMain.Panel2Collapsed = true;
                    DrawingAllowed = false;
                    btnLineSubmitChanges.Visible = false;
                    resetAttributes();
                }


                getAllLinesAsync();
            }

            lastPoint = currentPoint;

            pointNr++;
        }

        /// <summary>
        /// Updates the combobox select 
        /// </summary>
        private async void getAllLinesAsync()
        {
            var model = new UserlineModel(stock);
            Task<List<UserLines>> task = Task.Run(() => model.getAllUserlines());
            var userlines = await task;
            this.userlines = userlines;
        }
        
        /// <summary>
        /// Sets the thickness of the line
        /// </summary>
        private void tbLineThickness_Scroll(object sender, EventArgs e)
        {
            lineThickness = tbLineThickness.Value;
            lblLineThickness.Text = "Breite : " + tbLineThickness.Value.ToString();

            if(selectedLine != null && selectedSeries != null)
            {
                selectedSeries.BorderWidth = lineThickness;
                selectedSeries.Points[0].MarkerSize = (int)(lineThickness * 2);
                selectedSeries.Points[1].MarkerSize = (int)(lineThickness * 2);
                chartStock.Invalidate();
            }
        }

        #endregion

        #region Menu

        /// <summary>
        /// Toggle Tooltip
        /// </summary>
        private void tooltipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tooltipToolStripMenuItem.Checked = !tooltipToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Toggle Crosshair
        /// </summary>
        private void crosshairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crosshairToolStripMenuItem.Checked = !crosshairToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Deletes all trend lines
        /// </summary>
        private void deleteLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            UserlineModel model = new UserlineModel(stock);
            model.deleteAllUserlines();
            refreshChartAsync(stock.symbol);
            pointNr = 1;
            lastPoint = null;
            resetAttributes();
        }

        /// <summary>
        /// Enables the painting
        /// </summary>
        private void createNewTrendlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTrendlineToolStripMenuItem.Checked = !createNewTrendlineToolStripMenuItem.Checked;
            splitMain.Panel2Collapsed = (createNewTrendlineToolStripMenuItem.Checked) ? false : true;
            DrawingAllowed = (createNewTrendlineToolStripMenuItem.Checked) ? true : false;
        }

        #endregion

        #region Buttons

        /// <summary>
        /// Updates selected user line asynchronously
        /// </summary>
        private async void btnLineSubmitChanges_Click(object sender, EventArgs e)
        {
            if(selectedLine != null)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Linie wird aktualisiert...");
                selectedLine.Thickness = (short)lineThickness;
                selectedLine.LineColor = ColorTranslator.ToHtml( lineColor );

                var model = new UserlineModel(stock); 
                Task task = Task.Run(() => model.updateUserline(selectedLine));
                await task;
                refreshChartAsync(stock.symbol);
                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
                btnLineSubmitChanges.Visible = false;
            }
            selectedLine = null;
        }

        /// <summary>
        /// Deletes selected user line asynchronously
        /// </summary>
        private async void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (selectedLine != null)
            {
                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Linie wird gelöscht...");
                var model = new UserlineModel(stock);
                Task task = Task.Run(() => model.deleteUserline(selectedLine));
                await task;
                refreshChartAsync(stock.symbol);
                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
                btnLineSubmitChanges.Visible = false;
            }
            selectedLine = null;
        }

        /// <summary>
        /// Deletes all lines drawn by the user
        /// </summary>
        private void btnLinesDeleteAll_Click(object sender, EventArgs e)
        {
            UserlineModel model = new UserlineModel(stock);
            model.deleteAllUserlines();
            refreshChartAsync(stock.symbol);
            pointNr = 1;
            lastPoint = null;
        }

        /// <summary>
        /// Sets the line color
        /// </summary>
        private void btnLinecolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialogLines.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnLinecolor.BackColor = colorDialogLines.Color;
                lineColor = colorDialogLines.Color;

                if (selectedLine != null && selectedSeries != null)
                {
                    selectedSeries.Color = lineColor;
                    chartStock.Invalidate();
                }
            }
        }

        /// <summary>
        /// Cancel click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            createNewTrendlineToolStripMenuItem.Checked = false;
            splitMain.Panel2Collapsed = true;
            DrawingAllowed = false;
            btnLineSubmitChanges.Visible = false;
            resetAttributes();
        }

        private void resetAttributes()
        {
            selectedSeries = null;
            selectedDot = null;
            selectedLine = null;
        }

        #endregion

    }
}
