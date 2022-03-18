---
-api-id: M:Windows.Storage.StorageFolder.CreateFileQuery
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFileQueryResult CreateFileQuery()
-->

# Windows.Storage.StorageFolder.CreateFileQuery

## -description
Gets a query result object that contains the files in the current folder.

## -returns
A query result object. Call the [GetFilesAsync](../windows.storage.search/storagefilequeryresult_getfilesasync_1261374131.md) method of the query result to get the flat list of files. This method returns a list of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file is represented by an item of type [StorageFile](storagefile.md).

## -remarks
This query is a shallow query that returns only files in the current folder. For a list of methods that identifies shallow queries and deep queries, see the Remarks in the topic [GetFilesAsync](storagefolder_getfilesasync_1429382825.md).

You can also get a list of files in the current folder asynchronously by calling one of the [GetFilesAsync](storagefolder_getfilesasync_1429382825.md) methods.

To specify additional query options, call the [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md) method.

To get items that are files or folders, call the [CreateItemQuery](storagefolder_createitemquery_543424716.md) method.

## -examples
The following example gets a query result object that contains the files in the current folder by calling the CreateFileQuery() method.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the files in the current folder.
StorageFileQueryResult results = appFolder.CreateFileQuery();

// Iterate over the results and print the list of files
// to the Visual Studio Output window.
IReadOnlyList<StorageFile> filesInFolder = await results.GetFilesAsync();
foreach (StorageFile item in filesInFolder)
{
    Debug.WriteLine(item.Name);
}
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder appFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };
    // Get the files in the current folder.
    Windows::Storage::Search::StorageFileQueryResult results{ appFolder.CreateFileQuery() };

    Windows::Foundation::Collections::IVectorView<Windows::Storage::StorageFile> filesInFolder{
        co_await results.GetFilesAsync() };

    // Iterate over the results, and print the list of files to the Visual Studio output window.
    for (StorageFile const& fileInFolder : filesInFolder)
    {
        std::wstring output{ fileInFolder.Name() };
        ::OutputDebugString(output.c_str());
    }
}
```

```cppcx
 //Get the app's installation folder
 StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;
 //Get the files in the current folder
 StorageFileQueryResult^ results = appFolder->CreateFileQuery();
 
 create_task(results->GetFilesAsync()).then([=](IVectorView<StorageFile^>^ filesInFolder) {
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
[CreateFileQuery(CommonFileQuery)](storagefolder_createfilequery_1641434999.md), [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md)
