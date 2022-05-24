---
-api-id: M:Windows.Storage.StorageFolder.GetFoldersAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync()
-->

# Windows.Storage.StorageFolder.GetFoldersAsync

## -description
Gets the subfolders in the current folder.

## -returns
When this method completes successfully, it returns a list of the subfolders in the current folder. The list is of type **IReadOnlyList**&lt;[StorageFolder](storagefolder.md)&gt;. Each folder in the list is represented by a [StorageFolder](storagefolder.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -remarks
This query is a shallow query that returns only subfolders in the current folder.

The following table lists methods of the [StorageFolder](storagefolder.md) class that get a list of subfolders. The table identifies shallow queries that only return subfolders from the current folder, and deep queries that return the contents of nested subfolders, grouped into virtual folders.

Some methods take a value from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration.

+ When you use the **DefaultQuery** option with any folder, the query returns a list of subfolders in the file system.
+ When you use an option other than **DefaultQuery** with a library folder, the query returns a list of virtual folders that represent containers for files from the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped into virtual folders based on the specified value from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration. For example, if you specify **GroupByMonth**, the query returns a list of virtual folders such as `July 2014`, `August 2014`, and `September 2014`.

> [!TIP]
> You can use the **DefaultQuery** option with any folder; you can use the other options from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration only with library folders, such as the Pictures library, or the Homegroup folder.

To get deep query results from a folder that's not a library folder, call the [CreateFolderQueryWithOptions(QueryOptions)](storagefolder_createfolderquerywithoptions_573382953.md) method and specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object.

| Method | Create a shallow query that only returns subfolders from the current folder | Create a deep query that returns all nested subfolders |
|---|---|---|
| GetFoldersAsync() | Default behavior of this method. | N/A |
| [GetFoldersAsync(CommonFileQuery)](storagefolder_getfoldersasync_595997124.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [GetFoldersAsync(CommonFileQuery, UInt32, UInt32)](storagefolder_getfoldersasync_731846614.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [CreateFolderQuery()](storagefolder_createfolderquery_325438332.md) | Default behavior of this method. | N/A |
| [CreateFolderQuery(CommonFileQuery)](storagefolder_createfolderquery_330767063.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [CreateFolderQueryWithOptions(QueryOptions)](storagefolder_createfolderquerywithoptions_573382953.md) | Default behavior of this method if none of the following options are specified.<br/>- or -<br/>Specify **DefaultQuery** as the value of [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.<br/>- or -<br/>Specify **Shallow** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object. | For a library folder, specify a value other than **DefaultQuery** as the value of [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.<br/>- or -<br/>For any folder, specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md). |

## -examples
The following example shows how to get the contents of the subfolders in the user's Pictures folder, grouped by month, by calling the [GetFoldersAsync(CommonFolderQuery, UInt32, UInt32)](storagefolder_getfoldersasync_731846614.md) method. (Files from the root of the current folder are not included.) This example returns a maximum of 4 folders, starting with the folder at index 0. Since the [CommonFolderQuery.GroupByMonth](../windows.storage.search/commonfolderquery.md) option sorts dates in descending order (that is, from newest to oldest), this example returns folders for the 4 most recent months for which the user has photos. Each folder contains all the user's photos from that month.

Before you run the following example, enable the **Pictures Library** capability in the app manifest file.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder picturesFolder = KnownFolders.PicturesLibrary;

// Get the files in the subfolders of the user's Pictures folder,
// grouped by month. Get only the first 4 folders (months).
IReadOnlyList <StorageFolder> groupedItems = await picturesFolder.GetFoldersAsync(CommonFolderQuery.GroupByMonth, 0, 4);

// Iterate over the results and print the list of folders
// and files to the Visual Studio Output window.
foreach (StorageFolder folder in groupedItems)
{
    Debug.WriteLine(folder.Name);

    // To iterate over the files in each folder, uncomment the following lines. 
    // foreach(StorageFile file in await folder.GetFilesAsync())
    //    Debug.WriteLine(" " + file.Name);
}
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the users's Pictures folder.
    // Enable the Pictures Library capability in the app manifest file.
    Windows::Storage::StorageFolder picturesFolder{ Windows::Storage::KnownFolders::PicturesLibrary() };

    // Get the files in the user's Pictures folder, grouped by month.
    // Get only the first 4 folders (months).
    Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFolder> itemsInFolder{
        co_await picturesFolder.GetFoldersAsync(Windows::Storage::Search::CommonFolderQuery::GroupByMonth, 0, 4) };

    // Iterate over the results, and print the list of file groups to the Visual Studio output window.
    for (StorageFolder const& itemInFolder : itemsInFolder)
    {
        std::wstring output{ itemInFolder.Name() };
        ::OutputDebugString(output.c_str());
    }
}
```

```cppcx
// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder^ picturesFolder = KnownFolders::PicturesLibrary;

// Get the files in the user's Pictures folder, grouped by month.
// Get only the first 4 folders (months).
create_task(picturesFolder->GetFoldersAsync(CommonFolderQuery::GroupByMonth, 0, 4)).then([=](IVectorView<StorageFolder^>^ itemsInFolder) {
 //Iterate over the results and print the list of file groups
 // to the visual studio output window
 for (auto it = itemsInFolder->First(); it->HasCurrent; it->MoveNext())
 {
  StorageFolder^ file = it->Current;
  String^ output = file->Name + "\n";
  OutputDebugString(output->Begin());
 }
});
```

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetFoldersAsync(CommonFolderQuery, UInt32, UInt32)](storagefolder_getfoldersasync_731846614.md), [GetFoldersAsync(CommonFolderQuery)](storagefolder_getfoldersasync_595997124.md), [GetItemsAsync](/uwp/api/windows.storage.storagefolder.getitemsasync)
