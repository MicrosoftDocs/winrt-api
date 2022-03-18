---
-api-id: T:Windows.Storage.FileProperties.DocumentProperties
-api-type: winrt class
---

<!-- Class syntax.
public class DocumentProperties : Windows.Storage.FileProperties.IDocumentProperties, Windows.Storage.FileProperties.IStorageItemExtraProperties
-->

# Windows.Storage.FileProperties.DocumentProperties

## -description
Provides access to the document-related properties of an item (like a file or folder).

## -remarks
You can access a DocumentProperties object asynchronously using the [GetDocumentPropertiesAsync](storageitemcontentproperties_getdocumentpropertiesasync_124814975.md) method from the [Properties](../windows.storage/istorageitemproperties_properties.md) property of an item (like a file of folder), or synchronously using the [DocumentProperties](../windows.storage.bulkaccess/istorageiteminformation_documentproperties.md) property if it is available.
You can get a DocumentProperties object using any of the following methods and properties:

+ [FileInformation.documentProperties](../windows.storage.bulkaccess/fileinformation_documentproperties.md) property
+ [FolderInformation.documentProperties](../windows.storage.bulkaccess/folderinformation_documentproperties.md) property
+ [StorageItemContentProperties.getDocumentPropertiesAsync](storageitemcontentproperties_getdocumentpropertiesasync_124814975.md) method, which can be accessed using the [Properties](../windows.storage/istorageitemproperties_properties.md) property, if it is available.


> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to use a file query that is backed by the system index to retrieve document properties like [Title](documentproperties_title.md).

```csharp

try
{
    // Create index backed file query and get results
    List<string> fileTypeFilter = new List<string>();
    fileTypeFilter.Add(".docx");
    QueryOptions queryOptions = new QueryOptions(Windows.Storage.Search.CommonFileQuery.OrderByName, fileTypeFilter);
    queryOptions.IndexerOption = IndexerOption.OnlyUseIndexer;
    StorageFileQueryResult queryResult = Windows.Storage.KnownFolders.DocumentsLibrary.CreateFileQueryWithOptions(queryOptions);
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

While the example uses the [DocumentsLibrary](../windows.storage/knownfolders_documentslibrary.md) to create the query, you can create a query like this for any folder you have access to that you can get as a [StorageFolder](../windows.storage/storagefolder.md).

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[StorageItemContentProperties.getDocumentPropertiesAsync method](storageitemcontentproperties_getdocumentpropertiesasync_124814975.md), [Windows.Storage.BulkAccess.FileInformation.documentProperties property](../windows.storage.bulkaccess/fileinformation_documentproperties.md), [Windows.Storage.BulkAccess.FolderInformation.documentProperties property](../windows.storage.bulkaccess/folderinformation_documentproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.DocumentProperties property](../windows.storage.bulkaccess/istorageiteminformation_documentproperties.md)
