---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForUpdatesForUserAsync(Windows.System.User,System.String,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem> SearchForUpdatesForUserAsync(Windows.System.User user, System.String productId, System.String skuId, System.String catalogId, System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForUpdatesForUserAsync

## -description
Searches for updates for the specified app and user, with the option to generate telemetry data.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param productId
The product ID of the app to be queried for updates.

### -param skuId
The SKU ID of the app to be queried for updates.

### -param catalogId
The catalog ID of the app to be queried for updates.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

## -returns
An asynchronous operation that, on successful completion, returns an [AppInstallItem](appinstallitem.md) that represents the available update.

## -remarks

## -examples

## -see-also
