---
-api-id: M:Windows.Management.Deployment.PackageManagerDebugSettings.SetContentGroupStateAsync(Windows.ApplicationModel.Package,System.String,Windows.ApplicationModel.PackageContentGroupState)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction PackageManagerDebugSettings.SetContentGroupStateAsync(Package package, String contentGroupName, PackageContentGroupState state)
-->

# Windows.Management.Deployment.PackageManagerDebugSettings.SetContentGroupStateAsync


## -description

Sets the staging state of a content group for debugging.

## -parameters

### -param package

The app [Package](/uwp/api/windows.applicationmodel.package).

### -param contentGroupName

The content group name. An AppxContentGroupMap.xml must be present when the app is registered for this API to work.

### -param state

The [PackageContentGroupState](../Windows.ApplicationModel/PackageContentGroupState.md) enum value.

## -returns

Returns an IAsyncAction that completes when the state has changed.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
