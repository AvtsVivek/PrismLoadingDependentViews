using Infragistics.Windows.Ribbon;
using Prism.Regions;
using SimplePrismShell.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismShell.Prism
{
    public class RibbonRegionBehavior : RegionBehavior
    {
        public const string BehaviorKey = "XamRibbonRegionBehavior";

        public const string RibbonTabRegionName = "RibbonTabRegion";

        protected override void OnAttach()
        {
            if (Region.Name == "ContentRegion")
                Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged!;
        }

        private void ActiveViews_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                var tabList = new List<RibbonTabItem>();

                foreach (var newView in e.NewItems!)
                {
                    foreach (var atr in GetCustomAttributes<RibbonTabAttribute>(newView.GetType()))
                    {
                        var ribbonTabItem = Activator.CreateInstance(atr.Type) as RibbonTabItem;

                        if (ribbonTabItem is ISupportDataContext && newView is ISupportDataContext)
                            ((ISupportDataContext)ribbonTabItem).DataContext = ((ISupportDataContext)newView).DataContext;

                        tabList.Add(ribbonTabItem!);
                    }

                    tabList.ForEach(x => Region.RegionManager.Regions[RibbonTabRegionName].Add(x));
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                var views = Region.RegionManager.Regions[RibbonTabRegionName].Views.ToList();
                views.ForEach(x => Region.RegionManager.Regions[RibbonTabRegionName].Remove(x));
            }
        }

        private static IEnumerable<T> GetCustomAttributes<T>(Type type)
        {
            return type.GetCustomAttributes(typeof(T), true).OfType<T>();
        }
    }
}
