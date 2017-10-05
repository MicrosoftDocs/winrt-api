---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartAppInstallAsync(System.String,System.String,System.Boolean,System.Boolean,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem> StartAppInstallAsync(System.String productId, System.String skuId, System.Boolean repair, System.Boolean forceUseOfNonRemovableStorage, System.String catalogId, System.String bundleId, System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartAppInstallAsync

## -description
Starts the installation of the specified app, with the option to generate telemetry data.

## -parameters
### -param productId
The product ID of the app to install.

### -param skuId
The SKU ID of the app to install.

### -param repair
True to attempt to repair the installation of an app that is already installed; otherwise, false.

### -param forceUseOfNonRemovableStorage
True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.

### -param catalogId
The catalog ID of the app to install.

### -param bundleId
The bundle ID of the app to install.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

## -returns
An asynchronous operation that, on successful completion, returns an [AppInstallItem](appinstallitem.md) that represents the app that was added to the installation queue.

## -remarks
The remarks for [StartAppInstallAsync(String, String, Boolean, Boolean)](appinstallmanager_startappinstallasync_1749232586.md) also apply to this method.

## -examples

## -see-also
[StartAppInstallAsync(String, String, Boolean, Boolean)](appinstallmanager_startappinstallasync_1749232586.md)
## -capabilities
runFullTrust
