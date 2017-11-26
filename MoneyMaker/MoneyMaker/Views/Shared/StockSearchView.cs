using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Controls;
using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Libraries.Yahoo;

namespace MoneyMaker.Views
{
    public partial class StockSearchView : MoneyMakerView
    {
        private ComboBox searchBox;
        public ComboBox SearchBox
        {
            get { return searchBox; }
        }

        private ComboBoxItemControl cbxItemStyle = new ComboBoxItemControl();
        private string searchValue = "";

        /// <summary>
        /// Default constructor
        /// </summary>
        public StockSearchView()
        {
            InitializeComponent();
            this.searchBox = cbMultiLine;
            cbMultiLine.DisplayMember = "name";
        }

        /// <summary>
        /// Method fired after every keypress
        /// </summary>
        private void cbMultiLine_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyValue >= 0x30 && e.KeyValue <= 0x39) // numbers
             || (e.KeyValue >= 0x41 && e.KeyValue <= 0x5A) // letters
             || (e.KeyValue >= 0x60 && e.KeyValue <= 0x69)) // numpad
            {
                cleanItems();
            
                cbMultiLine.SelectedItem = null;
                searchValue = cbMultiLine.Text;

                if (cbMultiLine.Text.Length >= 3)
                {
                    doAutoCompleteAsync();
                }
                else
                {
                    cleanItems();
                }
            }
            if (e.KeyData != Keys.Enter)
                cbMultiLine.DroppedDown = true;

            if(cbMultiLine.Items.Count < 1)
                addEmptyItem();
        }

        /// <summary>
        /// Searches the text asynchronously and fills the combobox items
        /// </summary>
        private async void doAutoCompleteAsync()
        {
            Cursor = Cursors.Default;
            Task<IList<YahooStockSearchResult>> task = Task.Run(() => YahooFinanceSearch.searchStockResultList(searchValue));
            var searchResultList = await task;

            if (searchResultList != null && searchResultList.Count > 0)
            {
                cleanItems();

                foreach (YahooStockSearchResult result in searchResultList)
                {
                    if (result.name.Length > 0)
                        cbMultiLine.Items.Add(result);
                }
            }

            cbMultiLine.DroppedDown = true;
            cbMultiLine.SelectionStart = cbMultiLine.Text.Length;
        }
        
        /// <summary>
        /// Clears the search box items
        /// </summary>
        private void cleanItems()
        {
            for (int i = 0; i < cbMultiLine.Items.Count; i++)
            {
                cbMultiLine.Items.RemoveAt(i);
            }
        }

        /// <summary>
        /// Adds an empty item
        /// </summary>
        private void addEmptyItem()
        {
            cbMultiLine.Items.Add(new YahooStockSearchResult { name = "Keine Ergebnisse" });
        }

        /// <summary>
        /// Draws the Combobox multiline item
        /// </summary>
        private void cbMultiLine_DrawItem(object sender, DrawItemEventArgs e)
        {
            cbxItemStyle.drawItem(ref sender, ref e);
        }

        /// <summary>
        /// Measures the Combobox multiline item
        /// </summary>
        private void cbMultiLine_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            cbxItemStyle.measureItem(ref sender, ref e);
        }
        
    }
}
