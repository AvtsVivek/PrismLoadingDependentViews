# Basic example of Tab Control. 
- This builds from the previous example. 
- To make the Ribbon Control a region, add RegionName attached property as follows
```xml
<igWPF:XamRibbon prism:RegionManager.RegionName="RibbonTabRegion" >
```

- Now run, you will get an exception, as no Region adapter is avaible by default by Prism. So we need to create a Region adapter. 
- Add a new adapter in the prism folder. 
- Foinally register the adapter in the bootstarpper.

```cs
protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
{
    base.ConfigureRegionAdapterMappings(regionAdapterMappings);
    regionAdapterMappings.RegisterMapping(typeof(XamRibbon), Container.Resolve<RibbonRegionAdapter>());
}
```

- Now run.