---
-api-id: M:Windows.Services.Store.StoreContext.SetInstallOrderForAssociatedStoreQueueItemsAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Store.StoreQueueItem})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<StoreQueueItem>> StoreContext.SetInstallOrderForAssociatedStoreQueueItemsAsync(IIterable<StoreQueueItem> items)
-->

# Windows.Services.Store.StoreContext.SetInstallOrderForAssociatedStoreQueueItemsAsync

## -description
Sets the order in which to install the specified packages in the download and installation queue for the current app.

## -parameters
### -param items
A list of [StoreQueueItem](storequeueitem.md) objects that represents the packages in the install queue, in the order in which you want the packages to be installed.

## -returns
An asynchronous operation that, on successful completion, returns the list of [StoreQueueItem](storequeueitem.md) objects in the order in which the corresponding packages in the queue were set to be installed.

## -remarks

## -see-also
[GetAssociatedStoreQueueItemsAsync](storecontext_getassociatedstorequeueitemsasync_104208804.md)

## -examples
