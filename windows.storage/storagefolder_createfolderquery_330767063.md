---
-api-id: M:Windows.Storage.StorageFolder.CreateFolderQuery(Windows.Storage.Search.CommonFolderQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFolderQueryResult CreateFolderQuery(Windows.Storage.Search.CommonFolderQuery query)
-->

# Windows.Storage.StorageFolder.CreateFolderQuery

## -description
Gets a query result object that contains the subfolders in the current folder. When the value of the *query* argument is something other than [CommonFolderQuery.DefaultQuery](../windows.storage.search/commonfolderquery.md), gets a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. Files are grouped into folders based on the specified value from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration.

## -parameters
### -param query
One of the enumeration values that specifies how to group the files into folders and determines whether the query is shallow or deep.

## -returns
A query result object. Call the [GetFoldersAsync](../windows.storage.search/storagefolderqueryresult_getfoldersasync_1487375516.md) method of the query result to get the subfolders in the current folder. When the value of the *query* argument is something other than [CommonFolderQuery.DefaultQuery](../windows.storage.search/commonfolderquery.md), the query result object contains a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *query*. The list is of type **IReadOnlyList**&lt;[StorageFolder](storagefolder.md)&gt;. Each folder in the list is represented by a [StorageFolder](storagefolder.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

### T:System.ArgumentException

You specified a value other than **DefaultQuery** from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration for a folder that's not a library folder. Check the value of *query*.

## -remarks
A [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) groups the contents of subfolders into folders based on specific file attributes (like artist or album) quickly and easily. See the Remarks on the [CreateFileQuery](storagefolder_createfilequery_1641434999.md) method page for more information about specifying **DefaultQuery** options.

## -examples

## -see-also
[CreateFolderQuery](storagefolder_createfolderquery_325438332.md)