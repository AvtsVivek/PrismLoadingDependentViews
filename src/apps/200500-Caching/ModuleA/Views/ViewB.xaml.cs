using ModuleA.RibbonTabs;
using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    [DependentView(typeof(ViewBTab), "RibbonTabRegion")]
    [DependentView(typeof(ViewC), "SubRegion")]
    public partial class ViewB : UserControl, ISupportDataContext
    {
        public ViewB()
        {
            InitializeComponent();
        }
    }
}
