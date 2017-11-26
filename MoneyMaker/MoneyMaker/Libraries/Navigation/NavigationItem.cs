using System.Windows.Forms;

namespace MoneyMaker.Libraries.Navigation
{
    /// <summary>
    /// Expands the treeview with a view 
    /// @author : Fjodor Schäfer
    /// </summary>
    public class NavigationItem : TreeNode
    {
        public NavigationType View { get; set; }

        private NavigationParams parameters = new NavigationParams();
        public NavigationParams Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

    }
}
