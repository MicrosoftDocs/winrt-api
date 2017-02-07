---
-api-id: T:Windows.Storage.Search.StorageFileQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFileQueryResult : Windows.Storage.Search.IStorageFileQueryResult, Windows.Storage.Search.IStorageFileQueryResult2, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageFileQueryResult

## -description
Provides access to the results of a query of the files in the location that is represented by a [storageFolder](../windows.storage/storagefolder.md) object. You can use [storageFileQueryResult](storagefilequeryresult.md) to enumerate the files in that [storageFolder](../windows.storage/storagefolder.md) location.

## -remarks
> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile.
<!--W8B 988884 v2-->

You can get a [storageFileQueryResult](storagefilequeryresult.md) object by calling the following methods from a [storageFolder](../windows.storage/storagefolder.md) or a [folderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [storageFolder.createFileQuery methods](istoragefolderqueryoperations_createfilequery.md)
+ [storageFolder.createFileQueryWithOptions method](../windows.storage/storagefolder_createfilequerywithoptions.md)
+ [folderInformation.createFileQuery methods](../windows.storage.bulkaccess/folderinformation_createfilequery.md)
+ [folderInformation.createFileQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createfilequerywithoptions.md)


## -examples
This example demonstrates how to get a list of files from a [storageFileQueryResult](storagefilequeryresult.md) object.

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

```javascript

// Set query options with filter and sort order for results
var fileTypeFilter = [".jpg", ".png", ".bmp", ".gif"];
var queryOptions = new Windows.Storage.Search.QueryOptions(search.CommonFileQuery.orderByName, fileTypeFilter);

// Create query and retrieve files
var query = Windows.Storage.KnownFolders.picturesLibrary.createFileQueryWithOptions(queryOptions);
query.getFilesAsync().done(function (files) {
    // Process results
    files.forEach(function (file) {
        // Process file
    });
});
```

The `query` variable gets the [storageFileQueryResult](storagefilequeryresult.md) that is used to retrieve files that meet the criteria of the query.

> [!NOTE]
> You need the Pictures library capability to access the library using [KnownFolders.PicturesLibrary](../windows.storage/knownfolders_pictureslibrary.md). To learn more about capabilities and file access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

## -see-also
[Windows.Storage.storageFolder.createFileQuery methods](istoragefolderqueryoperations_createfilequery.md), [Windows.Storage.storageFolder.createFileQueryWithOptions method](../windows.storage/storagefolder_createfilequerywithoptions.md), [Windows.Storage.BulkAccess.folderInformation.createFileQuery](../windows.storage.bulkaccess/folderinformation_createfilequery.md), [Windows.Storage.BulkAccess.folderInformation.createFileQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createfilequerywithoptions.md), [File search sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620544)