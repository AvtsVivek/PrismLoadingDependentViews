using Infragistics.Windows.Ribbon;
using SimplePrismShell.Core;

namespace ModuleA.RibbonTabs
{
    /// <summary>
    /// Interaction logic for ViewBTab.xaml
    /// </summary>
    public partial class ViewBTab : RibbonTabItem, ISupportDataContext
    {
        public ViewBTab()
        {
            InitializeComponent();
            SetResourceReference(StyleProperty, typeof(RibbonTabItem));
        }
    }
}
