---
-api-id: M:Windows.Storage.StorageFolder.GetFolderFromPathAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetFolderFromPathAsync(System.String path)
-->

# Windows.Storage.StorageFolder.GetFolderFromPathAsync

## -description
Gets the folder that has the specified absolute path in the file system.

## -parameters
### -param path
The absolute path in the file system (not the Uri) of the folder to get.

## -returns
When this method completes successfully, it returns a [StorageFolder](storagefolder.md) that represents the specified folder.

## -exceptions
### System.IO.FileNotFoundException

The specified folder does not exist. Check the value of *path*.

### System.UnauthorizedAccessException

You don't have permission to access the specified folder. For more information, see [File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions).

### System.ArgumentException

The path cannot be a relative path or a Uri. Check the value of *path*.

## -remarks

## -examples
The following example shows how to get the folder that has the specified absolute path in the file system by calling the GetFolderFromPathAsync method.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the path to the app's Assets folder.
string root = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
string path = root + @"\Assets";

// Get the folder object that corresponds to this absolute path in the file system.
StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(path);
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the path to the app's Assets folder.
	std::wstring path{ Windows::ApplicationModel::Package::Current().InstalledLocation().Path() + L"\\Assets" };

    // Get the folder object that corresponds to this absolute path in the file system.
    Windows::Storage::StorageFolder folder{ co_await Windows::Storage::StorageFolder::GetFolderFromPathAsync(path) };
    ::OutputDebugString(folder.Name().c_str());
}
```

```cppcx
// Get the path to the app's installation folder.
String^ root = Windows::ApplicationModel::Package::Current->InstalledLocation->Path;

// Get the folder object that corresponds to
// this absolute path in the file system.
create_task(StorageFolder::GetFolderFromPathAsync(root)).then([=](StorageFolder^ folder){
 String^ output = folder->Name;
 OutputDebugString(output->Begin());
});
```

```javascript
// Get the path to the app's Assets folder.
var root = Windows.ApplicationModel.Package.current.installedLocation.path;
var path = root + "\\Assets";

// Get the folder object that corresponds to
// this absolute path in the file system.
var StorageFolder = Windows.Storage.StorageFolder;
var folderPromise = StorageFolder.getFolderFromPathAsync(path);
folderPromise.done(function getFolderSuccess(folder) {
});
```

## -see-also
[File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions)
