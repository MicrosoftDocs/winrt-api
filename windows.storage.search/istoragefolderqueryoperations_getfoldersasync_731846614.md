---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery query, System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.GetFoldersAsync

## -description
Asynchronously retrieves a range of folders in this folder based on a folder query. This returns a snapshot of the folders or file groups at a point in time and does not allow you to keep track of changes through events.

## -parameters
### -param query
The type of folder query to perform.

### -param startIndex
The zero-based index of the first folder or file group in the range. This parameter defaults to 0.

### -param maxItemsToRetrieve
The maximum number of folders or file groups to retrieve. Use -1 to retrieve all folders or file groups.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of folders of file groups that are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks
Use this overload to retrieve improve system performance by presenting a virtual view of the query results that includes only the necessary subset of folders.

## -examples

## -see-also
[IStorageFolderQueryOperations interface](istoragefolderqueryoperations.md), [IStorageFolderQueryOperations.GetFoldersAsync(CommonFolderQuery) method](istoragefolderqueryoperations_getfoldersasync_595997124.md), [Windows.Foundation.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)