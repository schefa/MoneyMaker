namespace MoneyMaker
{
    partial class FrmMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Knoten2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.navigationTree = new System.Windows.Forms.TreeView();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbxCurrentUser = new System.Windows.Forms.ComboBox();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSettingsLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLegalLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripManager = new System.Windows.Forms.ToolStripDropDownButton();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMainTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 50);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainerMain.Panel1.Controls.Add(this.navigationTree);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Panel2MinSize = 400;
            this.splitContainerMain.Size = new System.Drawing.Size(984, 547);
            this.splitContainerMain.SplitterDistance = 216;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 0;
            // 
            // navigationTree
            // 
            this.navigationTree.AllowDrop = true;
            this.navigationTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationTree.BackColor = System.Drawing.SystemColors.Menu;
            this.navigationTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.navigationTree.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationTree.ForeColor = System.Drawing.SystemColors.MenuText;
            this.navigationTree.ItemHeight = 32;
            this.navigationTree.LineColor = System.Drawing.Color.White;
            this.navigationTree.Location = new System.Drawing.Point(6, 11);
            this.navigationTree.Margin = new System.Windows.Forms.Padding(6);
            this.navigationTree.MinimumSize = new System.Drawing.Size(150, 400);
            this.navigationTree.Name = "navigationTree";
            treeNode1.Name = "Knoten1";
            treeNode1.Text = "Knoten1";
            treeNode2.Name = "Knoten0";
            treeNode2.Text = "Knoten0";
            treeNode3.Name = "Knoten2";
            treeNode3.Text = "Knoten2";
            this.navigationTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.navigationTree.ShowLines = false;
            this.navigationTree.Size = new System.Drawing.Size(205, 529);
            this.navigationTree.TabIndex = 2;
            this.navigationTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navigationTree_MouseClick);
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.panelTop);
            this.splitContainerRight.Panel1MinSize = 50;
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.panelView);
            this.splitContainerRight.Size = new System.Drawing.Size(765, 547);
            this.splitContainerRight.SplitterDistance = 51;
            this.splitContainerRight.SplitterWidth = 3;
            this.splitContainerRight.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Controls.Add(this.cbxCurrentUser);
            this.panelTop.Controls.Add(this.lblHeadLine);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(765, 51);
            this.panelTop.TabIndex = 8;
            // 
            // cbxCurrentUser
            // 
            this.cbxCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCurrentUser.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCurrentUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrentUser.FormattingEnabled = true;
            this.cbxCurrentUser.Location = new System.Drawing.Point(610, 11);
            this.cbxCurrentUser.Margin = new System.Windows.Forms.Padding(0);
            this.cbxCurrentUser.Name = "cbxCurrentUser";
            this.cbxCurrentUser.Size = new System.Drawing.Size(141, 25);
            this.cbxCurrentUser.TabIndex = 6;
            this.frmMainTooltip.SetToolTip(this.cbxCurrentUser, "Aktuelles Nutzerprofil");
            this.cbxCurrentUser.SelectedIndexChanged += new System.EventHandler(this.cbxCurrentUser_SelectedIndexChanged);
            this.cbxCurrentUser.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbxCurrentUser_Format);
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadLine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeadLine.Location = new System.Drawing.Point(15, 11);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(102, 24);
            this.lblHeadLine.TabIndex = 7;
            this.lblHeadLine.Text = "Dashboard";
            // 
            // panelView
            // 
            this.panelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelView.BackColor = System.Drawing.SystemColors.Window;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(763, 494);
            this.panelView.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel1,
            this.statusSettingsLink,
            this.statusLegalLink,
            this.statusStripManager});
            this.statusStrip.Location = new System.Drawing.Point(0, 546);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 21);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Bereit";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 16);
            this.statusLabel.Text = "Bereit";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // statusSettingsLink
            // 
            this.statusSettingsLink.ActiveLinkColor = System.Drawing.Color.LightBlue;
            this.statusSettingsLink.IsLink = true;
            this.statusSettingsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.statusSettingsLink.LinkColor = System.Drawing.SystemColors.Window;
            this.statusSettingsLink.Name = "statusSettingsLink";
            this.statusSettingsLink.Size = new System.Drawing.Size(772, 16);
            this.statusSettingsLink.Spring = true;
            this.statusSettingsLink.Text = "Einstellungen";
            this.statusSettingsLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusSettingsLink.Click += new System.EventHandler(this.statusSettings_Click);
            // 
            // statusLegalLink
            // 
            this.statusLegalLink.ActiveLinkColor = System.Drawing.Color.LightBlue;
            this.statusLegalLink.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.statusLegalLink.IsLink = true;
            this.statusLegalLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.statusLegalLink.LinkColor = System.Drawing.Color.White;
            this.statusLegalLink.Name = "statusLegalLink";
            this.statusLegalLink.Size = new System.Drawing.Size(71, 16);
            this.statusLegalLink.Text = "Rechtliches";
            this.statusLegalLink.Click += new System.EventHandler(this.statusLegalLink_Click);
            // 
            // statusStripManager
            // 
            this.statusStripManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.statusStripManager.ForeColor = System.Drawing.SystemColors.Window;
            this.statusStripManager.Image = global::MoneyMaker.Properties.Resources.UserProfilesIcon95;
            this.statusStripManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusStripManager.Name = "statusStripManager";
            this.statusStripManager.Size = new System.Drawing.Size(87, 19);
            this.statusStripManager.Text = "Manager";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.logoutToolStripMenuItem.Text = "Abmelden";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmMainTooltip
            // 
            this.frmMainTooltip.AutoPopDelay = 5000;
            this.frmMainTooltip.InitialDelay = 200;
            this.frmMainTooltip.ReshowDelay = 100;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MoneyMaker";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmMain_HelpRequested);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.TreeView navigationTree;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ComboBox cbxCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusSettingsLink;
        private System.Windows.Forms.ToolStripStatusLabel statusLegalLink;
        private System.Windows.Forms.ToolStripDropDownButton statusStripManager;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolTip frmMainTooltip;
    }
}

