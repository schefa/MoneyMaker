using System.Windows.Forms;
using MoneyMaker.Libraries.Webservices.Entities;

namespace MoneyMaker.Views
{
    public partial class StockDetailsView : MoneyMakerView
    {
         

        public StockDetailsView()
        {
            InitializeComponent();
             
        }  

        public void refreshData(SingleQuote stockLatestPrice)
        {
            lblNameInput.Text = stockLatestPrice.Name;
            lblDateInput.Text = stockLatestPrice.Date.ToShortDateString();
            lblOpenInput.Text = stockLatestPrice.Open.ToString();
            lblCloseInput.Text = stockLatestPrice.CurrentPrice.ToString();
            lblVolumeInput.Text = stockLatestPrice.Volume.ToString();
             
        }
        
    }
}
