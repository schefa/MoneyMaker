using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.Models;
using MoneyMaker.ViewModels;

namespace MoneyMaker.Views
{
    public partial class RedemptionsView : MoneyMakerView
    { 
        private RedemptionModel model;

        public RedemptionsView()
        {
            InitializeComponent();

            mainForm.setHeadline("Meine Tilgungskredite");

            model = new RedemptionModel(mainForm.User);
            fillListViewWithItemsAsync();
        }


        private async void fillListViewWithItemsAsync()
        {
            listItems.Items.Clear();
            Task<List<RedemptionData>> task = Task.Run(() => model.getItems());
            var items = await task;
            if (items != null)
            {
                foreach (var item in items)
                {
                    string[] lvItemDisplay = { item.redemptionName, item.created.ToString() };
                    ListViewItem lvItem = new ListViewItem(lvItemDisplay);
                    lvItem.Tag = item;
                    listItems.Items.Add(lvItem);
                }
            }
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.RedemptionCalculator));
            Parent.Controls.Remove(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItems != null)
            {
                foreach (ListViewItem item in listItems.SelectedItems)
                {
                    var delItem = (RedemptionData)item.Tag;
                    model.deleteItem(delItem.RedemptionID);
                    fillListViewWithItemsAsync();
                }
            }
        }

        private void listItems_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            Point mousePos = listItems.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = listItems.HitTest(mousePos);

            var firstSelected = hitTest.Item;
            if (firstSelected?.Tag != null)
            {
                var selectedCalculator = (RedemptionData) firstSelected.Tag;
                var view = new RedemptionCalculatorView(selectedCalculator);
                view.Dock = DockStyle.Fill;
                Parent.Controls.Add(view);
                Parent.Controls.Remove(this);
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItems != null)
            {
                btnDelete.Enabled = true;
            }
        }
    }
}
