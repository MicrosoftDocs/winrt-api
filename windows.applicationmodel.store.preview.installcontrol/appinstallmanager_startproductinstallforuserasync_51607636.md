---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartProductInstallForUserAsync(Windows.System.User,System.String,System.String,System.String,System.String,Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppInstallItem>> AppInstallManager.StartProductInstallForUserAsync(User user, String productId, String flightId, String clientId, String correlationVector, AppInstallOptions installOptions)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartProductInstallForUserAsync

## -description
Starts the installation of the specified app or app bundle for the specified user, with the ability to specify additional install options such as whether to allow a forced app restart.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param productId
The product ID of the app to install.

### -param flightId
The flight ID of the app to install.

### -param clientId
The ID of the caller.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

### -param installOptions
Provides additional options for the operation, including the ability to allow a forced app restart.

## -returns
An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [AppInstallItem](appinstallitem.md) items. (You can use APIs of [IVectorView<AppInstallItem>](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;AppInstallItem&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -see-also

## -examples

## -capabilities
runFullTrust
