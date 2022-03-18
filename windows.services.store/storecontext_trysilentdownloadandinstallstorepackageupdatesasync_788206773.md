---
-api-id: M:Windows.Services.Store.StoreContext.TrySilentDownloadAndInstallStorePackageUpdatesAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Store.StorePackageUpdate})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<StorePackageUpdateStatus> StoreContext.TrySilentDownloadAndInstallStorePackageUpdatesAsync(IIterable<StorePackageUpdate> storePackageUpdates)
-->

# Windows.Services.Store.StoreContext.TrySilentDownloadAndInstallStorePackageUpdatesAsync

## -description
Attempts to download and install the specified package updates for the current app from the Microsoft Store without displaying a notification UI to the user.

## -parameters
### -param storePackageUpdates
The set of [StorePackageUpdate](storepackageupdate.md) objects that represent the updated packages to download and install.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -remarks
Use this method to attempt to download package updates for the current app silently (without displaying a notification UI that asks the user's permission to proceed with the download). Before calling this method, first check the [CanSilentlyDownloadStorePackageUpdates](storecontext_cansilentlydownloadstorepackageupdates.md) property to determine whether package updates can be silently downloaded based on the user's settings and network configuration. This method is an alternative to [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md), which displays a notification UI.

To get the list of packages that have updates available, use the [GetAppAndOptionalStorePackageUpdatesAsync](storecontext_getappandoptionalstorepackageupdatesasync_399599716.md) method. If you have already download package updates silently by using [TrySilentDownloadStorePackageUpdatesAsync](storecontext_trysilentdownloadstorepackageupdatesasync_227038344.md), this method will install the updates without trying to download them again. 

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the update packages are downloaded and installed.

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates),[CanSilentlyDownloadStorePackageUpdates](storecontext_cansilentlydownloadstorepackageupdates.md),[TrySilentDownloadStorePackageUpdatesAsync](storecontext_trysilentdownloadstorepackageupdatesasync_227038344.md)

## -examples
