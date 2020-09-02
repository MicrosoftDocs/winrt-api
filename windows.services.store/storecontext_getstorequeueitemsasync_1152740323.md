---
-api-id: M:Windows.Services.Store.StoreContext.GetStoreQueueItemsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreQueueItem>> StoreContext.GetStoreQueueItemsAsync(IIterable<String> storeIds)
-->

# Windows.Services.Store.StoreContext.GetStoreQueueItemsAsync

## -description
Gets info about the specified new or updated packages that are in the download and installation queue for the current app.

## -parameters
### -param storeIds
An array of Store ID strings that correspond to the packages for which you want to get download and installation queue info.

## -returns
An asynchronous operation that, on successful completion, returns the collection of [StoreQueueItem](storequeueitem.md) objects that provide info about the specified packages in the queue.

## -remarks
If your app supports downloading and installing new or updated packages by using the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md) or [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) methods, in some cases your app may close before it successfully completes the download and install of the packages (for example, a user may close your app before the process is completed). You can use this method to get progress info about any packages that are currently in the queue so your app can display the download or install status of the packages.

The Store ID for a product is available in [Partner Center](https://partner.microsoft.com/dashboard), and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the product. For more information, see [Store IDs](/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

## -see-also
[GetAssociatedStoreQueueItemsAsync](storecontext_getassociatedstorequeueitemsasync_104208804.md),[RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md),[RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md)

## -examples
