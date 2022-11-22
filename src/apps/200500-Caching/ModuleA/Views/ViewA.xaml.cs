using ModuleA.RibbonTabs;
using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    [DependentView(typeof(ViewATab), "RibbonTabRegion")]
    public partial class ViewA : UserControl, ISupportDataContext
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
