# Basic example of Tab Control. 
- This builds from the previous example 200350-RibbonRegionBehavior
- Demos how to share data context. Click update button on Ribbon View and it should update the view below.
- First define an interface.

```cs
public interface ISupportDataContext
{
    object DataContext { get; set; }
}
```


- Impliment that interface for aall of the views.
- Add the following logic to the RibbonRegionBehavior 

```cs
if (ribbonTabItem is ISupportDataContext && newView is ISupportDataContext)
    ((ISupportDataContext)ribbonTabItem).DataContext = ((ISupportDataContext)newView).DataContext;
```

- Now run the app. The update button the ribbon tab will invoke the one on View below. 

