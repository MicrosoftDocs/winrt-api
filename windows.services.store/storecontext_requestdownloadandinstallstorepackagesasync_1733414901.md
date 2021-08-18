---
-api-id: M:Windows.Services.Store.StoreContext.RequestDownloadAndInstallStorePackagesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Services.Store.StorePackageUpdateResult, Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync(Windows.Foundation.Collections.IIterable<System.String> storeIds)
-->

# Windows.Services.Store.StoreContext.RequestDownloadAndInstallStorePackagesAsync

## -description
Attempts to download and install the specified downloadable content (DLC) packages for the current app from the Microsoft Store. This method also displays a UI dialog that requests permission for the operation.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storeIds
The Store IDs of the DLC add-on packages to install.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -remarks
Use this method to download and install new DLC packages for the current app. When you call this method, the OS displays a dialog that tells the user that an app package is available to download and install, and asks the user's permission to proceed with the operation. If the user does not grant permission, the [OverallState](storepackageupdateresult_overallstate.md) property of the [StorePackageUpdateResult](storepackageupdateresult.md) return value has the value **Canceled**. To silently install an app package without displaying a notification dialog, use [DownloadAndInstallStorePackagesAsync](storecontext_downloadandinstallstorepackagesasync_1940804668.md) (this method requires access to a restricted capability).

The Store ID for a DLC add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the DLC add-on. For more information, see [Store IDs](/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the packages are downloaded and installed.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download and installation process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the package that raised the progress notification.

> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
[DownloadAndInstallStorePackagesAsync](storecontext_downloadandinstallstorepackagesasync_1940804668.md),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
