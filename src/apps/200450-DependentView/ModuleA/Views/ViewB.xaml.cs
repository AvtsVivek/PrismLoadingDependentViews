using ModuleA.RibbonTabs;
using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    [RibbonTab(typeof(ViewBTab))]
    public partial class ViewB : UserControl, ISupportDataContext
    {
        public ViewB()
        {
            InitializeComponent();
        }
    }
}
