using Infragistics.Windows.Ribbon;
using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SimplePrismShell.Prism;
using SimplePrismShell.Views;
using System.Windows;
using System.Windows.Controls;

namespace SimplePrismShell
{
    public class BootStrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleAModule>();
        }
        
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(XamRibbon), Container.Resolve<RibbonRegionAdapter>());
        }

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            base.ConfigureDefaultRegionBehaviors(regionBehaviors);
            regionBehaviors.AddIfMissing(DependentViewRegionBehavior.BehaviorKey, typeof(DependentViewRegionBehavior));
        }
    }
}
