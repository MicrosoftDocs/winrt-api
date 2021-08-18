---
-api-id: M:Windows.Storage.StorageFolder.CreateFolderQuery
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFolderQueryResult CreateFolderQuery()
-->

# Windows.Storage.StorageFolder.CreateFolderQuery

## -description
Gets a query result object that contains the subfolders in the current folder.

## -returns
A query result object. Call the [GetFoldersAsync](../windows.storage.search/storagefolderqueryresult_getfoldersasync_1487375516.md) method of the query result to get the subfolders in the current folder. This method returns a list of type **IReadOnlyList**&lt;[StorageFolder](storagefolder.md)&gt;. Each file or folder is represented by an item of type [StorageFolder](storagefolder.md).

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

## -remarks
This query is a shallow query that returns only subfolders in the current folder. For a list of methods that identifies shallow queries and deep queries, see the Remarks in the [GetFoldersAsync](storagefolder_getfoldersasync_592765033.md) method.

To specify additional query options, call the [CreateFolderQueryWithOptions](storagefolder_createfolderquerywithoptions_573382953.md) method.

To get items that are files or folders, call the [CreateItemQuery](storagefolder_createitemquery_543424716.md) method.

## -examples
The following example shows how to get the contents of the subfolders in the user's Pictures folder, grouped into folders by month, by calling the [GetFoldersAsync(CommonFolderQuery)](storagefolder_getfoldersasync_595997124.md) overloaded method. (Files from the root of the current folder are not included.)

Before you run the following example, enable the **Pictures Library** capability in the app manifest file.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to the Output window.

// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder picturesFolder = KnownFolders.PicturesLibrary;

// Get the files in the subfolders of the
// user's Pictures folder, grouped by month.
StorageFolderQueryResult groupedItems =
    picturesFolder.CreateFolderQuery(CommonFolderQuery.GroupByMonth);

// Iterate over the results and print the list of folders
// and files to the Visual Studio Output window.
foreach (StorageFolder folder in await groupedItems.GetFoldersAsync())
{
    Debug.WriteLine(folder.Name);

// To iterate over the files in each folder,
// uncomment the following lines.
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

    // Get the files in the user's Pictures folder, and group them by month.
    Windows::Storage::Search::StorageFolderQueryResult results{ picturesFolder.CreateFolderQuery(Windows::Storage::Search::CommonFolderQuery::GroupByMonth) };

    Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFolder> itemsInFolder{
        co_await results.GetFoldersAsync() };

    // Iterate over the results, and print the list of file groups to the Visual Studio output window.
    for (StorageFolder const& itemInFolder : itemsInFolder)
    {
        std::wstring output{ itemInFolder.Name() };
        ::OutputDebugString(output.c_str());
    }
}
```

```cppcx
 // Get user's pictures folder
 StorageFolder^ picturesFolder = KnownFolders::PicturesLibrary;

 // Get the files in the user's Pictures folder and group them by month
 StorageFolderQueryResult^ itemsInFolder = picturesFolder->CreateFolderQuery(CommonFolderQuery::GroupByMonth);

 create_task(itemsInFolder->GetFoldersAsync()).then([=](IVectorView<StorageFolder^>^ itemsInFolder) {
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
[CreateFolderQuery(CommonFolderQuery)](storagefolder_createfolderquery_330767063.md)