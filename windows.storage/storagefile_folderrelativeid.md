---
-api-id: P:Windows.Storage.StorageFile.FolderRelativeId
-api-type: winrt property
---

<!-- Property syntax
public string FolderRelativeId { get; }
-->

# Windows.Storage.StorageFile.FolderRelativeId

## -description

Gets an identifier for the file. This ID is unique for the query result or [StorageFolder](storagefolder.md) that contains the file and can be used to distinguish between items that have the same name.

## -property-value

The identifier for the file.

## -remarks

You create a query result object when you create a query using one of the methods on a [StorageFolder](storagefolder.md) object. Depending on the method you call, your query result object could be a [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), a [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), or a [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md) object.

## -examples

The following example shows how to use the `FolderRelativeId` property to get a unique identifier for files in a folder, and how it can help distinguish between files with the same name located in different subfolders.

```csharp
// Example that shows the basic use of the FolderRelativeId property
using Windows.Storage;
using Windows.Storage.Search;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public async Task GetFolderRelativeIdExample()
{
    // Get the Documents folder
    StorageFolder documentsFolder = await KnownFolders.DocumentsLibrary.GetFolderAsync();
    
    // Create a query to get all files in the folder
    StorageFileQueryResult queryResult = documentsFolder.CreateFileQuery();
    IReadOnlyList<StorageFile> files = await queryResult.GetFilesAsync();
    
    // Iterate through the files and display their FolderRelativeId
    foreach (StorageFile file in files)
    {
        // Get the folder-relative identifier for this file
        string folderRelativeId = file.FolderRelativeId;
        
        // Display the file name and its folder-relative ID
        Console.WriteLine($"File: {file.Name}");
        Console.WriteLine($"FolderRelativeId: {folderRelativeId}");
        Console.WriteLine("---");
        
        // The FolderRelativeId can be used to uniquely identify files
        // within the same folder, even if they have the same name
        // (which could happen with files in different subfolders)
    }
}

// Example showing how FolderRelativeId helps distinguish between files with same names
public async Task DistinguishFilesByIdExample()
{
    StorageFolder picturesFolder = await KnownFolders.PicturesLibrary.GetFolderAsync();
    
    // Create a query that includes files from subfolders
    var queryOptions = new QueryOptions(CommonFileQuery.OrderByName, new[] { ".jpg", ".png" });
    queryOptions.FolderDepth = FolderDepth.Deep;
    
    StorageFileQueryResult queryResult = picturesFolder.CreateFileQueryWithOptions(queryOptions);
    IReadOnlyList<StorageFile> imageFiles = await queryResult.GetFilesAsync();
    
    // Group files by name to find duplicates
    var fileGroups = new Dictionary<string, List<StorageFile>>();
    
    foreach (StorageFile file in imageFiles)
    {
        if (!fileGroups.ContainsKey(file.Name))
        {
            fileGroups[file.Name] = new List<StorageFile>();
        }
        fileGroups[file.Name].Add(file);
    }
    
    // Display files with duplicate names and their unique FolderRelativeIds
    foreach (var group in fileGroups)
    {
        if (group.Value.Count > 1)
        {
            Console.WriteLine($"Files with name '{group.Key}':");
            foreach (StorageFile file in group.Value)
            {
                Console.WriteLine($"  Path: {file.Path}");
                Console.WriteLine($"  FolderRelativeId: {file.FolderRelativeId}");
            }
            Console.WriteLine();
        }
    }
}
```

```cppwinrt
// Example that shows the basic use of the FolderRelativeId property
#include <winrt/Windows.Storage.h>
#include <winrt/Windows.Storage.Search.h>
#include <winrt/Windows.Foundation.Collections.h>
#include <iostream>
#include <map>
#include <vector>

using namespace winrt;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Storage;
using namespace Windows::Storage::Search;

// Example that shows the basic use of the FolderRelativeId property
IAsyncAction GetFolderRelativeIdExample()
{
    // Get the Documents folder
    StorageFolder documentsFolder = co_await KnownFolders::DocumentsLibrary();
    
    // Create a query to get all files in the folder
    StorageFileQueryResult queryResult = documentsFolder.CreateFileQuery();
    IVectorView<StorageFile> files = co_await queryResult.GetFilesAsync();
    
    // Iterate through the files and display their FolderRelativeId
    for (StorageFile const& file : files)
    {
        // Get the folder-relative identifier for this file
        hstring folderRelativeId = file.FolderRelativeId();
        
        // Display the file name and its folder-relative ID
        std::wcout << L"File: " << file.Name().c_str() << std::endl;
        std::wcout << L"FolderRelativeId: " << folderRelativeId.c_str() << std::endl;
        std::wcout << L"---" << std::endl;
        
        // The FolderRelativeId can be used to uniquely identify files
        // within the same folder, even if they have the same name
        // (which could happen with files in different subfolders)
    }
}

// Example showing how FolderRelativeId helps distinguish between files with same names
IAsyncAction DistinguishFilesByIdExample()
{
    StorageFolder picturesFolder = co_await KnownFolders::PicturesLibrary();
    
    // Create a query that includes files from subfolders
    QueryOptions queryOptions{ CommonFileQuery::OrderByName, { L".jpg", L".png" } };
    queryOptions.FolderDepth(FolderDepth::Deep);
    
    StorageFileQueryResult queryResult = picturesFolder.CreateFileQueryWithOptions(queryOptions);
    IVectorView<StorageFile> imageFiles = co_await queryResult.GetFilesAsync();
    
    // Group files by name to find duplicates
    std::map<hstring, std::vector<StorageFile>> fileGroups;
    
    for (StorageFile const& file : imageFiles)
    {
        hstring fileName = file.Name();
        fileGroups[fileName].push_back(file);
    }
    
    // Display files with duplicate names and their unique FolderRelativeIds
    for (auto const& group : fileGroups)
    {
        if (group.second.size() > 1)
        {
            std::wcout << L"Files with name '" << group.first.c_str() << L"':" << std::endl;
            for (StorageFile const& file : group.second)
            {
                std::wcout << L"  Path: " << file.Path().c_str() << std::endl;
                std::wcout << L"  FolderRelativeId: " << file.FolderRelativeId().c_str() << std::endl;
            }
            std::wcout << std::endl;
        }
    }
}
```

## -see-also
