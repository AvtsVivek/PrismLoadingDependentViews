using Infragistics.Windows.Ribbon;

namespace ModuleA.RibbonTabs
{
    /// <summary>
    /// Interaction logic for ViewATab.xaml
    /// </summary>
    public partial class ViewATab : RibbonTabItem
    {
        public ViewATab()
        {
            InitializeComponent();
            SetResourceReference(StyleProperty, typeof(RibbonTabItem));
        }
    }
}
