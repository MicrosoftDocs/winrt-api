---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery query)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.GetFoldersAsync

## -description
Retrieves a list of folders and file groups based on a specified folder query. This returns a snapshot of the folders or file groups at a point in time and does not allow you to keep track of changes through events.

## -parameters
### -param query
The type of folder query to perform.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of folders of file groups that are represented by [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks

## -examples

## -see-also
[IStorageFolderQueryOperations interface](istoragefolderqueryoperations.md), [IStorageFolderQueryOperations.GetFoldersAsync methods](istoragefolderqueryoperations_getfoldersasync_595997124.md), [IStorageFolderQueryOperations.GetFoldersAsync(CommonFolderQuery, UInt32, UInt32) method](istoragefolderqueryoperations_getfoldersasync_731846614.md), [Windows.Foundation.IVectorView interface](../windows.foundation.collections/ivectorview_1.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)