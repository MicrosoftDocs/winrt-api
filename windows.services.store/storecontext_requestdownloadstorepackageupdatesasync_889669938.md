---
-api-id: M:Windows.Services.Store.StoreContext.RequestDownloadStorePackageUpdatesAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Store.StorePackageUpdate})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Services.Store.StorePackageUpdateResult, Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadStorePackageUpdatesAsync(Windows.Foundation.Collections.IIterable<Windows.Services.Store.StorePackageUpdate> storePackageUpdates)
-->

# Windows.Services.Store.StoreContext.RequestDownloadStorePackageUpdatesAsync

## -description
Attempts to download the specified package updates for the current app from the Microsoft Store. This method also displays a UI dialog that requests permission for the operation.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storePackageUpdates
The set of [StorePackageUpdate](storepackageupdate.md) objects that represent the updated packages to download.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -remarks
To get the list of packages that have updates available, use the [GetAppAndOptionalStorePackageUpdatesAsync](storecontext_getappandoptionalstorepackageupdatesasync_399599716.md) method. After you download the packages, you can install them by using the [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) method. For more information about using this method, including a code example, see [Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates).

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the update packages are downloaded.

When you call this method, the OS displays a dialog that tells the user that an app update is available to download and asks the user's permission to proceed with the download. If the user does not grant permission to start the download, the [OverallState](storepackageupdateresult_overallstate.md) property of the [StorePackageUpdateResult](storepackageupdateresult.md) return value has the value **Canceled**.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the update package that raised the progress notification.

## -examples

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates), [StoreContext](storecontext.md), [StorePackageUpdateResult](storepackageupdateresult.md), [StorePackageUpdateStatus](storepackageupdatestatus.md)
