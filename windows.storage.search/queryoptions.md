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

You can use QueryOptions and [CreateFileQueryWithOptions](../windows.storage/storagefolder_createfilequerywithoptions_2038131323.md) to create an indexed backed file query that lets you get properties that rely on another app's property handler.

## -examples

This example demonstrates how to use QueryOptions to query files in a location.

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

## -see-also

[File search sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileSearch), [Folder enumeration sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)
