---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.GetFoldersAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.BulkAccess.FolderInformation>> GetFoldersAsync(System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.GetFoldersAsync

## -description
Retrieves a collection of [FolderInformation](folderinformation.md) objects that contain information about a range of [StorageFolder](../windows.storage/storagefolder.md) objects in a collection.

## -parameters
### -param startIndex
The zero-based index of the first [StorageFolder](../windows.storage/storagefolder.md) in the range.

### -param maxItemsToRetrieve
The maximum number of [StorageFolder](../windows.storage/storagefolder.md) objects to retrieve information for.

## -returns
When this method completes successfully, it returns the list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [FolderInformation](folderinformation.md) objects.

## -remarks

## -examples

## -see-also
[GetFoldersAsync](fileinformationfactory_getfoldersasync_592765033.md)