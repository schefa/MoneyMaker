using MoneyMaker.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoneyMaker.Views.Tables
{
    public partial class RedemptionCalculatorTable : Form
    {
        public RedemptionCalculatorTable(List<RedemptionTableRow> values)
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
    }
}
