---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.GetFilesAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.BulkAccess.FileInformation>> GetFilesAsync(System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.GetFilesAsync

## -description
Retrieves a collection of [FileInformation](fileinformation.md) objects that contain information about a range of [StorageFile](../windows.storage/storagefile.md) objects in a collection.

## -parameters
### -param startIndex
The zero-based index of the first [StorageFile](../windows.storage/storagefile.md) in the range.

### -param maxItemsToRetrieve
The maximum number of [StorageFile](../windows.storage/storagefile.md) objects to retrieve information for.

## -returns
When this method completes successfully, it returns the list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [FileInformation](fileinformation.md) objects.

## -remarks

## -examples

## -see-also
[GetFilesAsync](fileinformationfactory_getfilesasync_819750470.md)