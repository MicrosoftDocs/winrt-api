---
-api-id: M:Windows.Management.Deployment.PackageManagerDebugSettings.SetContentGroupStateAsync(Windows.ApplicationModel.Package,System.String,Windows.ApplicationModel.PackageContentGroupState,System.Double)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction PackageManagerDebugSettings.SetContentGroupStateAsync(Package package, String contentGroupName, PackageContentGroupState state, Double completionPercentage)
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

### -param completionPercentage

The simulated percent install completion. A value between 0 and 100.0. A value greater than 100 is clamped to 100.

## -returns

Returns an IAsyncAction that completes when the state has changed.

## -remarks

The state of the required content group (which is specified by PackageContentGroup.RequiredGroupName) cannot be changed. The method will fail if this group is specified.

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)
