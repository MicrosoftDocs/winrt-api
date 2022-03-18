---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesForUserAsync(Windows.System.User,System.String,System.String,Windows.ApplicationModel.Store.Preview.InstallControl.AppUpdateOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppInstallItem>> AppInstallManager.SearchForAllUpdatesForUserAsync(User user, String correlationVector, String clientId, AppUpdateOptions updateOptions)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesForUserAsync

## -description
Searches for all available updates to apps installed on the current computer or device for the specified user, with the ability to allow forced app restarts and the option to generate telemetry data.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

### -param clientId
The ID of the caller.

### -param updateOptions
Provides additional options for the operation, including the ability to allow forced app restarts.

## -returns
An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [AppInstallItem](appinstallitem.md) items. (You can use APIs of [IVectorView<AppInstallItem>](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;AppInstallItem&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -see-also

## -examples

## -capabilities
runFullTrust
