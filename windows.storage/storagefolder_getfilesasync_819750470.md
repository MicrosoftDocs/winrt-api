---
-api-id: M:Windows.Storage.StorageFolder.GetFilesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync()
-->

# Windows.Storage.StorageFolder.GetFilesAsync

## -description
Gets the files in the current folder.

## -returns
When this method completes successfully, it returns a list of the files in the current folder. The list is of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file in the list is represented by a [StorageFile](storagefile.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -remarks
This query is a shallow query that returns only files in the current folder. For a list of methods that identifies shallow queries and deep queries, see the Remarks in the topic [GetFilesAsync](storagefolder_getfilesasync_1429382825.md).

The following table lists methods of the [StorageFolder](storagefolder.md) class that get a list of files. The table identifies shallow queries that only return files from the current folder, and deep queries that return files from the current folder and from its subfolders.

Some methods take a value from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration. When you specify the **DefaultQuery** option from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration, the query is a shallow query that returns only files in the current folder. When you specify another value from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration, the query is a deep query that returns a flattened list of files from the current folder and from its subfolders.

> [!TIP]
> Some of the values from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration can only be used with a library folder (such as the Pictures library) or the Homegroup folder. In addition to the **DefaultQuery** option, you can use only the **OrderByName** and **OrderBySearchRank** options with a folder that's not a library folder.

To get deep query results from a folder that's not a library folder, call the [CreateFileQueryWithOptions(QueryOptions)](storagefolder_createfilequerywithoptions_2038131323.md) method and specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object.

| Method | Create a shallow query that only returns files from the current folder | Create a deep query that returns files from the current folder and from its subfolders |
|---|---|---|
| GetFilesAsync() | Default behavior of this method. | N/A |
| [GetFilesAsync(CommonFileQuery)](storagefolder_getfilesasync_1429382825.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [GetFilesAsync(CommonFileQuery, UInt32, UInt32)](storagefolder_getfilesasync_1563132095.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [CreateFileQuery()](storagefolder_createfilequery_70815642.md) | Default behavior of this method. | N/A |
| [CreateFileQuery(CommonFileQuery)](storagefolder_createfilequery_1641434999.md) | Specify the **DefaultQuery** option. | For a library folder, specify an option other than **DefaultQuery**. |
| [CreateFileQueryWithOptions(QueryOptions)](storagefolder_createfilequerywithoptions_2038131323.md) | Default behavior of this method if none of the following options are specified.<br/>- or -<br/>Specify **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.<br/>- or -<br/>Specify **Shallow** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object. | For a library folder, specify a value other than **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.<br/>- or -<br/>For any folder, specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md). |

## -examples
The following example shows how to get the contents of the user's Pictures folder and its subfolders, sorted by date, by calling the [GetFilesAsync(CommonFileQuery,  UInt32, UInt32)](storagefolder_getfilesasync_1563132095.md) overloaded method. This example returns a maximum of 20 files, starting with the file at index 0. Since the [CommonFileQuery.OrderByDate](../windows.storage.search/commonfilequery.md) option sorts dates in descending order (that is, from newest to oldest), this example returns the user's 20 most recent photos.

Before you run the following example, enable the **Pictures Library** capability in the app manifest file.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder picturesFolder = KnownFolders.PicturesLibrary;

// Get the first 20 files in the current folder, sorted by date.
IReadOnlyList<StorageFile> sortedItems = await picturesFolder.GetFilesAsync(CommonFileQuery.OrderByDate,0,20);

// Iterate over the results and print the list of files
// to the Visual Studio Output window.
foreach (StorageFile file in sortedItems)
    Debug.WriteLine(file.Name + ", " + file.DateCreated);
```

```cppwinrt
#include <winrt/Windows.Storage.h>
#include <winrt/Windows.Storage.Search.h>
...
IAsyncAction ExampleCoroutineAsync()
{
    // Get the user's Pictures library.
    // Enable the Pictures Library capability in the app manifest file.
    Windows::Storage::StorageFolder picturesLibrary{ Windows::Storage::KnownFolders::PicturesLibrary() };

    // Get the first 20 sorted images in the library, sorted by date.
    Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFile> filesInFolder{
        co_await picturesLibrary.GetFilesAsync(Windows::Storage::Search::CommonFileQuery::OrderByDate, 0, 20) };

    // Iterate over the results, and print the list of files to the Visual Studio output window.
    for (Windows::Storage::StorageFile const& fileInFolder : filesInFolder)
    {
        std::wstring output{ fileInFolder.Name() + L' ' };
        ::OutputDebugString(output.c_str());
    }
    ::OutputDebugString(L"\n");
}
```

```cppcx
// Get user's pictures library
StorageFolder^ picturesLibrary = KnownFolders::PicturesLibrary;

// Get the first 20 sorted images in the library
create_task(picturesLibrary->GetFilesAsync(CommonFileQuery::OrderByDate,0,20)).then([=](IVectorView<StorageFile^>^ filesInFolder) {
 //Iterate over the results and print the list of files
 // to the visual studio output window
 for (auto it = filesInFolder->First(); it->HasCurrent; it->MoveNext())
 {
  StorageFile^ file = it->Current;
  String^ output = file->Name + "\n";
  OutputDebugString(output->Begin());
 }
});
```

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetFilesAsync(CommonFileQuery, UInt32, UInt32)](storagefolder_getfilesasync_1563132095.md), [GetFilesAsync(CommonFileQuery)](storagefolder_getfilesasync_1429382825.md), [GetItemsAsync](/uwp/api/windows.storage.storagefolder.getitemsasync)
