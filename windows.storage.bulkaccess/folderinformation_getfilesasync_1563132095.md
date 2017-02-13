---
-api-id: M:Windows.Storage.BulkAccess.FolderInformation.GetFilesAsync(Windows.Storage.Search.CommonFileQuery,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(Windows.Storage.Search.CommonFileQuery query, System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.BulkAccess.FolderInformation.GetFilesAsync

## -description
Retrieves a range of files from the current folder based on a common file query.

## -parameters
### -param query
The common file query.

### -param startIndex
The zero-based index of the first file in the range.

### -param maxItemsToRetrieve
The maximum number of files to retrieve.

## -returns
When this method completes successfully, it returns the list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [StorageFile](../windows.storage/storagefile.md) objects in the folder.

## -remarks

## -examples

## -see-also
[GetFilesAsync(CommonFileQuery)](folderinformation_getfilesasync_1429382825.md), [GetFilesAsync](folderinformation_getfilesasync_819750470.md)