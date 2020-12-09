---
-api-id: T:Windows.Storage.Search.StorageFileQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFileQueryResult : Windows.Storage.Search.IStorageFileQueryResult, Windows.Storage.Search.IStorageFileQueryResult2, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageFileQueryResult

## -description

Provides access to the results of a query of the files in the location that is represented by a [StorageFolder](../windows.storage/storagefolder.md) object. You can use StorageFileQueryResult to enumerate the files in that [StorageFolder](../windows.storage/storagefolder.md) location.

## -remarks

> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile.
<!--W8B 988884 v2-->

You can get a StorageFileQueryResult object by calling the following methods from a [StorageFolder](../windows.storage/storagefolder.md) or a [FolderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [StorageFolder.CreateFileQuery methods](istoragefolderqueryoperations_createfilequery_1641434999.md)
+ [StorageFolder.CreateFileQueryWithOptions method](../windows.storage/storagefolder_createfilequerywithoptions_2038131323.md)
+ [FolderInformation.CreateFileQuery methods](../windows.storage.bulkaccess/folderinformation_createfilequery_1641434999.md)
+ [FolderInformation.CreateFileQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createfilequerywithoptions_2038131323.md)

## -examples

This example demonstrates how to get a list of files from a StorageFileQueryResult object.

```csharp
// Set query options with filter and sort order for results
List<string> fileTypeFilter = new List<string>();
fileTypeFilter.Add(".jpg");
fileTypeFilter.Add(".png");
fileTypeFilter.Add(".bmp");
fileTypeFilter.Add(".gif");
var queryOptions = new QueryOptions(CommonFileQuery.OrderByName, fileTypeFilter);

// Create query and retrieve files
var query = KnownFolders.PicturesLibrary.CreateFileQueryWithOptions(queryOptions);
IReadOnlyList<StorageFile> fileList = await query.GetFilesAsync();
// Process results
foreach (StorageFile file in fileList)
{
    // Process file
}
```

The `query` variable gets the StorageFileQueryResult that is used to retrieve files that meet the criteria of the query.

> [!NOTE]
> You need the Pictures library capability to access the library using [KnownFolders.PicturesLibrary](../windows.storage/knownfolders_pictureslibrary.md). To learn more about capabilities and file access, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -see-also

[Windows.Storage.storageFolder.createFileQuery methods](istoragefolderqueryoperations_createfilequery_1641434999.md), [Windows.Storage.storageFolder.createFileQueryWithOptions method](../windows.storage/storagefolder_createfilequerywithoptions_2038131323.md), [Windows.Storage.BulkAccess.folderInformation.createFileQuery](../windows.storage.bulkaccess/folderinformation_createfilequery_1641434999.md), [Windows.Storage.BulkAccess.folderInformation.createFileQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createfilequerywithoptions_2038131323.md), [File search sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileSearch), [Folder enumeration sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)
