using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMaker
{
    public partial class FrmGuide : Form
    {
        //This Methode navigates the different pages
        private void navigate(UserControl view)
        {
            pnlMain.Controls.Clear();
            view.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(view);
        }

        private static FrmGuide current = null;

        private static FrmGuide instance = null;

        //Singleton-Pattern: Only one time the reference book gets opened
        public static FrmGuide getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new FrmGuide();
            }
            return instance;
        }

        private FrmGuide()
        {
            InitializeComponent();
            if (current == null)
            {
                current = this;
            }
            rtbContent.Rtf = Properties.Resources.index;
        }

        //For the different pages you can change the content in .rtf files
        //which are in the folder Texts
        private void loadFile(string pageName)
        {
           
        }

        public static FrmGuide Current
        {
            get
            {
                return current;
            }
        }

        public void setHeadline(string value)
        {
            lblHeadline.Text = value;
        }

        private void llFirstStep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            rtbContent.Rtf = Properties.Resources.firstStep;
            pbNavigationChange.Image = Properties.Resources.StepsIcon;
        }

        private void llDepot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            rtbContent.Rtf = Properties.Resources.depot;
            pbNavigationChange.Image = Properties.Resources.DepotIcon;
        }

        private void llWatchlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            rtbContent.Rtf = Properties.Resources.watchlist;
            pbNavigationChange.Image = Properties.Resources.WatchlistIcon;
        }

        private void llVerrechungskonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            rtbContent.Rtf = Properties.Resources.bank;
            pbNavigationChange.Image = Properties.Resources.BankIcon;
        }

        private void llFinanzierungsrechner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            rtbContent.Rtf = Properties.Resources.financialCalculator;
            pbNavigationChange.Image = Properties.Resources.LoanIcon;
        }       

        //This method allows you to search and highlight particluar words
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            rtbContent.SelectAll();
           
            rtbContent.SelectionBackColor = Color.Transparent;            

            int index = 0;
            if (tbSearch.Text != "" && !tbSearch.Text.Equals(" "))
            {
                while (index < rtbContent.Text.LastIndexOf(tbSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    rtbContent.Find(tbSearch.Text, index, rtbContent.TextLength, RichTextBoxFinds.None);
                    rtbContent.SelectionBackColor = Color.Yellow;
                    index = rtbContent.Text.IndexOf(tbSearch.Text, index, StringComparison.CurrentCultureIgnoreCase) + 1;
                }
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Suchen...")
            {
                tbSearch.Text = "";
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Suchen...";
            }
        }
    }
}