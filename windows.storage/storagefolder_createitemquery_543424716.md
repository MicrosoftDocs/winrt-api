---
-api-id: M:Windows.Storage.StorageFolder.CreateItemQuery
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageItemQueryResult CreateItemQuery()
-->

# Windows.Storage.StorageFolder.CreateItemQuery

## -description
Gets a query result object that contains the files and subfolders in the current folder.

## -returns
A query result object. Call the [GetItemsAsync](../windows.storage.search/storageitemqueryresult_getitemsasync.md) method of the query result to get the files and subfolders in the current folder. This method returns a list of type **IReadOnlyList**&lt;[IStorageItem](istorageitem.md)&gt;. Each file or folder is represented by an item of type [IStorageItem](istorageitem.md).

To work with the returned items, call the [IsOfType](istorageitem_isoftype.md) method of the [IStorageItem](istorageitem.md) interface to determine whether each item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -exceptions
### System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

## -remarks
This query is a shallow query that returns only items in the current folder. For a list of methods that identifies shallow queries and deep queries, see the Remarks in the topic [GetItemsAsync](storagefolder_getitemsasync.md).

You can also get a list of items in the current folder asynchronously by calling one of the [GetItemsAsync](storagefolder_getitemsasync.md) methods.

To specify additional query options, call the [CreateItemQueryWithOptions](storagefolder_createitemquerywithoptions.md) method.

## -examples
The following example shows how to get the files and subfolders in the current folder by calling the [CreateItemQuery()](storagefolder_createitemquery.md) method.

```csharp
using Windows.Storage;
using Windows.Storage.Search;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to the Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the items in the current folder.
StorageItemQueryResult itemsInFolder = appFolder.CreateItemQuery();

// Iterate over the results and print the list of items
// to the Visual Studio Output window.
foreach (IStorageItem item in await itemsInFolder.GetItemsAsync())
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

    Windows::Storage::Search::StorageItemQueryResult results{ appFolder.CreateItemQuery() };

    // Get the items in the current folder.
    Windows::Foundation::Collections::IVectorView<Windows::Storage::IStorageItem> itemsInFolder{
        co_await results.GetItemsAsync() };

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
// Get the app's installation folder
StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

StorageItemQueryResult^ results = appFolder->CreateItemQuery();

// Get the items in the current folder; 
create_task(results->GetItemsAsync()).then([=](IVectorView<IStorageItem^>^ itemsInFolder) {
		
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

// Get the items in the current folder.
var itemsInFolder = appFolder.createItemQuery();

// Iterate over the results and print the list of items
// to the Visual Studio Output window.
var itemsPromise = itemsInFolder.getItemsAsync();
itemsPromise.done(function getItemsSuccess(items) {
    items.forEach(function forEachItem(item) {
        var StorageItemTypes = Windows.Storage.StorageItemTypes;
        if (item.isOfType(StorageItemTypes.folder)) {
            console.log("Folder:", item.name);
        } else {
            console.log("File:", item.name, item.dateCreated);
        }
    });
});
```

## -see-also
