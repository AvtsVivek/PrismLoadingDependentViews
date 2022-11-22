# Basic example of Tab Control. 
- This builds from the previous example 
- Change the Attribute RibbonTabAttribute to the following.

```cs
    public class DependentViewAttribute : Attribute
    {
        public Type Type { get; set; }
        public string TargetRegionName { get; set; }

        public DependentViewAttribute(Type viewType, string targetRegionName)
        {
            Type = viewType;
            TargetRegionName = targetRegionName;
        }
    }

```
- Build and fix errors. 
- Add ViewC
- Add another region in shell
```xml
<ContentControl prism:RegionManager.RegionName="SubRegion"  />
```
- 

- Now run the app. The update button the ribbon tab will invoke the one on View below. 

