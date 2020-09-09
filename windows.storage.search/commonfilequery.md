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

A deep, flat list of files in a folder and its subfolders, sorted by [System.ItemNameDisplay](/windows/desktop/properties/props-system-itemnamedisplay).

You can use this option for any storage location.

### -field OrderByTitle:2

A deep, flat list of files in a folder and its subfolders, sorted by [System.Title](/windows/desktop/properties/props-system-title).

You can use this option only for folders in a library or the HomeGroup folder.

### -field OrderByMusicProperties:3

A deep, flat list of files in a folder and its subfolders, sorted by music properties.

You can use this option only for folders in a library or the HomeGroup folder.

### -field OrderBySearchRank:4

A deep, flat list of files in a folder and its subfolders, sorted by [System.Search.Rank](/windows/desktop/properties/props-system-search-rank) followed by [System.DateModified](/windows/desktop/properties/props-system-datemodified).

You can use this option for any storage location.

### -field OrderByDate:5

A deep, flat list of files in a folder and its subfolders, sorted by [System.ItemDate](/windows/desktop/properties/props-system-itemdate).

You can use this option only for folders in a library or the HomeGroup folder.

> [!NOTE]
> [System.ItemDate](/windows/desktop/properties/props-system-itemdate) is a computed property that changes based on the content type; for example, it maps to [System.Photo.DateTaken](/windows/desktop/properties/props-system-photo-datetaken) for photos.

## -remarks

Use a value from the CommonFileQuery enumeration when you call one of the following methods of the [StorageFolder](../windows.storage/storagefolder.md) class. For examples that use values from the CommonFileQuery enumeration, see the topics for these methods.

+ [CreateFileQuery(CommonFileQuery)](../windows.storage/storagefolder_createfilequery_1641434999.md)
+ [CreateFileQueryWithOptions](../windows.storage/storagefolder_createfilequerywithoptions_2038131323.md). Instantiate the [QueryOptions](queryoptions_queryoptions_1209951623.md) with the [QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md) constructor.
+ [CreateItemQueryWithOptions](../windows.storage/storagefolder_createitemquerywithoptions_1519361285.md). Instantiate the [QueryOptions](queryoptions_queryoptions_1209951623.md) with the [QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md) constructor.
+ [GetFilesAsync(CommonFileQuery)](../windows.storage/storagefolder_getfilesasync_1429382825.md)
+ [GetFilesAsync(CommonFileQuery, UInt32, UInt32)](../windows.storage/storagefolder_getfilesasync_1563132095.md)

These methods use the value from the CommonFileQuery enumeration to initialize the [FolderDepth](queryoptions_folderdepth.md), [IndexerOption](queryoptions_indexeroption.md), and [SortOrder](queryoptions_sortorder.md) options of the query.

Call the [StorageFolder.IsCommonFileQuerySupported](../windows.storage/storagefolder_iscommonfilequerysupported_1848755604.md) method to determine whether the CommonFileQuery value that you want to use is available for the current folder.

> > [!TIP]
> Files that don't have a value for the property that the query uses to sort files are typically excluded from query results.

## -examples

## -see-also

[Folder enumeration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)
