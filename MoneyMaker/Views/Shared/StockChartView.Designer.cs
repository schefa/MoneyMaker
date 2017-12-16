namespace MoneyMaker.Views
{
    partial class StockChartView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuChart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tooltipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crosshairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zWNJToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.createNewTrendlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogLines = new System.Windows.Forms.ColorDialog();
            this.btnLinecolor = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.gbLineDetails = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLineSubmitChanges = new System.Windows.Forms.Button();
            this.lblLineThickness = new System.Windows.Forms.Label();
            this.tbLineThickness = new System.Windows.Forms.TrackBar();
            this.lblLineColorSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.menuChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.gbLineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStock
            // 
            this.chartStock.BackColor = System.Drawing.SystemColors.Window;
            this.chartStock.BorderlineColor = System.Drawing.Color.Empty;
            this.chartStock.BorderSkin.BorderColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.Name = "Prices";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 60F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 90F;
            chartArea2.InnerPlotPosition.Width = 90F;
            chartArea2.InnerPlotPosition.X = 10F;
            chartArea2.InnerPlotPosition.Y = 3F;
            chartArea2.Name = "Volumes";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 30F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 65F;
            this.chartStock.ChartAreas.Add(chartArea1);
            this.chartStock.ChartAreas.Add(chartArea2);
            this.chartStock.ContextMenuStrip = this.menuChart;
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStock.Location = new System.Drawing.Point(0, 0);
            this.chartStock.Name = "chartStock";
            series1.ChartArea = "Prices";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "Volumes";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartStock.Series.Add(series1);
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(401, 507);
            this.chartStock.TabIndex = 9;
            this.chartStock.Text = "Chart";
            this.chartStock.Paint += new System.Windows.Forms.PaintEventHandler(this.chartStock_Paint);
            this.chartStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartStock_MouseDown);
            this.chartStock.MouseLeave += new System.EventHandler(this.chartStock_MouseLeave);
            this.chartStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chartStock_MouseUp);
            // 
            // menuChart
            // 
            this.menuChart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltipToolStripMenuItem,
            this.crosshairToolStripMenuItem,
            this.zWNJToolStripMenuItem,
            this.createNewTrendlineToolStripMenuItem,
            this.deleteLinesToolStripMenuItem});
            this.menuChart.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuChart.Name = "menuChart";
            this.menuChart.Size = new System.Drawing.Size(208, 98);
            // 
            // tooltipToolStripMenuItem
            // 
            this.tooltipToolStripMenuItem.Checked = true;
            this.tooltipToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tooltipToolStripMenuItem.Name = "tooltipToolStripMenuItem";
            this.tooltipToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tooltipToolStripMenuItem.Text = "Tooltip";
            this.tooltipToolStripMenuItem.Click += new System.EventHandler(this.tooltipToolStripMenuItem_Click);
            // 
            // crosshairToolStripMenuItem
            // 
            this.crosshairToolStripMenuItem.Checked = true;
            this.crosshairToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crosshairToolStripMenuItem.Name = "crosshairToolStripMenuItem";
            this.crosshairToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.crosshairToolStripMenuItem.Text = "Crosshair";
            this.crosshairToolStripMenuItem.Click += new System.EventHandler(this.crosshairToolStripMenuItem_Click);
            // 
            // zWNJToolStripMenuItem
            // 
            this.zWNJToolStripMenuItem.Name = "zWNJToolStripMenuItem";
            this.zWNJToolStripMenuItem.Size = new System.Drawing.Size(204, 6);
            // 
            // createNewTrendlineToolStripMenuItem
            // 
            this.createNewTrendlineToolStripMenuItem.Name = "createNewTrendlineToolStripMenuItem";
            this.createNewTrendlineToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.createNewTrendlineToolStripMenuItem.Text = "Neue Trendlinie zeichnen";
            this.createNewTrendlineToolStripMenuItem.Click += new System.EventHandler(this.createNewTrendlineToolStripMenuItem_Click);
            // 
            // deleteLinesToolStripMenuItem
            // 
            this.deleteLinesToolStripMenuItem.Name = "deleteLinesToolStripMenuItem";
            this.deleteLinesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteLinesToolStripMenuItem.Text = "Alle Linien löschen";
            this.deleteLinesToolStripMenuItem.Click += new System.EventHandler(this.deleteLinesToolStripMenuItem_Click);
            // 
            // btnLinecolor
            // 
            this.btnLinecolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLinecolor.BackColor = System.Drawing.Color.Gray;
            this.btnLinecolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinecolor.Location = new System.Drawing.Point(9, 28);
            this.btnLinecolor.Name = "btnLinecolor";
            this.btnLinecolor.Size = new System.Drawing.Size(53, 25);
            this.btnLinecolor.TabIndex = 1;
            this.btnLinecolor.UseVisualStyleBackColor = false;
            this.btnLinecolor.Click += new System.EventHandler(this.btnLinecolor_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLine.Location = new System.Drawing.Point(11, 157);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(157, 27);
            this.btnDeleteLine.TabIndex = 2;
            this.btnDeleteLine.Text = "Linie löschen";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Visible = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.chartStock);
            this.splitMain.Panel1MinSize = 200;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitMain.Panel2.Controls.Add(this.gbLineDetails);
            this.splitMain.Panel2MinSize = 180;
            this.splitMain.Size = new System.Drawing.Size(590, 507);
            this.splitMain.SplitterDistance = 401;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 11;
            // 
            // gbLineDetails
            // 
            this.gbLineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLineDetails.Controls.Add(this.btnCancel);
            this.gbLineDetails.Controls.Add(this.btnLineSubmitChanges);
            this.gbLineDetails.Controls.Add(this.lblLineThickness);
            this.gbLineDetails.Controls.Add(this.tbLineThickness);
            this.gbLineDetails.Controls.Add(this.lblLineColorSelect);
            this.gbLineDetails.Controls.Add(this.btnLinecolor);
            this.gbLineDetails.Controls.Add(this.btnDeleteLine);
            this.gbLineDetails.Location = new System.Drawing.Point(5, 8);
            this.gbLineDetails.Name = "gbLineDetails";
            this.gbLineDetails.Size = new System.Drawing.Size(181, 226);
            this.gbLineDetails.TabIndex = 3;
            this.gbLineDetails.TabStop = false;
            this.gbLineDetails.Text = "Linie zeichnen";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(11, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLineSubmitChanges
            // 
            this.btnLineSubmitChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLineSubmitChanges.Location = new System.Drawing.Point(11, 124);
            this.btnLineSubmitChanges.Name = "btnLineSubmitChanges";
            this.btnLineSubmitChanges.Size = new System.Drawing.Size(157, 27);
            this.btnLineSubmitChanges.TabIndex = 6;
            this.btnLineSubmitChanges.Text = "Speichern";
            this.btnLineSubmitChanges.UseVisualStyleBackColor = true;
            this.btnLineSubmitChanges.Visible = false;
            this.btnLineSubmitChanges.Click += new System.EventHandler(this.btnLineSubmitChanges_Click);
            // 
            // lblLineThickness
            // 
            this.lblLineThickness.AutoSize = true;
            this.lblLineThickness.Location = new System.Drawing.Point(17, 65);
            this.lblLineThickness.Name = "lblLineThickness";
            this.lblLineThickness.Size = new System.Drawing.Size(52, 15);
            this.lblLineThickness.TabIndex = 5;
            this.lblLineThickness.Text = "Breite : 1";
            // 
            // tbLineThickness
            // 
            this.tbLineThickness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLineThickness.Location = new System.Drawing.Point(10, 83);
            this.tbLineThickness.Minimum = 1;
            this.tbLineThickness.Name = "tbLineThickness";
            this.tbLineThickness.Size = new System.Drawing.Size(159, 45);
            this.tbLineThickness.TabIndex = 4;
            this.tbLineThickness.Value = 1;
            this.tbLineThickness.Scroll += new System.EventHandler(this.tbLineThickness_Scroll);
            // 
            // lblLineColorSelect
            // 
            this.lblLineColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLineColorSelect.AutoSize = true;
            this.lblLineColorSelect.Location = new System.Drawing.Point(72, 33);
            this.lblLineColorSelect.Name = "lblLineColorSelect";
            this.lblLineColorSelect.Size = new System.Drawing.Size(95, 15);
            this.lblLineColorSelect.TabIndex = 3;
            this.lblLineColorSelect.Text = "Farbe auswählen";
            // 
            // StockChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockChartView";
            this.Size = new System.Drawing.Size(590, 507);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.menuChart.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.gbLineDetails.ResumeLayout(false);
            this.gbLineDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.ColorDialog colorDialogLines;
        private System.Windows.Forms.Button btnLinecolor;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox gbLineDetails;
        private System.Windows.Forms.Label lblLineThickness;
        private System.Windows.Forms.TrackBar tbLineThickness;
        private System.Windows.Forms.Label lblLineColorSelect;
        private System.Windows.Forms.Button btnLineSubmitChanges;
        private System.Windows.Forms.ToolStripMenuItem crosshairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuChart;
        private System.Windows.Forms.ToolStripMenuItem tooltipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator zWNJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewTrendlineToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}
