namespace MoneyMaker.Views
{
    partial class WatchlistsView
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddWatchlist = new System.Windows.Forms.Button();
            this.btnDeleteWatchlist = new System.Windows.Forms.Button();
            this.lvWatchlists = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxDetails = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSaveWatchlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.gboxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainerMain.Panel2.Controls.Add(this.gboxDetails);
            this.splitContainerMain.Panel2MinSize = 300;
            this.splitContainerMain.Size = new System.Drawing.Size(847, 498);
            this.splitContainerMain.SplitterDistance = 543;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 2;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.panelTop);
            this.splitContainerLeft.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerLeft.Panel1MinSize = 40;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.lvWatchlists);
            this.splitContainerLeft.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerLeft.Panel2MinSize = 100;
            this.splitContainerLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerLeft.Size = new System.Drawing.Size(543, 498);
            this.splitContainerLeft.SplitterDistance = 49;
            this.splitContainerLeft.SplitterWidth = 3;
            this.splitContainerLeft.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.btnUpdate);
            this.panelTop.Controls.Add(this.btnAddWatchlist);
            this.panelTop.Controls.Add(this.btnDeleteWatchlist);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(543, 49);
            this.panelTop.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(433, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Aktualisieren";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddWatchlist
            // 
            this.btnAddWatchlist.Location = new System.Drawing.Point(4, 7);
            this.btnAddWatchlist.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWatchlist.Name = "btnAddWatchlist";
            this.btnAddWatchlist.Size = new System.Drawing.Size(63, 30);
            this.btnAddWatchlist.TabIndex = 1;
            this.btnAddWatchlist.Text = "neu";
            this.btnAddWatchlist.UseVisualStyleBackColor = true;
            this.btnAddWatchlist.Click += new System.EventHandler(this.btnAddWatchlist_Click);
            // 
            // btnDeleteWatchlist
            // 
            this.btnDeleteWatchlist.Enabled = false;
            this.btnDeleteWatchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWatchlist.Location = new System.Drawing.Point(75, 8);
            this.btnDeleteWatchlist.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteWatchlist.Name = "btnDeleteWatchlist";
            this.btnDeleteWatchlist.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteWatchlist.TabIndex = 2;
            this.btnDeleteWatchlist.Text = "löschen";
            this.btnDeleteWatchlist.UseVisualStyleBackColor = true;
            this.btnDeleteWatchlist.Click += new System.EventHandler(this.btnDeleteWatchlist_Click);
            // 
            // lvWatchlists
            // 
            this.lvWatchlists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWatchlists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colStockCount});
            this.lvWatchlists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWatchlists.FullRowSelect = true;
            this.lvWatchlists.Location = new System.Drawing.Point(0, 0);
            this.lvWatchlists.Margin = new System.Windows.Forms.Padding(4);
            this.lvWatchlists.MultiSelect = false;
            this.lvWatchlists.Name = "lvWatchlists";
            this.lvWatchlists.Size = new System.Drawing.Size(543, 446);
            this.lvWatchlists.TabIndex = 2;
            this.lvWatchlists.UseCompatibleStateImageBehavior = false;
            this.lvWatchlists.View = System.Windows.Forms.View.Details;
            this.lvWatchlists.SelectedIndexChanged += new System.EventHandler(this.lvWatchlists_SelectedIndexChanged);
            this.lvWatchlists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvWatchlists_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 123;
            // 
            // colStockCount
            // 
            this.colStockCount.Text = "Anzahl Aktien";
            this.colStockCount.Width = 133;
            // 
            // gboxDetails
            // 
            this.gboxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDetails.Controls.Add(this.btnClose);
            this.gboxDetails.Controls.Add(this.tbName);
            this.gboxDetails.Controls.Add(this.btnSaveWatchlist);
            this.gboxDetails.Location = new System.Drawing.Point(14, 13);
            this.gboxDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gboxDetails.Name = "gboxDetails";
            this.gboxDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gboxDetails.Size = new System.Drawing.Size(278, 135);
            this.gboxDetails.TabIndex = 0;
            this.gboxDetails.TabStop = false;
            this.gboxDetails.Text = "Details";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(165, 85);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(22, 46);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(231, 24);
            this.tbName.TabIndex = 1;
            // 
            // btnSaveWatchlist
            // 
            this.btnSaveWatchlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveWatchlist.Location = new System.Drawing.Point(20, 85);
            this.btnSaveWatchlist.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveWatchlist.Name = "btnSaveWatchlist";
            this.btnSaveWatchlist.Size = new System.Drawing.Size(137, 30);
            this.btnSaveWatchlist.TabIndex = 0;
            this.btnSaveWatchlist.Text = "Speichern";
            this.btnSaveWatchlist.UseVisualStyleBackColor = true;
            this.btnSaveWatchlist.Click += new System.EventHandler(this.btnSaveWatchlist_Click);
            // 
            // WatchlistsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WatchlistsView";
            this.Size = new System.Drawing.Size(847, 498);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.gboxDetails.ResumeLayout(false);
            this.gboxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListView lvWatchlists;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Button btnDeleteWatchlist;
        private System.Windows.Forms.Button btnAddWatchlist;
        private System.Windows.Forms.GroupBox gboxDetails;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSaveWatchlist;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colStockCount;
    }
}
