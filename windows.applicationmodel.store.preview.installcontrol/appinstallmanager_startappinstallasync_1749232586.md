---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartAppInstallAsync(System.String,System.String,System.Boolean,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem> StartAppInstallAsync(System.String productId, System.String skuId, System.Boolean repair, System.Boolean forceUseOfNonRemovableStorage)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.StartAppInstallAsync

## -description
Starts the installation of the specified app.

## -parameters
### -param productId
The product ID of the app to install.

### -param skuId
The SKU ID of the app to install.

### -param repair
True to attempt to repair the installation of an app that is already installed; otherwise, false.

### -param forceUseOfNonRemovableStorage
True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.

## -returns
An asynchronous operation that, on successful completion, returns an [AppInstallItem](appinstallitem.md) that represents the app that was added to the installation queue.

## -remarks
When this method successfully returns, the app has been added to the installation queue; it does not necessarily mean that the app has finished being installed. To determine the installation status, check the [GetCurrentStatus](appinstallitem_getcurrentstatus_1536936899.md) method of the [AppInstallItem](appinstallitem.md) return value.

## -examples

## -see-also
[StartAppInstallAsync(String, String, Boolean, Boolean, String, String, String)](appinstallmanager_startappinstallasync_1608657462.md)
## -capabilities
runFullTrust
