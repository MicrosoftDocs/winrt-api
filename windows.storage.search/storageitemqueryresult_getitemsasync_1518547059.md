---
-api-id: M:Windows.Storage.Search.StorageItemQueryResult.GetItemsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetItemsAsync()
-->

# Windows.Storage.Search.StorageItemQueryResult.GetItemsAsync

## -description
Retrieves a list of all the items (files and folders) in the query results set.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of items. Each item is the [IStorageItem](../windows.storage/istorageitem.md) type and represents a file, folder, or file group.

In this list, files are represented by [StorageFile](../windows.storage/storagefile.md) objects, and folders or file groups are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks

## -examples

## -see-also
[StorageItemQueryResult class](storageitemqueryresult.md), [StorageItemQueryResult.GetItemsAsync(startIndex, maxNumberOfItems) method](storageitemqueryresult_getitemsasync_561011846.md), [Windows.Foundation.Collections.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.IStorageItem interface](../windows.storage/istorageitem.md), [Windows.Storage.IStorageItem.IsOfType method](../windows.storage/istorageitem_isoftype_1417811226.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)