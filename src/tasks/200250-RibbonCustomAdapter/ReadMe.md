# Basic example of Tab Control. 
- This builds from the previous example. 
- The previous example demonistrates a problem.
- ViewA has a ChildRegion. In the previous example, we ensure that a new region amanger is created for each View injected into a tab.
- Now we have to ensure that the ViewAViewModel will get this newly created Region Manager. So do the following. This is [similar to this example here](https://github.com/AvtsVivek/PrismMultipleShells/tree/main/src/tasks/200550-ChildRegionAwareEnd). 
- First create an interface IRegionManagerAware.
- Then ensure ViewAViewModel impliments it.
- Next Create a class RegionManagerAwareBehavior
- Register this class in the bootstrapper.
```cs
protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
{
    base.ConfigureDefaultRegionBehaviors(regionBehaviors);
    regionBehaviors.AddIfMissing(RegionManagerAwareBehavior.BehaviorKey, typeof(RegionManagerAwareBehavior));
}
```

- Now run the app. It should run corectly.