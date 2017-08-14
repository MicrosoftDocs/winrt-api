---
-api-id: P:Windows.System.AppResourceGroupInfoWatcherEventArgs.AppDiagnosticInfos
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<AppDiagnosticInfo> AppDiagnosticInfos { get; }
-->

# Windows.System.AppResourceGroupInfoWatcherEventArgs.AppDiagnosticInfos

## -description
Gets diagnostic info for the resource group.

## -property-value
The diagnostic info for the apps associated with the  [AppResourceGroupInfo](appresourcegroupinfo.md) for the current event.  

## -remarks
Typically there will only be one app associated with the  **AppResourceGroupInfo**, but there can be more.

## -see-also

## -examples
```csharp
// A resource group has been added to the list in the AppDiagnosticInfo.
private void OnResourceGroupAdded(
    AppResourceGroupInfoWatcher sender, AppResourceGroupInfoWatcherEventArgs args)
{
    // A resource group can be associated with multiple apps. The event args here
    // indicate which apps are part of the watched resource group. Otherwise the
    // app has to keep a map between them.
    if (args.AppDiagnosticInfos.Count > 0)
    {
        Debug.WriteLine("ResourceGroup added for {0}", args.AppDiagnosticInfos[0].AppInfo.DisplayInfo);
    }
}
```

## -capabilities
appDiagnostics
