---
-api-id: M:Windows.Storage.StorageFolder.GetFolderAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetFolderAsync(System.String name)
-->

# Windows.Storage.StorageFolder.GetFolderAsync

## -description
Gets the subfolder with the specified name from the current folder.

## -parameters
### -param name
The name (or path relative to the current folder) of the subfolder to get.

## -returns
When this method completes successfully, it returns a [StorageFolder](storagefolder.md) that represents the specified subfolder.

## -exceptions
### System.IO.FileNotFoundException

The specified folder does not exist. Check the value of *name*.

### System.UnauthorizedAccessException

You don't have permission to access the specified folder.

### System.ArgumentException

The path cannot be in Uri format (for example, /Assets). Check the value of *name*.

## -remarks

## -examples
The following example shows how to get a subfolder from the current folder by calling the [GetFolderAsync](storagefolder_getfolderasync.md) method. This example also shows how to get a subfolder from a subfolder of the current folder by providing a relative path.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's local folder.
StorageFolder localFolder = ApplicationData.Current.LocalFolder;

// Create 2 levels of subfolders in the app's local folder.
string name1 = "Subfolder1";
StorageFolder subFolder1 = await localFolder.CreateFolderAsync(name1);
string name2 = "Subfolder2";
StorageFolder subFolder2 = await subFolder1.CreateFolderAsync(name2);

// Get the subfolder of the app's local folder.
string level1FolderName = "Subfolder1";
StorageFolder level1Folder = await localFolder.GetFolderAsync(level1FolderName);

// Get the subfolder of the subfolder by providing a relative path.
string level2FolderName = @"Subfolder1\Subfolder2";
StorageFolder level2Folder = await localFolder.GetFolderAsync(level2FolderName);
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Get the app's local folder.
    Windows::Storage::StorageFolder localFolder{ Windows::Storage::ApplicationData::Current().LocalFolder() };

    // Create two levels of subfolders in the app's local folder.
    std::wstring name1{ L"Subfolder1" };
    std::wstring name2{ L"Subfolder2" };
    std::wstring level2FolderName{ L"Subfolder1\\Subfolder2" };

    Windows::Storage::StorageFolder subFolder1{ co_await localFolder.CreateFolderAsync(name1) };
    Windows::Storage::StorageFolder subFolder2{ co_await subFolder1.CreateFolderAsync(name2) };
    // Get the subfolder of the subfolder by providing a relative path.
    Windows::Storage::StorageFolder level2FolderFromRelativePath{ co_await localFolder.GetFolderAsync(level2FolderName) };
}
```

```cpp
// Get the app's local folder
StorageFolder^ localFolder = ApplicationData::Current->LocalFolder;

// Create 2 levels of subfolders in the app's local folder.
String^ name1 = "Subfolder1";
String^ name2 = "Subfolder2";
String^ level2FolderName = "Subfolder1\\Subfolder2";

create_task(localFolder->CreateFolderAsync(name1)).then([=](StorageFolder^ subFolder1) -> task <StorageFolder^> {
 return create_task(subFolder1->CreateFolderAsync(name2));
}).then([=](StorageFolder^ subFolder2) -> task<StorageFolder^> {
 // Get the subfolder of the subfolder
 // by providing a relative path.
 return create_task(localFolder->GetFolderAsync(level2FolderName));
});
```

```javascript
// Get the app's local folder.
var localFolder = Windows.Storage.ApplicationData.current.localFolder;

// Create 2 levels of subfolders in the app's local folder.
var name1 = "Subfolder1";
var subFolder1Promise = localFolder.createFolderAsync(name1);
var subFolder2Promise = subFolder1Promise.then(function createFolder1Success(subFolder1) {
    var name2 = "Subfolder2";
    return subFolder1.createFolderAsync(name2);
});
var level1FolderPromise = subFolder1Promise.then(function createFolder1Success(subFolder1) {
    // Get the subfolder of the app's local folder.
    var level1FolderName = "Subfolder1";
    return localFolder.getFolderAsync(level1FolderName);
});
level1FolderPromise.done(function (level1Folder) {
});
var level2FolderPromise = subFolder2Promise.then(function createFolder2Success(subFolder2) {
    // Get the subfolder of the subfolder
    // by providing a relative path.
    var level2FolderName = "Subfolder1\\Subfolder2";
    return localFolder.getFolderAsync(level2FolderName);
});
level2FolderPromise.done(function getFolderSuccess(level2Folder) {
});
```

## -see-also
[GetItemAsync](storagefolder_getitemasync.md)