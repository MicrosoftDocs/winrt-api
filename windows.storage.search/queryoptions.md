---
-api-id: T:Windows.Storage.Search.QueryOptions
-api-type: winrt class
---

<!-- Class syntax.
public class QueryOptions : Windows.Storage.Search.IQueryOptions, Windows.Storage.Search.IQueryOptionsWithProviderFilter
-->

# Windows.Storage.Search.QueryOptions

## -description

Specifies the parameters of a search query for enumerating the contents of storage folders.

## -remarks

You can create a file query for any folder you have access to and that you can get as a [StorageFolder](../windows.storage/storagefolder.md).

You can use [QueryOptions](queryoptions.md) and [CreateFileQueryWithOptions](../windows.storage/storagefolder_createfilequerywithoptions.md) to create an indexed backed file query that lets you get properties that rely on another app's property handler.

## -examples

This example demonstrates how to use [QueryOptions](queryoptions.md) to query files in a location.

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

This example demonstrates how to use a file query that is backed by the system index to retrieve properties that may rely on another app's property handler (like [Title](../windows.storage.fileproperties/documentproperties_title.md) document property).

```csharp

try
{
    // Create index backed file query and get results
    List<string> fileTypeFilter = new List<string>();
    fileTypeFilter.Add(".png");
    QueryOptions queryOptions = new QueryOptions(Windows.Storage.Search.CommonFileQuery.OrderByName, fileTypeFilter);
    queryOptions.IndexerOption = IndexerOption.OnlyUseIndexer;
    StorageFileQueryResult queryResult = Windows.Storage.KnownFolders.PicturesLibrary.CreateFileQueryWithOptions(queryOptions);
    var files = await queryResult.GetFilesAsync();

    // Process resulting files
    if (files.Count == 0)
    {
        // Perform tasks to handle no files found
    }
    else
    {
        // Access properties for each file
        foreach (StorageFile file in files)
        {
            var documentProperties = await file.Properties.GetDocumentPropertiesAsync();
            // Perform tasks with document properties
            String title = documentProperties.Title;
        }
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
 // For example, handle a file not found error
}
```

```javascript

// Create index backed file query and get results
var picturesLibrary = Windows.Storage.KnownFolders.picturesLibrary;
var fileTypeFilter = [".png"];
var queryOptions = new Windows.Storage.Search.QueryOptions(Windows.Storage.Search.CommonFileQuery.orderByName, fileTypeFilter);
queryOptions.indexerOption = Windows.Storage.Search.IndexerOption.onlyUseIndexer;
var fileQuery = picturesLibrary.createFileQueryWithOptions(queryOptions);
fileQuery.getFilesAsync().then(function (files) {
    // Process resulting files
    if (files.size === 0) {
        // Perform tasks to handle no files found
    } else {
        // Access properties for each file
        files.forEach(function (file) {
            // Get document properties
            file.properties.getDocumentPropertiesAsync().done(function (documentProperties) {
                // Perform tasks with document properties
                var title = documentProperties.title;
            });
        });
    }
},
// Handle errors with an error function
function (error) {
    // Handle errors encountered while processing files
});
```

## -see-also

[File search sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620544), [Folder enumeration sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)