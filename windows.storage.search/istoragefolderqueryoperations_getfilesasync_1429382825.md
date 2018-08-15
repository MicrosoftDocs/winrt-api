---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.GetFilesAsync(Windows.Storage.Search.CommonFileQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(Windows.Storage.Search.CommonFileQuery query)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.GetFilesAsync

## -description
Retrieves a list of files based on the specified query (shallow enumeration). This returns a snapshot of the files at a point in time and does not allow you to keep track of changes through events.

## -parameters
### -param query
The type of file query to perform.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of files that are represented by [StorageFile](../windows.storage/storagefile.md) objects.

## -remarks

## -examples

## -see-also
[IStorageFolderQueryOperations interface](istoragefolderqueryoperations.md), [IStorageFolderQueryOperations.GetFilesAsync methods](istoragefolderqueryoperations_getfilesasync_1429382825.md), [IStorageFolderQueryOperations.GetFilesAsync(CommonFileQuery, UInt32, UInt32)](istoragefolderqueryoperations_getfilesasync_1563132095.md), [Windows.Foundation.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)