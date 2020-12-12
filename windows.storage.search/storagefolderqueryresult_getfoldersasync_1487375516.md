---
-api-id: M:Windows.Storage.Search.StorageFolderQueryResult.GetFoldersAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Storage.Search.StorageFolderQueryResult.GetFoldersAsync

## -description
Retrieves folders (or file groups) in a specified range.

## -parameters
### -param startIndex
The zero-based index of the first folder to retrieve. This parameter defaults to 0.

### -param maxNumberOfItems
The maximum number of folders or file groups to retrieve. Use -1 to retrieve all folders. If the range contains fewer folders than the max number, all folders in the range are returned.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of folders or file groups that are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks
Use this overload to improve system performance by presenting a virtualized view of the query results that includes only the necessary subset of folders. For example, if your app displays many folders in a gallery you could use this range to retrieve only the folders that are currently visible to the user.

## -examples

## -see-also
[StorageFolderQueryResult class](storagefolderqueryresult.md), [StorageFolderQueryResult.GetFoldersAsync() method](storagefolderqueryresult_getfoldersasync_592765033.md), [Windows.Foundation.Collections.IVectorView interface](../windows.foundation.collections/ivectorview_1.md)