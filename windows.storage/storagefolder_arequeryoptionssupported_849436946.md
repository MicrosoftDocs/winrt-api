---
-api-id: M:Windows.Storage.StorageFolder.AreQueryOptionsSupported(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public bool AreQueryOptionsSupported(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.StorageFolder.AreQueryOptionsSupported

## -description
Indicates whether the current folder supports the specified [QueryOptions](../windows.storage.search/queryoptions.md).

## -parameters
### -param queryOptions
The [QueryOptions](../windows.storage.search/queryoptions.md) to check.

## -returns
True if the folder or file group supports the specified [QueryOptions](../windows.storage.search/queryoptions.md); otherwise false.

## -remarks
[QueryOptions](../windows.storage.search/queryoptions.md) let you enumerate files in a folder and its subfolders by letting you specify criteria that you can then use to create a query result object of files in that folder and subfolders. The [CommonFileQuery](../windows.storage.search/commonfilequery.md) and [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration represent some of the most common criteria used to filter and enumerate files and folders.

Use the [AreQueryOptionsSupported](storagefolder_arequeryoptionssupported.md) method to verify that the [QueryOptions](../windows.storage.search/queryoptions.md) you want to specify are available for the current folder. You can also check whether a specific [CommonFileQuery](../windows.storage.search/commonfilequery.md) or [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) value is available, by calling [IsCommonFileQuerySupported](storagefolder_iscommonfilequerysupported.md) or [IsCommonFolderQuerySupported](storagefolder_iscommonfolderquerysupported.md), respectively.

The specific options available to you depend on where the files or folders that you want to enumerate are located. For folders and files that are located inside a library or homegroup, you can use any combination of [QueryOptions](../windows.storage.search/queryoptions.md).


<!--{annotation author="miriamw" time="3/5/2012 4:02:04 PM"}TODO: Change for RC (from katiebl) orderByName/orderBySearchRank will not be supported at the root node for MediaServerDevices RC+-->
Folders and files outside of a library or homegroup support a only subset of options.

+ For queries that enumerate only the top-level files or folders (also known as a shallow query), create a [QueryOptions](../windows.storage.search/queryoptions.md) object in one of the following three ways:

   + Call the default [QueryOptions()](../windows.storage.search/queryoptions_queryoptions_1221375020.md) constructor.
   + Call the [QueryOptions(CommonFolderQuery)](../windows.storage.search/queryoptions_queryoptions_1209951623.md) constructor and specify [CommonFolderQuery](../windows.storage.search/commonfolderquery.md).[DefaultQuery](../windows.storage.search/commonfolderquery.md).
   + Call the [QueryOptions(CommonFileQuery, IIterable(String))](../windows.storage.search/queryoptions_queryoptions_811500193.md) constructor and specify [CommonFileQuery](../windows.storage.search/commonfilequery.md).[DefaultQuery](../windows.storage.search/commonfilequery.md). You can still specify file types to be filtered when you use this constructor.

+ For queries that enumerate all of the files inside the current folder and its subfolders (also known as a deep query), create a [QueryOptions](../windows.storage.search/queryoptions.md) object in one of the following two ways:

   + Call the [QueryOptions(CommonFolderQuery)](../windows.storage.search/queryoptions_queryoptions_1209951623.md) constructor and specify [CommonFileQuery](../windows.storage.search/commonfilequery.md).[OrderByName](../windows.storage.search/commonfilequery.md) or [CommonFileQuery](../windows.storage.search/commonfilequery.md).[OrderBySearchRank](../windows.storage.search/commonfilequery.md).
   + Call the [QueryOptions(CommonFileQuery, IIterable(String))](../windows.storage.search/queryoptions_queryoptions_811500193.md) constructor and specify [CommonFileQuery](../windows.storage.search/commonfilequery.md).[OrderByName](../windows.storage.search/commonfilequery.md) or [CommonFileQuery](../windows.storage.search/commonfilequery.md).[OrderBySearchRank](../windows.storage.search/commonfilequery.md). You can still specify file types to be filtered when you use this constructor.

> **For Windows Server 2012**
> You must install indexer components to use some [QueryOptions](../windows.storage.search/queryoptions.md), [CommonFileQuery](../windows.storage.search/commonfilequery.md) values, and [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) values because indexer components are not installed by default.



## -examples

## -see-also
