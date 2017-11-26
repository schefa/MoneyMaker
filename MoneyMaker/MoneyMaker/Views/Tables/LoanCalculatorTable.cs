using MoneyMaker.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoneyMaker.Views.Tables
{
    public partial class LoanCalculatorTable : Form
    {
        public LoanCalculatorTable(List<LoanTableRow> values)
        {
            InitializeComponent();

            Icon = Properties.Resources.LogoIcon;

            foreach (var item in values)
            {
                var lvItem = new ListViewItem(item.ToStringArray());
                lvItem.Tag = item;
                lvTable.Items.Add(lvItem);
            }
        }

        private void LoanCalculatorTable_Load(object sender, System.EventArgs e)
        {

        }
    }
}
