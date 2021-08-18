---
-api-id: M:Windows.Storage.StorageFolder.CreateFolderQueryWithOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFolderQueryResult CreateFolderQueryWithOptions(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.StorageFolder.CreateFolderQueryWithOptions

## -description
Gets a query result object that contains the subfolders in the current folder and, optionally, nested subfolders. The results are based on the specified [QueryOptions](../windows.storage.search/queryoptions.md).

## -parameters
### -param queryOptions
The criteria that are applied to the query.

## -returns
A query result object. Call the [GetFoldersAsync](../windows.storage.search/storagefolderqueryresult_getfoldersasync_1487375516.md) method of the query result to get the subfolders in the current folder. If you provided a [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) value other than [CommonFolderQuery.DefaultQuery](../windows.storage.search/commonfolderquery.md) when you instantiated the [QueryOptions](../windows.storage.search/queryoptions.md), the query result object contains a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *queryOptions*. The list is of type **IReadOnlyList**&lt;[StorageFolder](storagefolder.md)&gt;. Each folder in the list is represented by a [StorageFolder](storagefolder.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

## -remarks
For more information and examples on getting query result objects, see [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md).

## -examples

## -see-also
