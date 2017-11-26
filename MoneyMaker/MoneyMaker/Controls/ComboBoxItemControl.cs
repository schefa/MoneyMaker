using MoneyMaker.Libraries.Webservices.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoneyMaker.Controls
{
    /// <summary>
    /// Recalculates and redesigns the combobox item for stock suggestion
    /// </summary>
    public class ComboBoxItemControl  
    {
        private static int ItemMargin = 5;
        private Font font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        public Font Font
        {
            get { return font; }
            set { font = value; }
        }

        public void drawItem(ref object sender,ref DrawItemEventArgs e)
        {

            // Get the ComboBox and the item.
            ComboBox lst = sender as ComboBox;
            string txt = "";
            if (lst.Items.Count > 0)
            {
                YahooStockSearchResult stock = (YahooStockSearchResult)lst.Items[e.Index];
                txt = stock.Display;
            }

            // Draw the background.
            e.DrawBackground();

            // See if the item is selected.
            if ((e.State & DrawItemState.Selected) ==
                DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.                
                e.Graphics.DrawString(txt, this.Font,
                    SystemBrushes.HighlightText, e.Bounds.Left,
                        e.Bounds.Top + ItemMargin);
            }
            else
            {
                // Not selected. Draw with ComboBox's foreground color.
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(txt, this.Font, br,
                        e.Bounds.Left, e.Bounds.Top + ItemMargin);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();

        }

        public void measureItem(ref object sender, ref MeasureItemEventArgs e)
        {
            // Get the ComboBox and the item.
            ComboBox lst = sender as ComboBox;
            string txt = "";
            if (lst.Items.Count > 0)
            {
                YahooStockSearchResult stock = (YahooStockSearchResult)lst.Items[e.Index];
                txt = stock.Display;
            }

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
        }
    }
}
