---
-api-id: T:Windows.Storage.Search.StorageFolderQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFolderQueryResult : Windows.Storage.Search.IStorageFolderQueryResult, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageFolderQueryResult

## -description

Provides access to the results of a query that lists the folder (or file groups) in the folder being queried (which is represented by a [storageFolder](../windows.storage/storagefolder.md)). You can use a [storageFolderQueryResult](storagefolderqueryresult.md) to enumerate folders or file groups in that folder.

## -remarks

> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).
<!--W8B 988884 v2-->

You can get a [storageFolderQueryResult](storagefolderqueryresult.md) object by calling the following methods from a [storageFolder](../windows.storage/storagefolder.md) or a [folderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [storageFolder.createFolderQuery methods](../windows.storage/storagefolder_createfolderquery_325438332.md)
+ [storageFolder.createFolderQueryWithOptions method](../windows.storage/storagefolder_createfolderquerywithoptions_573382953.md)
+ [folderInformation.createFolderQuery methods](../windows.storage.bulkaccess/folderinformation_createfolderquery_325438332.md)
+ [folderInformation.createFolderQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createfolderquerywithoptions_573382953.md)

For more code examples that show you how to use [storageFolderQueryResult](storagefolderqueryresult.md) objects, see the [Folder enumeration sample](http://go.microsoft.com/fwlink/p/?linkid=231512).

To get a [StorageFolderQueryResult](storagefolderqueryresult.md) object to enumerate the folders or file groups in a location, you must get a [storageFolder](../windows.storage/storagefolder.md) that represents the location and then create a folder query

## -examples

This example demonstrates how to get a list folders (or file groups) from a [storageFolderQueryResult](storagefolderqueryresult.md) object.

```csharp

// Get the Pictures library
Windows.Storage.StorageFolder picturesFolder = Windows.Storage.KnownFolders.PicturesLibrary;

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

```javascript

// Get the Pictures library, then rearrange it by month
var picturesLibrary = Windows.Storage.KnownFolders.picturesLibrary;

// Set query options to create groups of files within result
var queryOptions = new QueryOptions(Windows.Storage.Search.CommonFolderQuery.GroupByMonth);

// Create query and retrieve result
var queryResult = picturesLibrary.createFolderQuery(Windows.Storage.Search.CommonFolderQuery.groupByMonth);
queryResult.getFoldersAsync().done(function(folders) {
    // Process file groups (or folders)

    // Create an array of promises that will asynchronously
    // retrieve the files for each file group
    var promises = folders.map(function (folder) {
        return folder.getFilesAsync();
    });

    // Aggregate the results of multiple asynchronous operations
    // so that they are returned after all are completed. This
    // ensures that the groups are displayed in order.
    WinJS.Promise.join(promises).done(function (folderContents) {
        // Process the contents of each file group (or folder)

        for (var i in folderContents) {
            // Process the group/folder at index i of folderContents

            // Display the group name
            var group = outputResultGroup(folders.getAt(i).name);
            // Display the items in the group 
            outputItems(group, folderContents[i]);
        }
    });
});
```

The `queryResult` variable gets the [storageFolderQueryResult](storagefolderqueryresult.md) that is used to retrieve file groups (or folders) that meet the criteria of the query.

> [!NOTE]
> You need the Pictures library capability to access the library using [KnownFolders.PicturesLibrary](../windows.storage/knownfolders_pictureslibrary.md). To learn more about capabilities and file access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

## -see-also

[Windows.Storage.storageFolder.createFolderQuery methods](../windows.storage/storagefolder_createfolderquery_325438332.md), [Windows.Storage.storageFolder.createFolderQueryWithOptions method](../windows.storage/storagefolder_createfolderquerywithoptions_573382953.md), [Windows.Storage.BulkAccess.folderInformation.createFolderQuery methods](../windows.storage.bulkaccess/folderinformation_createfolderquery_325438332.md), [Windows.Storage.BulkAccess.folderInformation.createFolderQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createfolderquerywithoptions_573382953.md), [Folder enumeration sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619993)