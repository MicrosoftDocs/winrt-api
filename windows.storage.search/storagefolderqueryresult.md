---
-api-id: T:Windows.Storage.Search.StorageFolderQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFolderQueryResult : Windows.Storage.Search.IStorageFolderQueryResult, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageFolderQueryResult

## -description

Provides access to the results of a query that lists the folder (or file groups) in the folder being queried (which is represented by a [StorageFolder](../windows.storage/storagefolder.md)). You can use a StorageFolderQueryResult to enumerate folders or file groups in that folder.

## -remarks

> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).
<!--W8B 988884 v2-->

You can get a StorageFolderQueryResult object by calling the following methods from a [StorageFolder](../windows.storage/storagefolder.md) or a [FolderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [StorageFolder.CreateFolderQuery methods](../windows.storage/storagefolder_createfolderquery_325438332.md)
+ [StorageFolder.CreateFolderQueryWithOptions method](../windows.storage/storagefolder_createfolderquerywithoptions_573382953.md)
+ [FolderInformation.CreateFolderQuery methods](../windows.storage.bulkaccess/folderinformation_createfolderquery_325438332.md)
+ [FolderInformation.CreateFolderQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createfolderquerywithoptions_573382953.md)

For more code examples that show you how to use storageFolderQueryResult objects, see the [Folder enumeration sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/FolderEnumeration).

To get a StorageFolderQueryResult object to enumerate the folders or file groups in a location, you must get a [storageFolder](../windows.storage/storagefolder.md) that represents the location and then create a folder query.

## -examples

This example demonstrates how to get a list folders (or file groups) from a StorageFolderQueryResult object.

```csharp

// Get the Pictures library
Windows.Storage.StorageFolder picturesLibrary = Windows.Storage.KnownFolders.PicturesLibrary;

// Set query options to create groups of files within result
QueryOptions queryOptions = new QueryOptions(Windows.Storage.Search.CommonFolderQuery.GroupByMonth);

// Create query and retrieve result
StorageFolderQueryResult queryResult = picturesLibrary.CreateFolderQueryWithOptions(queryOptions);
IReadOnlyList<StorageFolder> folders = await queryResult.GetFoldersAsync();
// Process file groups
foreach (StorageFolder folder in folders)
{
    // Get and process files in group
    IReadOnlyList<StorageFile> fileList = await folder.GetFilesAsync();
    OutputPanel.Children.Add(CreateHeaderTextBlock(folder.Name + " (" + fileList.Count + ")"));
    foreach (StorageFile file in fileList)
    {
        // Process file
    }
}
```

The `queryResult` variable gets the StorageFolderQueryResult that is used to retrieve file groups (or folders) that meet the criteria of the query.

> [!NOTE]
> You need the Pictures library capability to access the library using [KnownFolders.PicturesLibrary](../windows.storage/knownfolders_pictureslibrary.md). To learn more about capabilities and file access, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -see-also

[Windows.Storage.storageFolder.createFolderQuery methods](../windows.storage/storagefolder_createfolderquery_325438332.md), [Windows.Storage.storageFolder.createFolderQueryWithOptions method](../windows.storage/storagefolder_createfolderquerywithoptions_573382953.md), [Windows.Storage.BulkAccess.folderInformation.createFolderQuery methods](../windows.storage.bulkaccess/folderinformation_createfolderquery_325438332.md), [Windows.Storage.BulkAccess.folderInformation.createFolderQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createfolderquerywithoptions_573382953.md), [Folder enumeration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)
