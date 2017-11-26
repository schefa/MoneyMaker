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
        private UserProfile user;
        public UserProfile User
        {
            get { return user; }
            private set { user = value; }
        }

        private ManagerProfile managerProfile;
        public ManagerProfile ManagerProfile
        {
            get { return managerProfile; }
            private set { managerProfile = value; }
        }

        private static FrmMain current = null;
        public static FrmMain Current
        {
            get { return current; }
        }

        private bool isLocal = false;
        public bool IsLocal
        {
            get { return isLocal; }
        }      

        #endregion

        public FrmMain(ManagerProfile managerProfile = null)
        {
            InitializeComponent();
            
            Application.ApplicationExit += new EventHandler(this.onApplicationExit);

            // sets the current
            if (current == null)
            {
                current = this;
                panelView.Controls.Add(NavigationFactory.create(NavigationType.Dashboard));
            }

            if (managerProfile != null)
            {
                // Server
                ManagerProfile = managerProfile;
                statusStripManager.Text = ManagerProfile.UserName;
            }
            else
            {
                // Local manager
                ManagerProfile = ManagerModel.getInstance().getDefaultManager();
                statusStripManager.Visible = false;
                isLocal = true;
            }

            // Get current user
            User = (ManagerProfile != null) ? new UserProfileModel().getItem(ManagerProfile.AccountID) : null;

            // Sets the icon
            Icon = Properties.Resources.LogoIcon;
            
            createNavigationTree();
            createUserSelectBoxAsync();

        }

        /// <summary>
        /// Stops and deletes the instance of LocalDB when the application is closed 
        /// </summary>
        private void onApplicationExit(object sender, EventArgs e)
        {
            String moneyMakerProcess = Process.GetCurrentProcess().ProcessName;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            // Checking if local server instance was selected, and there ain't more than one MoneyMaker process opened
            if (connectionString.Contains("LocalDB") && !(Process.GetProcesses().Count(p => p.ProcessName == moneyMakerProcess) > 1))
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

        #region User selection
        /// <summary>
        /// ComboBox to change the current user
        /// </summary>
        public async void createUserSelectBoxAsync(bool setSelected = true)
        {
            notifyUser(NotifyType.PrepareMessage, "User werden geladen...");

            var userModel = new UserProfileModel();
            cbxCurrentUser.Items.Clear();

            IQueryable<UserProfile> collection = null;
            if (ManagerProfile != null)
            {
                Task<IQueryable<UserProfile>> task = Task.Run(() => userModel.getItems(ManagerProfile.AccountID));
                collection = await task;

                if (collection != null)
                {
                    cbxCurrentUser.DisplayMember = "LastName";
                    foreach (var item in collection)
                    { 
                        cbxCurrentUser.Items.Add(item);
                    }
                    if(setSelected)
                        cbxCurrentUser.SelectedIndex = 0;
                }
                else
                {
                    cbxCurrentUser.Items.Add("Keine Benutzerprofile angelegt!");
                    cbxCurrentUser.SelectedIndex = 0;
                }
            }

            notifyUser(NotifyType.StatusMessage, "Bereit");
        }

        /// <summary>
        /// Sets the combobox format
        /// </summary>
        private void cbxCurrentUser_Format(object sender, ListControlConvertEventArgs e)
        {
            // Assuming your class called Employee , and Firstname & Lastname are the fields
            var user = (e.ListItem as UserProfile);
            if (user != null)
            {
                string lastname = ((UserProfile)e.ListItem).ForName;
                string firstname = ((UserProfile)e.ListItem).LastName;
                e.Value = lastname + " " + firstname;
            }
        }

        /// <summary>
        /// Method fired after current user was changed
        /// </summary> 
        private void cbxCurrentUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            User = cbxCurrentUser.SelectedItem as UserProfile;
            if(User != null)
            {
                navigate(new NavigationItem() { View = NavigationType.Dashboard });
                createNavigationTree();
            }
        }

        public void setUser(UserProfile user)
        {
            for (int i = 0; i < cbxCurrentUser.Items.Count; i++)
            {
                var tmp = (cbxCurrentUser.Items[i] as UserProfile);
                if (tmp.UserID == user.UserID)
                {
                    cbxCurrentUser.SelectedIndex = i;
                }
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Builds the navigation items with Factory pattern
        /// </summary>
        private void createNavigationTree()
        { 
            navigationTree.Nodes.Clear();
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Dashboard", View = NavigationType.Dashboard });
            navigationTree.Nodes.Add(new NavigationItem() { Text = "Benutzerprofile", View = NavigationType.UserProfiles });

            navigationTree.Nodes.Add("Investierung");
            if (User?.UserID > 0)
            {
                navigationTree.Nodes[2].Nodes.Add(new NavigationItem() { Text = "Watchlists", View = NavigationType.Watchlists });
                navigationTree.Nodes[2].Nodes.Add(new NavigationItem() { Text = "Bank", View = NavigationType.BankAccount });
                navigationTree.Nodes[2].Nodes.Add(new NavigationItem() { Text = "Depot", View = NavigationType.Depot });
            }
            else
            {
                navigationTree.Nodes[2].Nodes.Add("Legen Sie ein\nNutzerprofil an");
                navigationTree.Nodes[2].Nodes[0].NodeFont = new Font("Segoe UI", 8);
            }

            navigationTree.Nodes.Add("Finanzierung");
            navigationTree.Nodes[3].Nodes.Add(new NavigationItem() { Text = "Kreditrechner", View = NavigationType.LoanCalculator });
            navigationTree.Nodes[3].Nodes.Add(new NavigationItem() { Text = "Leasingrechner", View = NavigationType.LeasingCalculator });
            navigationTree.Nodes[3].Nodes.Add(new NavigationItem() { Text = "Tilgungsrechner", View = NavigationType.RedemptionCalculator });
            navigationTree.Nodes[3].Nodes.Add(new NavigationItem() { Text = "Währungsrechner", View = NavigationType.CurrencyCalculator });

            createNavigationTreeSubItems();
            navigationTree.ExpandAll();
        }

        /// <summary>
        /// Async method to get the subitems from database and put them in the navigation tree
        /// </summary>
        public async void createNavigationTreeSubItems()
        {
            if(User != null)
            {
                notifyUser(NotifyType.PrepareMessage, "Watchlists werden geladen...");
                var wlModel = new WatchlistsModel();
                Task<List<WatchListViewItem>> task = Task.Run(() => wlModel.getWatchlists(User.UserID));
                var watchlistItems = await task;

                navigationTree.Nodes[2].Nodes[0].Nodes.Clear();
                foreach (var watchlist in watchlistItems)
                {
                    navigationTree.Nodes[2].Nodes[0].Nodes.Add(new NavigationItem() {
                        Text = watchlist.Name,
                        Parameters = new NavigationParams() { Watchlist = watchlist.Watchlist },
                        View = NavigationType.Watchlist
                    });
                }
                navigationTree.Nodes[2].Nodes[0].ExpandAll();
                notifyUser(NotifyType.StatusMessage, "Bereit");
            }

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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmMain = new FrmLogin();
            frmMain.ShowDialog();
            this.Close();
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
