---
-api-id: T:Windows.Storage.Search.CommonFileQuery
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.CommonFileQuery : int
-->

# CommonFileQuery

## -description
Specifies how to sort the files in the query results and determines whether the query is shallow or deep. Query results for deep queries include all files in all of the subfolders of the current folder, sorted according to the specified option.

## -enum-fields
### -field DefaultQuery:0
A shallow list of files in the current folder, similar to the list that File Explorer provides.

You can use this option for any storage location.

### -field OrderByName:1
A deep, flat list of files in a folder and its subfolders, sorted by [System.ItemNameDisplay](XREF:TODO:properties.props_System_ItemNameDisplay).

You can use this option for any storage location.

### -field OrderByTitle:2
A deep, flat list of files in a folder and its subfolders, sorted by [System.Title](XREF:TODO:properties.props_System_Title).

You can use this option only for folders in a library or the HomeGroup folder.

### -field OrderByMusicProperties:3
A deep, flat list of files in a folder and its subfolders, sorted by music properties.

You can use this option only for folders in a library or the HomeGroup folder.

### -field OrderBySearchRank:4
A deep, flat list of files in a folder and its subfolders, sorted by [System.Search.Rank](XREF:TODO:properties.props_System_Search_Rank) followed by [System.DateModified](XREF:TODO:properties.props_System_DateModified).

You can use this option for any storage location.

### -field OrderByDate:5
A deep, flat list of files in a folder and its subfolders, sorted by [System.ItemDate](XREF:TODO:properties.props_System_ItemDate).

You can use this option only for folders in a library or the HomeGroup folder.

> [!NOTE]
> [System.ItemDate](XREF:TODO:properties.props_System_ItemDate) is a computed property that changes based on the content type; for example, it maps to [System.Photo.DateTaken](XREF:TODO:properties.props_System_Photo_DateTaken) for photos.


## -remarks
Use a value from the [CommonFileQuery](commonfilequery.md) enumeration when you call one of the following methods of the [StorageFolder](../windows.storage/storagefolder.md) class. For examples that use values from the [CommonFileQuery](commonfilequery.md) enumeration, see the topics for these methods.

+ [CreateFileQuery(CommonFileQuery)](../windows.storage/storagefolder_createfilequery_1641434999.md)
+ [CreateFileQueryWithOptions](../windows.storage/storagefolder_createfilequerywithoptions.md). Instantiate the [QueryOptions](queryoptions_queryoptions.md) with the [QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md) constructor.
+ [CreateItemQueryWithOptions](../windows.storage/storagefolder_createitemquerywithoptions.md). Instantiate the [QueryOptions](queryoptions_queryoptions.md) with the [QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md) constructor.
+ [GetFilesAsync(CommonFileQuery)](../windows.storage/storagefolder_getfilesasync_1429382825.md)
+ [GetFilesAsync(CommonFileQuery, UInt32, UInt32)](../windows.storage/storagefolder_getfilesasync_1563132095.md)
These methods use the value from the [CommonFileQuery](commonfilequery.md) enumeration to initialize the [FolderDepth](queryoptions_folderdepth.md), [IndexerOption](queryoptions_indexeroption.md), and [SortOrder](queryoptions_sortorder.md) options of the query.

Call the [StorageFolder.IsCommonFileQuerySupported](../windows.storage/storagefolder_iscommonfilequerysupported.md) method to determine whether the [CommonFileQuery](commonfilequery.md) value that you want to use is available for the current folder.

> > [!TIP]
> Files that don't have a value for the property that the query uses to sort files are typically excluded from query results.

## -examples

## -see-also
[Folder enumeration sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619993)