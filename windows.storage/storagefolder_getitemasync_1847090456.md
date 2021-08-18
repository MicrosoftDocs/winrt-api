---
-api-id: M:Windows.Storage.StorageFolder.GetItemAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.IStorageItem> GetItemAsync(System.String name)
-->

# Windows.Storage.StorageFolder.GetItemAsync

## -description
Gets the file or folder with the specified name from the current folder.

## -parameters
### -param name
The name (or path relative to the current folder) of the file or folder to get.

## -returns
When this method completes successfully, it returns an [IStorageItem](istorageitem.md) that represents the specified file or folder.

To work with the returned item, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether the item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -exceptions
### T:System.IO.FileNotFoundException

The specified item does not exist. Check the value of *name*.

### T:System.UnauthorizedAccessException

You don't have permission to access the specified item. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

### T:System.ArgumentException

The path cannot be in Uri format (for example, /image.jpg). Check the value of *name*.

## -remarks
Call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether the returned item is a file or a folder.

To get a specific file without casting the return value, call the [GetFileAsync](storagefolder_getfileasync_703762627.md) method. To get a specific folder without casting the return value, call the [GetFolderAsync](storagefolder_getfolderasync_761626819.md) method.

To try to get a file or folder by name, or to check whether a file or folder exists, without the need to handle a **FileNotFoundException**, call the [TryGetItemAsync](storagefolder_trygetitemasync_1863649689.md) method.

## -examples
The following example shows how to get a single file or folder from the current folder by calling the [GetItemAsync](storagefolder_getitemsasync_1518547059.md) method. This example also shows how to get an item from a subfolder of the current folder by providing a relative path.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the app's manifest file.
string name = "AppxManifest.xml";
StorageFile manifestFile = (StorageFile)await appFolder.GetItemAsync(name);

// Get a file from a subfolder of the current folder
// by providing a relative path.
string image = @"Assets\Logo.scale-100.png";
StorageFile logoImage = (StorageFile)await appFolder.GetItemAsync(image);
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder appFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

    // Get the app's manifest file from the current folder.
    std::wstring name{ L"AppxManifest.xml" };
    Windows::Storage::StorageFile manifest{ co_await appFolder.GetItemAsync(name) };
    // Do something with the manifest file.
}
```

```cppcx
// Get the app's installation folder
StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

// Get the app's manifest file from the current folder
String^ name = "AppxManifest.xml";
create_task(appFolder->GetItemAsync(name)).then([=](IStorageItem^ manifest){
  //Do something with the manifest file  
});
```

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetFileAsync](storagefolder_getfileasync_703762627.md), [GetFolderAsync](storagefolder_getfolderasync_761626819.md), [TryGetItemAsync](storagefolder_trygetitemasync_1863649689.md)