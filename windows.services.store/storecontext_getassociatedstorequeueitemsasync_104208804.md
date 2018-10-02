---
-api-id: M:Windows.Services.Store.StoreContext.GetAssociatedStoreQueueItemsAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreQueueItem>> StoreContext.GetAssociatedStoreQueueItemsAsync()
-->

# Windows.Services.Store.StoreContext.GetAssociatedStoreQueueItemsAsync

## -description
Gets info about all the new or updated packages that are in the download and installation queue for the current app.

## -returns
An asynchronous operation that, on successful completion, returns the collection of [StoreQueueItem](storequeueitem.md) objects that provide info about the app packages that are in the queue.

## -remarks
If your app supports downloading and installing new or updated packages by using the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md) or [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) methods, in some cases your app may close before it successfully completes the download and install of the packages (for example, a user may close your app before the process is completed). You can use this method to get progress info about any packages that are currently in the queue so your app can display the download or install status of the packages.

## -see-also
[GetStoreQueueItemsAsync](storecontext_getstorequeueitemsasync_1152740323.md),[SetInstallOrderForAssociatedStoreQueueItemsAsync](storecontext_setinstallorderforassociatedstorequeueitemsasync_1121508289.md),[RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md),[RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md)

## -examples
