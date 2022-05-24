---
-api-id: M:Windows.Storage.StorageFolder.GetFileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> GetFileAsync(System.String name)
-->

# Windows.Storage.StorageFolder.GetFileAsync

## -description
Gets the file with the specified name from the current folder.

## -parameters
### -param name
The name (or path relative to the current folder) of the file to get.

## -returns
When this method completes successfully, it returns a [StorageFile](storagefile.md) that represents the specified file.

## -exceptions
### T:System.IO.FileNotFoundException

The specified file does not exist. Check the value of *name*.

### T:System.UnauthorizedAccessException

You don't have permission to access the specified file. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

### T:System.ArgumentException

The path cannot be in Uri format (for example, /image.jpg). Check the value of *name*.

## -remarks
To get an item that's a file or a folder, call the [GetItemAsync](storagefolder_getitemasync_1847090456.md) method.

## -examples
The following example shows how to get a file from the current folder by calling the GetFileAsync method. This example also shows how to get a file from a subfolder of the current folder by providing a relative path.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the app's manifest file from the current folder.
string name = "AppxManifest.xml";
StorageFile manifestFile = await appFolder.GetFileAsync(name);

// Get a file from a subfolder of the current folder
// by providing a relative path.
string image = @"Assets\Logo.scale-100.png";
StorageFile logoImage = await appFolder.GetFileAsync(image);
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder appFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

    // Get the app's manifest file from the current folder.
    std::wstring name{ L"AppxManifest.xml" };
    Windows::Storage::StorageFile manifest{ co_await appFolder.GetFileAsync(name) };
    // Do something with the manifest file.
}
```

```cppcx
// Get the app's installation folder
StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

// Get the app's manifest file from the current folder
String^ name = "AppxManifest.xml";
create_task(appFolder->GetFileAsync(name)).then([=](StorageFile^ manifest){
 //Do something with the manifest file  
});
```

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetItemAsync](storagefolder_getitemasync_1847090456.md)
