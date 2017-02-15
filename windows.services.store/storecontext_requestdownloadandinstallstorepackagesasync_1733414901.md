---
-api-id: M:Windows.Services.Store.StoreContext.RequestDownloadAndInstallStorePackagesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Services.Store.StorePackageUpdateResult, Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync(Windows.Foundation.Collections.IIterable<System.String> storeIds)
-->

# Windows.Services.Store.StoreContext.RequestDownloadAndInstallStorePackagesAsync

## -description
Downloads and installs the specified downloadable content (DLC) packages for the current app from the Windows Store.

## -parameters
### -param storeIds
The product IDs of the add-on packages to install.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -remarks
Use this method to download and install a new DLC package for the current app.

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the packages are downloaded and installed.

When you call this method, the OS displays a dialog that tells the user that an app package is available to download and install, and asks the user's permission to proceed with the operation. If the user does not grant permission, the [OverallState](storepackageupdateresult_overallstate.md) property of the [StorePackageUpdateResult](storepackageupdateresult.md) return value has the value **Canceled**.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download and installation process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the package that raised the progress notification.

> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
