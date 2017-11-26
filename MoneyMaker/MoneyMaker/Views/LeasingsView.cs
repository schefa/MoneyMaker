using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;

namespace MoneyMaker.Views
{
    public partial class LeasingsView : MoneyMakerView
    {
        LeasingModel model;

        public LeasingsView()
        {
            InitializeComponent();
            mainForm.setHeadline("Leasing");

            model = new LeasingModel(mainForm.User);
            fillListViewWithItemsAsync();
        }

        private async void fillListViewWithItemsAsync()
        {
            listItems.Items.Clear();
            Task<List<LeasingData>> task = Task.Run(() => model.getItems());
            var loanItems = await task;
            if (loanItems != null)
            {
                foreach (var loanItem in loanItems)
                {
                    string[] lvItemDisplay = { loanItem.leasingName, loanItem.created.ToString() };
                    ListViewItem lvItem = new ListViewItem(lvItemDisplay);
                    lvItem.Tag = loanItem;
                    listItems.Items.Add(lvItem);
                }
            }
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.Leasings));
            Parent.Controls.Remove(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItems != null)
            {
                foreach (ListViewItem loan in listItems.SelectedItems)
                {
                    var item = (LeasingData)loan.Tag;
                    model.deleteItem(item.LeasingID);
                    fillListViewWithItemsAsync();
                }
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItems != null)
            {
                btnDelete.Enabled = true;
            }
        }

        private void listItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mousePos = listItems.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = listItems.HitTest(mousePos);

            var firstSelected = hitTest.Item;
            if (firstSelected?.Tag != null)
            {
                var selectedCalculator = (LeasingData)firstSelected.Tag;
                var view = new LeasingCalculatorView(selectedCalculator);
                view.Dock = DockStyle.Fill;
                Parent.Controls.Add(view);
                Parent.Controls.Remove(this);
            }
        }
    }
}
