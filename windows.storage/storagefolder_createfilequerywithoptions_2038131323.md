---
-api-id: M:Windows.Storage.StorageFolder.CreateFileQueryWithOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFileQueryResult CreateFileQueryWithOptions(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.StorageFolder.CreateFileQueryWithOptions

## -description

Gets a query result object that contains the files in the current folder and, optionally, in the subfolders of the current folder. The results are based on the specified [QueryOptions](../windows.storage.search/queryoptions.md).

## -parameters

### -param queryOptions

The criteria that are applied to the query.

## -returns

A query result object that contains the files in the current folder and, optionally, in the subfolders of the current folder, filtered and sorted based on the specified [QueryOptions](../windows.storage.search/queryoptions.md). Call the [GetFilesAsync](../windows.storage.search/storagefilequeryresult_getfilesasync_1261374131.md) method of the query result to get the flat list of files, sorted as specified by _queryOptions_. This method returns a list of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file is represented by an item of type [StorageFile](storagefile.md).

## -exceptions

### T:System.ArgumentException

You specified a value other than **DefaultQuery** from the [CommonFileQuery](/uwp/api/windows.storage.search.commonfilequery) enumeration for a folder that's not a library folder. Check the value of _query_.

## -remarks

In the following cases, this query is a shallow query that returns only files in the current folder:

- Default behavior of this method if none of the following options are specified. **_Or:_**
- Specify **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object. **_Or:_**
- Specify **Shallow** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object.

In the following cases, this query is a deep query that returns files from the current folder and from its subfolders:

- For a library folder, specify a value other than **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object. **_Or:_**
- For any folder, specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md).

> [!TIP]
> Some of the values from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration can only be used with a library folder (such as the Pictures library) or the Homegroup folder. Despite the wording of the **ArgumentException** described above, you can use the **OrderByName** and **OrderBySearchRank** options (in addition to the **DefaultQuery** option) with a folder that's not a library folder.

For a list of methods that identifies shallow queries and deep queries, see the Remarks in the topic [GetFilesAsync](storagefolder_getfilesasync_1429382825.md).

To check whether the [QueryOptions](../windows.storage.search/queryoptions.md) you want to specify are available for the current folder, call the folder's [AreQueryOptionsSupported](storagefolder_arequeryoptionssupported_849436946.md) method. To check whether a specific [CommonFileQuery](../windows.storage.search/commonfilequery.md) is available, call the folder's [IsCommonFileQuerySupported](storagefolder_iscommonfilequerysupported_1848755604.md) method.

You can also get a list of files in the current folder asynchronously by calling one of the [GetFilesAsync](storagefolder_getfilesasync_1429382825.md) methods.

To get a query result object that contains the files in the current folder without configuring a [QueryOptions](../windows.storage.search/queryoptions.md) object, call one of the [CreateFileQuery](storagefolder_createfilequery_1641434999.md) methods.

To get items that are files or folders, call the [CreateItemQueryWithOptions](storagefolder_createitemquerywithoptions_1519361285.md) method.

> [!NOTE]
> **For Windows Server 2012**, you must install indexer components to use some [QueryOptions](../windows.storage.search/queryoptions.md) because indexer components are not installed by default.

## -examples

The following example shows how to get the JPG files in the user's Pictures folder and its subfolders, sorted by date, by calling the `CreateFileQueryWithOptions(QueryOptions)` method. This query is a deep query because the folder is a library folder and a value other than **DefaultQuery** from the [CommonFileQuery](/uwp/api/windows.storage.search.commonfilequery) enumeration is specified.

Before you run the following example, enable the **Pictures Library** capability in the app manifest file.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder picturesFolder = KnownFolders.PicturesLibrary;

// Set options for file type and sort order.
List<string> fileTypeFilter = new List<string>();
fileTypeFilter.Add(".jpg");
QueryOptions queryOptions = new QueryOptions(CommonFileQuery.OrderByDate, fileTypeFilter);

// Get the JPG files in the user's Pictures folder
// and its subfolders and sort them by date.
StorageFileQueryResult results = picturesFolder.CreateFileQueryWithOptions(queryOptions);

// Iterate over the results and print the list of files
// to the Visual Studio Output window.
IReadOnlyList<StorageFile> sortedFiles = await results.GetFilesAsync();
foreach (StorageFile item in sortedFiles)
{
    Debug.WriteLine(item.Name + ", " + item.DateCreated);
}
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the users's Pictures folder.
    // Enable the Pictures Library capability in the app manifest file.
    Windows::Storage::StorageFolder picturesFolder{ Windows::Storage::KnownFolders::PicturesLibrary() };

    // Set options for file type and sort order.
    Windows::Storage::Search::QueryOptions queryOptions{ Windows::Storage::Search::CommonFileQuery::OrderByDate, { L".png" } };

    // Get the png files in the user's Pictures folder and its subfolders, sorted by date.
    Windows::Storage::Search::StorageFileQueryResult results{ picturesFolder.CreateFileQueryWithOptions(queryOptions) };

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
//Get the users's pictures folder
//Enable the corresponding capability in the app manifest file
StorageFolder^ picturesFolder = KnownFolders::PicturesLibrary;

//Set options for file type and sort order
Platform::Collections::Vector<String^>^ fileTypeFilter = ref new Platform::Collections::Vector<String^>();
fileTypeFilter->Append(".jpg");
QueryOptions^ queryOptions = ref new QueryOptions(Windows::Storage::Search::CommonFileQuery::OrderByDate, fileTypeFilter);

//Get the JPG files in the user's pictures folder 
//and its subfolders and sort them by date
StorageFileQueryResult^ results = picturesFolder->CreateFileQueryWithOptions(queryOptions);

create_task(results->GetFilesAsync()).then([=](IVectorView<StorageFile^>^ filesInFolder) 
{
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

[CreateFileQuery](storagefolder_createfilequery_1641434999.md), [Content indexer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ContentIndexer)
