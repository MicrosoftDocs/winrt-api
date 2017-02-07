---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.GetFilesAsync(Windows.Storage.Search.CommonFileQuery,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(Windows.Storage.Search.CommonFileQuery query, System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.GetFilesAsync

## -description
Retrieves a list of files in a specified range that are based on the specified file query. This returns a snapshot of the files at a point in time and does not allow you to keep track of changes through events.

## -parameters
### -param query
The type of file query to perform.

### -param startIndex
The zero-based index of the first file in the range. This parameter defaults to 0.

### -param maxItemsToRetrieve
The maximum number of files to retrieve. Use -1 to retrieve all files.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of files that are represented by [StorageFile](../windows.storage/storagefile.md) objects.

## -remarks
Use this overload to retrieve improve system performance by presenting a virtual view of the query results that includes only the necessary subset of files.

## -examples

## -see-also
[IStorageFolderQueryOperations interface](istoragefolderqueryoperations.md), [IStorageFolderQueryOperations.GetFilesAsync methods](istoragefolderqueryoperations_getfilesasync.md), [IStorageFolderQueryOperations.GetFilesAsync(CommonFileQuery) method](istoragefolderqueryoperations_getfilesasync_1429382825.md), [Windows.Foundation.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)