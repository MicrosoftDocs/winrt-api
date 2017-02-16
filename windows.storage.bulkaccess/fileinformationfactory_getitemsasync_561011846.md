---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.GetItemsAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.BulkAccess.IStorageItemInformation>> GetItemsAsync(System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.GetItemsAsync

## -description
Retrieves a collection of [IStorageItemInformation](fileinformation.md) objects that contain information about a range of items in a collection.

## -parameters
### -param startIndex
The zero-based index of the first item in the range.

### -param maxItemsToRetrieve
The maximum number of items to retrieve information for.

## -returns
When this method completes successfully, it returns the list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [FileInformation](fileinformation.md) and [FolderInformation](folderinformation.md) objects.

## -remarks

## -examples

## -see-also
[GetItemsAsync](fileinformationfactory_getitemsasync_1518547059.md)