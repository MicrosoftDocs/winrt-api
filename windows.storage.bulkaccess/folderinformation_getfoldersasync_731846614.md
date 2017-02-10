---
-api-id: M:Windows.Storage.BulkAccess.FolderInformation.GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery query, System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.BulkAccess.FolderInformation.GetFoldersAsync

## -description
Retrieves a range of child folders from the current folder based on a common folder query.

## -parameters
### -param query
The common folder query.

### -param startIndex
The zero-based index of the first child folder in the range.

### -param maxItemsToRetrieve
The maximum number of child folders to retrieve.

## -returns
When this method completes successfully, it returns the list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of child folders. Each child folder in this list is represented by a [StorageFolder](../windows.storage/storagefolder.md) object.

## -remarks

## -examples

## -see-also
[GetFoldersAsync(CommonFolderQuery)](folderinformation_getfoldersasync_595997124.md), [GetFoldersAsync](folderinformation_getfoldersasync_592765033.md)