---
-api-id: P:Windows.ApplicationModel.AppInstance.RecommendedInstance
-api-type: winrt property
---

<!-- Property syntax.
public AppInstance RecommendedInstance { get; }
-->

# Windows.ApplicationModel.AppInstance.RecommendedInstance

## -description
A shell can recommend an instance of an app to which an application activation is redirected.

## -property-value
The app instance that the shell prefers to use for an app, or `null` if there is no preference.

## -remarks
If the shell provides a preference, the app can redirect activation to that instance. 
The app can ignore the preference. 

> [!NOTE]
> Currently, the shell does not set a non-null value for **RecommendedInstance**.

## -see-also

## -examples
This example checks whether the shell recommends an instance, by using the app-defined _SelectedKeyIncludesMyKey_ method. 
If so, it checks whether the instance is suitable, and redirects to a suitable instance.
If the shell does not have preference, the app can look for an existing app instance to redirect to or attempt to register itself as the target.

```csharp
AppInstance RecommendedInstance = AppInstance.RecommendedInstance;
if ((RecommendedInstance != null) && SelectedKeyIncludesMyKey(RecommendedInstance.Key))
{
    RecommendedInstance.RedirectActivationTo();
}
else
{
    // Look for existing instance or attempt to register itself as target.
}


```

