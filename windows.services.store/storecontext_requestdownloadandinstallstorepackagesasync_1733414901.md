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

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storeIds
The product IDs of the add-on packages to install.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -exceptions
### System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](https://docs.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -remarks
Use this method to download and install a new DLC package for the current app.

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the packages are downloaded and installed.

When you call this method, the OS displays a dialog that tells the user that an app package is available to download and install, and asks the user's permission to proceed with the operation. If the user does not grant permission, the [OverallState](storepackageupdateresult_overallstate.md) property of the [StorePackageUpdateResult](storepackageupdateresult.md) return value has the value **Canceled**.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download and installation process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the package that raised the progress notification.

> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
