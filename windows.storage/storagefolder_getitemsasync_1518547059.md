---
-api-id: M:Windows.Storage.StorageFolder.GetItemsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetItemsAsync()
-->

# Windows.Storage.StorageFolder.GetItemsAsync

## -description
Gets the files and subfolders in the current folder.

## -returns
When this method completes successfully, it returns a list of the files and folders in the current folder. The list is of type **IReadOnlyList**&lt;[IStorageItem](istorageitem.md)&gt;. Each item in the list is represented by an [IStorageItem](istorageitem.md) object.

To work with the returned items, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether each item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -exceptions
### System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions).

## -remarks
The following table lists methods of the [StorageFolder](storagefolder.md) class that get a list of files and folders. The table identifies shallow queries that only return items from the current folder, and deep queries that return items from the current folder and from its subfolders.

To get deep query results from a folder that's not a library folder, call the [CreateItemQueryWithOptions(QueryOptions)](storagefolder_createitemquerywithoptions_1519361285.md) method and specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object.

<table>
   <tr><th>Method</th><th>Create a shallow query that only returns items from the current folder</th><th>Create a deep query that returns items from the current folder and from its subfolders</th></tr>
   <tr><td>[GetItemsAsync()](storagefolder_getitemsasync_1518547059.md)</td><td>Default behavior of this method.</td><td>N/A</td></tr>
   <tr><td>[GetItemsAsync(UInt32, UInt32)](storagefolder_getitemsasync_561011846.md)</td><td>Default behavior of this method.</td><td>N/A</td></tr>
   <tr><td>[CreateItemQuery()](storagefolder_createitemquery_543424716.md)</td><td>Default behavior of this method.</td><td>N/A</td></tr>
   <tr><td>[CreateItemQueryWithOptions(QueryOptions)](storagefolder_createitemquerywithoptions_1519361285.md)</td><td><ul><li>Default behavior of this method if none of the following options are specified.

- or -</li><li>Specify **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) or [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.

- or -</li><li>Specify **Shallow** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md) object.</li></ul></td><td><ul><li>For a library folder, specify a value other than **DefaultQuery** as the value of [CommonFileQuery](../windows.storage.search/commonfilequery.md) or [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) when you instantiate the [QueryOptions](../windows.storage.search/queryoptions.md) object.

- or -</li><li>For any folder, specify **Deep** as the value of the [FolderDepth](../windows.storage.search/queryoptions_folderdepth.md) property of the [QueryOptions](../windows.storage.search/queryoptions.md).</li></ul></td></tr>
</table>

To get only files, call the [GetFilesAsync](storagefolder_getfilesasync_1429382825.md) method. To get only folders, call the [GetFoldersAsync](storagefolder_getfoldersasync_592765033.md) method.

## -examples
The following example shows how to get the files and subfolders in the current folder by calling the [GetItemsAsync()](storagefolder_getitemsasync_1518547059.md) method.

```csharp
using Windows.Storage;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the files and folders in the current folder.
IReadOnlyList<IStorageItem> itemsInFolder = await appFolder.GetItemsAsync();

// Iterate over the results and print the list of items
// to the Visual Studio Output window.
foreach (IStorageItem item in itemsInFolder)
{
    if(item.IsOfType(StorageItemTypes.Folder))
        Debug.WriteLine("Folder: " + item.Name);
    else
        Debug.WriteLine("File: " + item.Name + ", " + item.DateCreated);
}
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder appFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

    // Get the items in the current folder.
    Windows::Foundation::Collections::IVectorView<Windows::Storage::IStorageItem> itemsInFolder{
        co_await appFolder.GetItemsAsync() };

    // Iterate over the results, and print the list of items to the Visual Studio output window.
    for (IStorageItem const& itemInFolder : itemsInFolder)
    {
        std::wstringstream stringstream;

        if (itemInFolder.IsOfType(Windows::Storage::StorageItemTypes::File))
        {
            stringstream << L"File: ";
        }
        else
        {
            stringstream << L"Folder: ";
        }

        stringstream << itemInFolder.Name().c_str() << std::endl;
        ::OutputDebugString(stringstream.str().c_str());
    }
}
```

```cpp
// Get the apps installation folder
StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

// Get the items in the current folder; 
create_task(appFolder->GetItemsAsync()).then([=](IVectorView<IStorageItem^>^ itemsInFolder) {

 //Iterate over the results and print the list of items
 // to the visual studio output window
 for (auto it = itemsInFolder->First(); it->HasCurrent; it->MoveNext())
 {
  IStorageItem^ item = it->Current;
  if (item->IsOfType(StorageItemTypes::File))
  {
   String^ output = "File: " + item->Name + "\n";
   OutputDebugString(output->Begin());
  }
  else
  {
   String^ output = "Folder: " + item->Name + "\n";
   OutputDebugString(output->Begin());
  }
 }
});
```

```javascript
// Get the app's installation folder.
var appFolder = Windows.ApplicationModel.Package.current.installedLocation;

// Get the files and folders in the current folder.
var itemsInFolderPromise = appFolder.getItemsAsync();

// Iterate over the results and print the list of items
// to the Visual Studio Output window.
itemsInFolderPromise.done(function getItemsSuccess(itemsInFolder) {
    itemsInFolder.forEach(function forEachItem(item) {
        var StorageItemTypes = Windows.Storage.StorageItemTypes;
        if (item.isOfType(StorageItemTypes.folder)) {
            console.log("Folder:", item.name);
        } else {
            console.log("File:", item.name, item.dateCreated);
        }
    })
});
```

## -see-also
[File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions), [GetItemsAsync(UInt32, UInt32)](storagefolder_getitemsasync_561011846.md), [GetFilesAsync](/uwp/api/windows.storage.storagefolder.getfilesasync), [GetFoldersAsync](/uwp/api/windows.storage.storagefolder.getfoldersasync)