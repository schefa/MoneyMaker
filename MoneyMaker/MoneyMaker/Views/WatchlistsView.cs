using MoneyMaker.Models.Database;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMaker.Views
{
    public partial class WatchlistsView : MoneyMakerView
    {
        private WatchlistsModel model = new WatchlistsModel();
        private WatchList selected;
        private UserProfile user;

        public WatchlistsView()
        {
            InitializeComponent();
            this.user = mainForm.User;
            if(user != null)
            { 
                refreshWatchlistsAsync();
            }
            splitContainerMain.Panel2Collapsed = true;
            mainForm.setHeadline("Watchlists");
        }

        private async void refreshWatchlistsAsync()
        {
            mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Lädt watchlists...");

            lvWatchlists.Items.Clear();
            Task<List<WatchListViewItem>> task = Task.Run(() => model.getWatchlists(user.UserID));
            var list = await task;
            foreach (var item in list)
            { 
                var lvItem = new ListViewItem(item.ToStringArray());
                lvItem.Tag = item.Watchlist;
                lvWatchlists.Items.Add(lvItem);
            }

            mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
        }
        
        private void lvWatchlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (lvWatchlists.SelectedItems.Count > 0) ? (WatchList)lvWatchlists.SelectedItems[0].Tag : null;
            if(selected != null)
            {
                splitContainerMain.Panel2Collapsed = false;
                tbName.Text = selected.Name;
                btnDeleteWatchlist.Enabled = true;
            }
            else
            {
                btnDeleteWatchlist.Enabled = false;
            }
        }

        private void btnAddWatchlist_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = false;
            btnAddWatchlist.Visible = false;
            btnDeleteWatchlist.Visible = false;
            tbName.Text = "";
            selected = null;
        }

        private void btnDeleteWatchlist_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvWatchlists.Items)
            {
                if(item.Selected)
                {
                    lvWatchlists.Items.Remove(item);
                    WatchList wl = (WatchList)item.Tag;
                    model.deleteWatchlist(wl.WatchListID);
                    refreshWatchlistsAsync();
                    closeRightForm();
                }
            }
            mainForm.createNavigationTreeSubItems();
        }

        private void closeRightForm()
        {
            splitContainerMain.Panel2Collapsed = true;
            btnAddWatchlist.Visible = true;
            btnDeleteWatchlist.Visible = true;
            selected = null;
        }

        private void btnSaveWatchlist_Click(object sender, EventArgs e)
        {  
            if(selected != null)
            { 
                selected.Name = tbName.Text;
                model.updateWatchlist(selected);
                closeRightForm();
            }
            else
            {
                if(tbName.Text.Length > 0)
                {

                    model.saveWatchlist(new WatchList() { Name = tbName.Text, UserID = user.UserID });
                    mainForm.createNavigationTreeSubItems();
                    closeRightForm();
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie einen Namen für die Watchlist ein.");
                }
            }
            refreshWatchlistsAsync();
            mainForm.createNavigationTreeSubItems();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeRightForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            refreshWatchlistsAsync();
        }

        private void lvWatchlists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mousePos = lvWatchlists.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = lvWatchlists.HitTest(mousePos);

            var firstSelected = hitTest.Item;
            if (firstSelected?.Tag != null)
            {
                var selectedWatchlist = (WatchList)firstSelected.Tag;
                Parent.Controls.Add(NavigationFactory.create(NavigationType.Watchlist, new NavigationParams() { Watchlist = selectedWatchlist }));
                Parent.Controls.Remove(this);
            }
        }
    }
}
