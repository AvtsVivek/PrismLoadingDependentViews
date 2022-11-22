using Infragistics.Windows.Ribbon;

namespace ModuleA.RibbonTabs
{
    /// <summary>
    /// Interaction logic for ViewBTab.xaml
    /// </summary>
    public partial class ViewBTab : RibbonTabItem
    {
        public ViewBTab()
        {
            InitializeComponent();
            SetResourceReference(StyleProperty, typeof(RibbonTabItem));
        }
    }
}
