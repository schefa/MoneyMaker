using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Navigation;
using System.Diagnostics;
using System.Configuration;

namespace MoneyMaker
{
    public partial class FrmMain : Form
    {

        #region Attributes

        private static FrmMain current = null;
        public static FrmMain Current
        {
            get { return current; }
        }

        #endregion

        public FrmMain()
        {
            InitializeComponent();
            
            Application.ApplicationExit += new EventHandler(this.onApplicationExit);

            // sets the current
            if (current == null)
            {
                current = this;
                panelView.Controls.Add(NavigationFactory.create(NavigationType.Dashboard));
            }
             
            // Local manager
            statusStripManager.Visible = false; 
            
            // Sets the icon
            Icon = Properties.Resources.LogoIcon;
            
            createNavigationTree();
        }

        /// <summary>
        /// Stops and deletes the instance of LocalDB when the application is closed 
        /// </summary>
        private void onApplicationExit(object sender, EventArgs e)
        {
            String moneyMakerProcess = Process.GetCurrentProcess().ProcessName;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            // Checking if local server instance was selected, and there ain't more than one MoneyMaker process opened
            if (!(Process.GetProcesses().Count(p => p.ProcessName == moneyMakerProcess) > 1))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "sqllocaldb.exe";

                startInfo.Arguments = "stop MoneyMaker";
                Process.Start(startInfo);

                startInfo.Arguments = "delete MoneyMaker";
                Process.Start(startInfo);
            }
        }

        /// <summary>
        /// Sets the Headline
        /// </summary>
        public void setHeadline(string text = "")
        {
            lblHeadLine.Text = text;
            this.Text = "MoneyMaker - " + text;
        }

        #region Navigation
        /// <summary>
        /// Builds the navigation items with Factory pattern
        /// </summary>
        private void createNavigationTree()
        { 
            navigationTree.Nodes.Clear();
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Dashboard", View = NavigationType.Dashboard });
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Bank", View = NavigationType.BankAccount });            
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Watchlists", View = NavigationType.Watchlists });
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Depot", View = NavigationType.Depot });
            
            createNavigationTreeSubItems();
            navigationTree.ExpandAll();
        }

        /// <summary>
        /// Async method to get the subitems from database and put them in the navigation tree
        /// </summary>
        public async void createNavigationTreeSubItems()
        { 
            notifyUser(NotifyType.PrepareMessage, "Watchlists werden geladen...");
            var wlModel = new WatchlistsModel();
            Task<List<WatchListViewItem>> task = Task.Run(() => wlModel.getWatchlists());
            var watchlistItems = await task;

            navigationTree.Nodes[2].Nodes.Clear();
            foreach (var watchlist in watchlistItems)
            {
                navigationTree.Nodes[2].Nodes.Add(new NavigationItem() {
                    Text = watchlist.Name,
                    Parameters = new NavigationParams() { Watchlist = watchlist.Watchlist },
                    View = NavigationType.Watchlist
                });
            }
            navigationTree.Nodes[2].ExpandAll();
            notifyUser(NotifyType.StatusMessage, "Bereit");
            
        }
        
        /// <summary>
        /// Handles the click event on a navigation item, which changes the view
        /// </summary>
        private void navigationTree_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePos = navigationTree.PointToClient(Control.MousePosition);
                TreeViewHitTestInfo hitTest = navigationTree.HitTest(mousePos);
                 
                NavigationItem navItem = hitTest.Node as NavigationItem;
                if (navItem != null)
                {
                    navigate(navItem);
                }
            }
        }

        private void statusSettings_Click(object sender, EventArgs e)
        {
            navigate(new NavigationItem() { Text = "Einstellungen", View = NavigationType.Settings });
        }

        private void statusLegalLink_Click(object sender, EventArgs e)
        {
            navigate(new NavigationItem() { Text = "Rechtliches", View = NavigationType.Legal });
        }

        private void navigate(NavigationItem navItem)
        {
            panelView.Controls.Clear();
            var view = NavigationFactory.create(navItem.View, navItem.Parameters);
            panelView.Controls.Add(view);
        }

        #endregion
        
        #region Status Messages
        public void notifyUser(NotifyType type, string strMessage = "")
        {
            switch (type)
            {
                case NotifyType.StatusMessage:
                    statusStrip.BackColor = Color.SteelBlue;
                    strMessage = (strMessage.Length > 0) ? strMessage : "Bereit";
                    this.Cursor = Cursors.Default;
                    break;
                case NotifyType.PrepareMessage:
                    statusStrip.BackColor = Color.OrangeRed;
                    this.Cursor = Cursors.WaitCursor;
                    break;
                case NotifyType.ErrorMessage:
                    statusStrip.BackColor = Color.Red;
                    break;
            }

            statusLabel.ForeColor = Color.White;
            statusLabel.Text = strMessage;
        }

        public enum NotifyType
        {
            StatusMessage,
            PrepareMessage,
            ErrorMessage
        }
        #endregion

        #region TreeView Arrows
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetTreeViewTheme(navigationTree.Handle);
        }

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        public static void SetTreeViewTheme(IntPtr treeHandle)
        {
            SetWindowTheme(treeHandle, "explorer", null);
        }

        #endregion

        #region Guide
        private void FrmMain_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            showHelpFrmGuide();
        }

        private void FrmMain_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            showHelpFrmGuide();
        }

        private void showHelpFrmGuide()
        {
            FrmGuide frmGuide = FrmGuide.getInstance();
            if (!frmGuide.IsDisposed)
                frmGuide.Show();                 
        }
        #endregion

    }
}
