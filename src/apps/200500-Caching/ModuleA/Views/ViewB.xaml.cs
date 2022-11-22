using ModuleA.RibbonTabs;
using Prism.Regions;
using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    [DependentView(typeof(ViewBTab), "RibbonTabRegion")]
    [DependentView(typeof(ViewC), "SubRegion")]
    public partial class ViewB : UserControl, ISupportDataContext, IRegionMemberLifetime
    {
        public ViewB()
        {
            InitializeComponent();
        }

        public bool KeepAlive => false;
    }
}
