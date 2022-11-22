using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Interactivity;
using Prism.Regions;

namespace SimplePrismShell
{
    public class CloseTabAction : TriggerAction<Button>
    {
        protected override void Invoke(object parameter)
        {
            var args = parameter as RoutedEventArgs;
            if (args == null)
                return;
            var child = args.OriginalSource as DependencyObject;

            var tabItem = FindParent<TabItem>(child!);
            if (tabItem == null)
                return;

            var tabControl = FindParent<TabControl>(tabItem);
            if (tabControl == null)
                return;

            var region = RegionManager.GetObservableRegion(tabControl).Value;
            if (region == null)
                return;

            if (region.Views.Contains(tabItem.Content))
                region.Remove(tabItem.Content);
            // RemoveItemFromRegion(tabItem.Content, region);
        }

        //private void RemoveItemFromRegion(object item, IRegion region)
        //{
        //    var navigationContext = new NavigationContext(region.NavigationService, null);
        //    if (CanRemove(item, navigationContext))
        //    {
        //        // Both of the following are not needed. Only one is needed. 
        //        InvokeOnNavigatedFrom(item, navigationContext);
        //        InvokeOnNavigatedFromCustom(item, navigationContext);

        //        region.Remove(item);
        //    }
        //}

        //private bool CanRemove(object item, NavigationContext navigationContext)
        //{
        //    bool canRemove = true;

        //    var confirmRequestItem = item as IAllowCloseTheTab;
        //    canRemove = CheckCanRemove(canRemove, confirmRequestItem);

        //    var frameworkElement = item as FrameworkElement;
        //    if (frameworkElement != null && canRemove)
        //    {
        //        var confirmRequestDataContext = frameworkElement.DataContext as IAllowCloseTheTab;
        //        canRemove = CheckCanRemove(canRemove, confirmRequestDataContext);
        //    }

        //    return canRemove;
        //}

        //private static bool CheckCanRemove(bool canRemove, IAllowCloseTheTab? confirmRequestDataContext)
        //{
        //    if (confirmRequestDataContext != null)
        //    {
        //        //confirmRequestDataContext.CheckCloseTab(result =>
        //        //{
        //        //    canRemove = result;
        //        //});
                
        //        // Use above or below

        //        canRemove = confirmRequestDataContext.CheckCloseTab();
        //    }

        //    return canRemove;
        //}

        //private void InvokeOnNavigatedFrom(object item, NavigationContext navigationContext)
        //{
        //    var navigationAwareItem = item as INavigationAware;
        //    if (navigationAwareItem != null)
        //        navigationAwareItem.OnNavigatedFrom(navigationContext);

        //    var frameworkElement = item as FrameworkElement;
        //    if (frameworkElement != null)
        //    {
        //        var navigationAwareDataContext = frameworkElement.DataContext as INavigationAware;
        //        if (navigationAwareDataContext != null)
        //        {
        //            navigationAwareDataContext.OnNavigatedFrom(navigationContext);
        //        }
        //    }
        //}

        //private void InvokeOnNavigatedFromCustom(object item, NavigationContext navigationContext)
        //{
        //    var navigationAwareItem = item as INoitifyOnTabClose;
        //    if (navigationAwareItem != null)
        //        navigationAwareItem.OnTabClose(navigationContext);

        //    var frameworkElement = item as FrameworkElement;
        //    if (frameworkElement != null)
        //    {
        //        var navigationAwareDataContext = frameworkElement.DataContext as INoitifyOnTabClose;
        //        if (navigationAwareDataContext != null)
        //        {
        //            navigationAwareDataContext.OnTabClose(navigationContext);
        //        }
        //    }
        //}

        private T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null)
                return null!;

            var parent = parentObject as T;
            if (parent != null)
                return parent;

            return FindParent<T>(parentObject);
        }
    }
}
