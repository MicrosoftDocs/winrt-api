---
-api-id: M:Windows.Storage.StorageFolder.CreateItemQueryWithOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageItemQueryResult CreateItemQueryWithOptions(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.StorageFolder.CreateItemQueryWithOptions

## -description
Gets a query result object that contains the files and subfolders in the current folder and, optionally, in the subfolders of the current folder. The results are based on the specified [QueryOptions](../windows.storage.search/queryoptions.md).

## -parameters
### -param queryOptions
The criteria that are applied to the query.

## -returns
A query result object. Call the [GetItemsAsync](../windows.storage.search/storageitemqueryresult_getitemsasync_1518547059.md) method of the query result to get the files and subfolders in the current folder and, optionally, in the subfolders of the current folder, filtered and sorted based on the specified [QueryOptions](../windows.storage.search/queryoptions.md). This method returns a list of type **IReadOnlyList**&lt;[IStorageItem](istorageitem.md)&gt;. Each file or folder is represented by an item of type [IStorageItem](istorageitem.md).

To work with the returned items, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether each item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

### T:System.ArgumentException

You specified a value other than **DefaultQuery** from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) or [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration for a folder that's not a library folder.

## -remarks
For more information and examples on getting query result objects, see [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md).

## -examples

## -see-also
