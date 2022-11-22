using Infragistics.Windows.Ribbon;
using SimplePrismShell.Core;

namespace ModuleA.RibbonTabs
{
    /// <summary>
    /// Interaction logic for ViewATab.xaml
    /// </summary>
    public partial class ViewATab : RibbonTabItem, ISupportDataContext
    {
        public ViewATab()
        {
            InitializeComponent();
            SetResourceReference(StyleProperty, typeof(RibbonTabItem));
        }
    }
}
