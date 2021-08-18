---
-api-id: M:Windows.Storage.StorageFolder.CreateFileQuery(Windows.Storage.Search.CommonFileQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFileQueryResult CreateFileQuery(Windows.Storage.Search.CommonFileQuery query)
-->

# Windows.Storage.StorageFolder.CreateFileQuery

## -description
Gets a query result object that contains the files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than [CommonFileQuery.DefaultQuery](../windows.storage.search/commonfilequery.md). Files are sorted based on the specified [CommonFileQuery](../windows.storage.search/commonfilequery.md).

## -parameters
### -param query
One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.

## -returns
A query result object. Call the [GetFilesAsync](../windows.storage.search/storagefilequeryresult_getfilesasync_1261374131.md) method of the query result to get the flat list of files, sorted as specified by *query*. This method returns a list of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file is represented by an item of type [StorageFile](storagefile.md).

## -exceptions
### T:System.ArgumentException

You specified a value other than **DefaultQuery** from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration for a folder that's not a library folder. Check the value of *query*.

## -remarks
A [CommonFileQuery](../windows.storage.search/commonfilequery.md) sorts files based on specific file attributes (like title or date) quickly and easily.

When you specify the **DefaultQuery** option from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration, this query is a shallow query that returns only files in the current folder. When you specify another value from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration, this query is a deep query that returns a flattened list of files from the current folder and from its subfolders.

> > [!TIP]
> Some of the values from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration can only be used with a library folder (such as the Pictures library) or the Homegroup folder. In addition to the **DefaultQuery** option, you can use only the **OrderByName** and **OrderBySearchRank** options with a folder that's not a library folder.

For a list of methods that identifies shallow queries and deep queries, see the Remarks in the topic [GetFilesAsync](storagefolder_getfilesasync_1429382825.md).

To check whether a specific [CommonFileQuery](../windows.storage.search/commonfilequery.md) is available, call the folder's [IsCommonFileQuerySupported](storagefolder_iscommonfilequerysupported_1848755604.md) method.

You can also get a list of files in the current folder asynchronously by calling one of the [GetFilesAsync](storagefolder_getfilesasync_1429382825.md) methods.

> **For Windows Server 2012**
> You must install indexer components to use some [CommonFileQuery](../windows.storage.search/commonfilequery.md) values because indexer components are not installed by default.



## -examples

## -see-also
[CreateFileQuery](storagefolder_createfilequery_70815642.md), [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md)