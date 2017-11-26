using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;

namespace MoneyMaker.Views
{
    public partial class LoansView : MoneyMakerView
    {
        private LoanModel model;

        public LoansView()
        {
            InitializeComponent(); 

            mainForm.setHeadline("Meine Kredite");

            model = new LoanModel(mainForm.User);
            fillListViewWithItemsAsync();
        }

        private async void fillListViewWithItemsAsync()
        {
            listItems.Items.Clear();
            Task<List<LoanData>> task = Task.Run(() => model.getItems());
            var items = await task;
            if(items != null)
            {
                foreach (var loanItem in items)
                {
                    string[] lvItemDisplay = { loanItem.loanName, loanItem.created.ToString() };
                    ListViewItem lvItem = new ListViewItem(lvItemDisplay);
                    lvItem.Tag = loanItem;
                    listItems.Items.Add(lvItem);
                }
            }
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.LoanCalculator));
            Parent.Controls.Remove(this);
        }

        private void listItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mousePos = listItems.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = listItems.HitTest(mousePos);

            var firstSelected = hitTest.Item;
            if (firstSelected?.Tag != null)
            {
                var selectedCalculator = (LoanData) firstSelected.Tag;
                var view = new LoanCalculatorView(selectedCalculator);
                view.Dock = DockStyle.Fill;
                Parent.Controls.Add(view);
                Parent.Controls.Remove(this);
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listItems.SelectedItems != null)
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItems != null)
            {
                foreach (ListViewItem loan in listItems.SelectedItems)
                {
                    var item = (LoanData)loan.Tag;
                    model.deleteItem(item.LoanID);
                    fillListViewWithItemsAsync();
                }
            }
        }
    }
}
