---
-api-id: T:Windows.Storage.Search.CommonFolderQuery
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.CommonFolderQuery : int
-->

# CommonFolderQuery

## -description
Specifies how to group files into folders in the query results and determines whether the query is shallow or deep. Query results for deep queries include all files in all of the subfolders of the current folder, grouped into folders according to the specified option.

## -enum-fields
### -field DefaultQuery:0
A shallow list of the folders in the current folder, similar to the view that File Explorer provides.

You can use this option for any storage location.

### -field GroupByYear:100
Group files into virtual folders by year based on the [System.ItemDate](XREF:TODO:properties.props_System_ItemDate) property of each file. Each folder will contain all (and only) files that have values for [System.ItemDate](XREF:TODO:properties.props_System_ItemDate) within the same year.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByMonth:101
Group files into virtual folders by month based on the [System.ItemDate](XREF:TODO:properties.props_System_ItemDate) property of each file. Each folder will contain all (and only) files that have values for [System.ItemDate](XREF:TODO:properties.props_System_ItemDate) within the same month.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByArtist:102
Group files into virtual folders based on the [System.Music.Artist](XREF:TODO:properties.props_System_Music_Artist) property of each file. Each folder will contain all (and only) files with identical values for [System.Music.Artist](XREF:TODO:properties.props_System_Music_Artist).

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByAlbum:103
Group files into virtual folders by year based on the [System.Music.AlbumTitle](XREF:TODO:properties.props_System_Music_AlbumTitle) property of each file. Each folder will contain all (and only) files with identical values for [System.Music.AlbumTitle](XREF:TODO:properties.props_System_Music_AlbumTitle).

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByAlbumArtist:104
Group files into virtual folders based on the [System.Music.AlbumArtist](XREF:TODO:properties.props_System_Music_AlbumArtist) property of each file. Each folder will contain all (and only) files with identical values for [System.Music.AlbumArtist](XREF:TODO:properties.props_System_Music_AlbumArtist).

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByComposer:105
Group files into virtual folders based on the [System.Music.Composer](XREF:TODO:properties.props_System_Music_Composer) property of each file. Each folder will represent one composer, and contain all files whose [System.Music.Composer](XREF:TODO:properties.props_System_Music_Composer) vector contains that composer. If a file lists multiple composers, it may appear in more than one of the resulting folders.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByGenre:106
Group files into virtual folders based on the [System.Music.Genre](XREF:TODO:properties.props_System_Music_Genre) property of each file. Each folder will contain all (and only) files with identical values for [System.Music.Genre](XREF:TODO:properties.props_System_Music_Genre).

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByPublishedYear:107
Group files into virtual folders by year based on the [System.Media.Year](XREF:TODO:properties.props_System_Media_Year) property of each file. Each folder will contain all (and only) files that have values for [System.Media.Year](XREF:TODO:properties.props_System_Media_Year) within the same year.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByRating:108
Group files into virtual folders by rating (1 star, 2 stars, and so on) based on the [System.Rating](XREF:TODO:properties.props_System_Rating) property of each file. Each folder will contain all (and only) files with identical values for [System.Rating](XREF:TODO:properties.props_System_Rating).

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByTag:109
Group files into virtual folders based on the [System.Keywords](XREF:TODO:properties.props_System_Keywords) property of each file. Each folder will represent one tag, and contain all files whose [System.Keywords](XREF:TODO:properties.props_System_Keywords) vector contains that tag. If a file lists multiple tags in its [System.Keywords](XREF:TODO:properties.props_System_Keywords) vector, it may appear in more than one of the resulting folders.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByAuthor:110
Group files into virtual folders based on the [System.Author](XREF:TODO:properties.props_System_Author) property of each file. Each folder will represent one author, and contain all files whose [System.Author](XREF:TODO:properties.props_System_Author) vector contains that author. If a file lists multiple authors, it may appear in more than one of the resulting folders.

You can use this option only for folders in a library or the HomeGroup folder.

### -field GroupByType:111
Group files into virtual folders by type (for example, Microsoft Word documents, text files, and so forth) based on the [System.ItemTypeText](XREF:TODO:properties.props_System_ItemTypeText) property of each file.

You can use this option only for folders in a library or the HomeGroup folder.


## -remarks
Use a value from the [CommonFolderQuery](commonfolderquery.md) enumeration when you call one of the following methods of the [StorageFolder](../windows.storage/storagefolder.md) class. For examples that use values from the [CommonFolderQuery](commonfolderquery.md) enumeration, see the topics for these methods.

+ [CreateFolderQuery(CommonFolderQuery)](../windows.storage/storagefolder_createfolderquery_330767063.md)
+ [CreateFolderQueryWithOptions](istoragefolderqueryoperations_createfolderquerywithoptions.md). Instantiate the [QueryOptions](queryoptions_queryoptions.md) with the [QueryOptions(CommonFolderQuery)](queryoptions_queryoptions_1209951623.md) constructor.
+ [CreateItemQueryWithOptions](../windows.storage/storagefolder_createitemquerywithoptions.md). Instantiate the [QueryOptions](queryoptions_queryoptions.md) with the [QueryOptions(CommonFolderQuery)](queryoptions_queryoptions_1209951623.md) constructor.
+ [GetFoldersAsync(CommonFolderQuery)](../windows.storage/storagefolder_getfoldersasync_595997124.md)
+ [GetFoldersAsync(CommonFolderQuery, UInt32, UInt32)](../windows.storage/storagefolder_getfoldersasync_731846614.md)
These methods use the value from the [CommonFolderQuery](commonfolderquery.md) enumeration to initialize the [DateStackOption](queryoptions_datestackoption.md), [FolderDepth](queryoptions_folderdepth.md), [IndexerOption](queryoptions_indexeroption.md), and [SortOrder](queryoptions_sortorder.md) options of the query.

Call the [StorageFolder.IsCommonFolderQuerySupported](../windows.storage/storagefolder_iscommonfolderquerysupported.md) method to determine whether the [CommonFolderQuery](commonfolderquery.md) value that you want to use is available for the current folder.

> > [!TIP]
> When a query groups files into virtual folders based on a property that can have multiple values (for example, [System.Author](XREF:TODO:properties.props_System_Author)), a particular file may appear in more than one virtual folder because each folder represents one of the multiple values.

Files that don't have a value for the property that the query uses to group files are typically excluded from query results.

## -examples

## -see-also
[queryOptions class](queryoptions_queryoptions.md), [Windows.Storage.storageFolder class](../windows.storage/storagefolder.md), [Folder enumeration sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619993)