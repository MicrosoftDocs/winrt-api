---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForUpdatesForUserAsync(Windows.System.User,System.String,System.String,System.String,System.String,Windows.ApplicationModel.Store.Preview.InstallControl.AppUpdateOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppInstallItem> AppInstallManager.SearchForUpdatesForUserAsync(User user, String productId, String skuId, String correlationVector, String clientId, AppUpdateOptions updateOptions)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForUpdatesForUserAsync

## -description
Searches for updates for the specified app and user, with the ability to allow a forced app restart and the option to generate telemetry data.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param productId
The product ID of the app to be queried for updates.

### -param skuId
The SKU ID of the app to be queried for updates.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

### -param clientId
The ID of the caller.

### -param updateOptions
Provides additional options for the operation, including the ability to allow a forced app restart.

## -returns
An asynchronous operation that, on successful completion, returns an [AppInstallItem](appinstallitem.md) that represents the available update.

## -remarks

## -see-also

## -examples

## -capabilities
runFullTrust
