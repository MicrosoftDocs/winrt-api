---
-api-id: P:Windows.Services.Store.StoreContext.CanSilentlyDownloadStorePackageUpdates
-api-type: winrt property
---

<!-- Property syntax.
public bool CanSilentlyDownloadStorePackageUpdates { get; }
-->

# Windows.Services.Store.StoreContext.CanSilentlyDownloadStorePackageUpdates

## -description
Gets a value that indicates whether package updates for the current app can be downloaded without displaying a notification UI to the user.

## -property-value
True if package updates for the current app can be downloaded without displaying a notification UI to the user; otherwise, false.

## -remarks
This property can return false in the following scenarios:
* The user has disabled the **Update apps automatically** setting in the Store.
* The user is on a metered network.

## -see-also
[TrySilentDownloadStorePackageUpdatesAsync](storecontext_trysilentdownloadstorepackageupdatesasync_227038344.md),[TrySilentDownloadAndInstallStorePackageUpdatesAsync](storecontext_trysilentdownloadandinstallstorepackageupdatesasync_788206773.md)

## -examples
