---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.GetItemsAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetItemsAsync(System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.GetItemsAsync

## -description
Retrieves a list items like files, folders, or file groups, in a specified range (shallow enumeration).

## -parameters
### -param startIndex
The zero-based index of the first item in the range. This parameter defaults to 0.

### -param maxItemsToRetrieve
The maximum number of items to retrieve. Use -1 to retrieve all items.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of items. Each item is the [IStorageItem](../windows.storage/istorageitem.md) type and represents a file, folder, or file group.

In this list, files are represented by [StorageFile](../windows.storage/storagefile.md) objects, and folders or file groups are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks

## -examples

## -see-also
[IStorageFolderQueryOperations interface](istoragefolderqueryoperations.md), [Windows.Foundation.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.IStorageItem interface](../windows.storage/istorageitem.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)