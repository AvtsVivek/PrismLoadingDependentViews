using ModuleA.RibbonTabs;
using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    [RibbonTab(typeof(ViewATab))]
    [RibbonTab(typeof(ViewATab))]
    [RibbonTab(typeof(ViewATab))]
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
