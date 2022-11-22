# Basic example of Tab Control. 
- This builds from the previous example. 
- This adds a Region Behavior. 
- We are injecting ViewA into the region by name ContentRegion in ShellWindow. What we want is, this should automatically inject ViewATab(which is a Ribbon View in RibbonTab folder in ModuleA) into another region by name RibbonTabRegion. 
- How to accomplish this? First there are Region Adapters. These are classes which take an incomming view and adapts into a region. Then there are behind the senes region behaviors which can do some additional stuff as needed. So a custom region behaviors can inject ViewATab view into RibbonTabRegion when ViewA is injected to ContentRegion.
- Add a RibbonRegionBehavior class and then register this in the bootstrapper.
```cs
protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
{
    base.ConfigureDefaultRegionBehaviors(regionBehaviors);
    regionBehaviors.AddIfMissing(RibbonRegionBehavior.BehaviorKey, typeof(RibbonRegionBehavior));
}
```
- Now run the app. 
- 