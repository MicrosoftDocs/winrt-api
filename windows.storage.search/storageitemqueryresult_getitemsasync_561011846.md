---
-api-id: M:Windows.Storage.Search.StorageItemQueryResult.GetItemsAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetItemsAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Storage.Search.StorageItemQueryResult.GetItemsAsync

## -description
Retrieves a list of items (files and folders) in a specified range.

## -parameters
### -param startIndex
The zero-based index of the first item to retrieve. This parameter defaults to 0.

### -param maxNumberOfItems
The maximum number of items to retrieve. Use -1 to retrieve all items. If the range contains fewer items than the max number, all items in the range are returned.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of items. Each item is the [IStorageItem](../windows.storage/istorageitem.md) type and represents a file, folder, or file group.

In this list, files are represented by [StorageFile](../windows.storage/storagefile.md) objects, and folders or file groups are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks
You can use the [IsOfType](../windows.storage/istorageitem_isoftype_1417811226.md) method on both types of storage objects to find out whether an item is a [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md) object.

For C#/C++/VB: After you know whether the item is a [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md), you can then cast the item to the appropriate type in order to access properties and methods specific to that object.

Use this overload to improve system performance by presenting a virtualized view of the query results that includes only the necessary subset of folders. For example, if your app displays many items in a gallery you could use this range to retrieve only the items that are currently visible to the user.

## -examples

## -see-also
[StorageItemQueryResult class](storageitemqueryresult.md), [StorageItemQueryResult.GetItemsAsync() method](storageitemqueryresult_getitemsasync_1518547059.md), [Windows.Foundation.Collections.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.IStorageItem interface](../windows.storage/istorageitem.md), [Windows.Storage.IStorageItem.IsOfType method](../windows.storage/istorageitem_isoftype_1417811226.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)