---
-api-id: M:Windows.Services.Store.StoreContext.TrySilentDownloadStorePackageUpdatesAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Store.StorePackageUpdate})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<StorePackageUpdateStatus> StoreContext.TrySilentDownloadStorePackageUpdatesAsync(IIterable<StorePackageUpdate> storePackageUpdates)
-->

# Windows.Services.Store.StoreContext.TrySilentDownloadStorePackageUpdatesAsync

## -description
Attempts to download the specified package updates for the current app from the Microsoft Store without displaying a notification UI to the user.

## -parameters
### -param storePackageUpdates
The set of [StorePackageUpdate](storepackageupdate.md) objects that represent the updated packages to download.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -remarks
Use this method to attempt to download package updates for the current app silently (without displaying a notification UI that asks the user's permission to proceed with the download). Before calling this method, first check the [CanSilentlyDownloadStorePackageUpdates](storecontext_cansilentlydownloadstorepackageupdates.md) property to determine whether package updates can be silently downloaded based on the user's settings and network configuration. This method is an alternative to [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md), which displays a notification UI.

To get the list of packages that have updates available, use the [GetAppAndOptionalStorePackageUpdatesAsync](storecontext_getappandoptionalstorepackageupdatesasync_399599716.md) method. After you download the packages, you can install them by using the [TrySilentDownloadAndInstallStorePackageUpdatesAsync](storecontext_trysilentdownloadandinstallstorepackageupdatesasync_788206773.md) method. 

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the update packages are downloaded.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the update package that raised the progress notification.

> [!NOTE]
> If the connection is terminated during a download, a subsequent call to this method will not resume transferring from the prior location. The download will restart from the beginning.

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates),[CanSilentlyDownloadStorePackageUpdates](storecontext_cansilentlydownloadstorepackageupdates.md),[TrySilentDownloadAndInstallStorePackageUpdatesAsync](storecontext_trysilentdownloadandinstallstorepackageupdatesasync_788206773.md)

## -examples
