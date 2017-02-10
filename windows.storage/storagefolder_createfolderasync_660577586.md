---
-api-id: M:Windows.Storage.StorageFolder.CreateFolderAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderAsync(System.String desiredName)
-->

# Windows.Storage.StorageFolder.CreateFolderAsync

## -description
Creates a new subfolder with the specified name in the current folder.

## -parameters
### -param desiredName
The name of the new subfolder to create in the current folder.

## -returns
When this method completes, it returns a [StorageFolder](storagefolder.md) that represents the new subfolder.

## -exceptions
### System.IO.FileNotFoundException

The folder name contains invalid characters, or the format of the folder name is incorrect. Check the value of *desiredName*.

### System.UnauthorizedAccessException

You don't have permission to create a subfolder in the current folder.

## -remarks
This method uses the **FailIfExists** value from the [CreationCollisionOption](creationcollisionoption.md) enumeration by default. That is, this method raises an exception if a subfolder with the same name already exists in the current folder. If you want to handle a folder name collision in a different way, call the [CreateFolderAsync(String, CreationCollisionOption)](storagefolder_createfolderasync_1043039832.md) method.

If you try to create a subfolder in a virtual folder like a library, or a folder that represents a container for a group of files (for example, the return value from some overloads of the [GetFoldersAsync](storagefolder_getfoldersasync.md) method), the [CreateFolderAsync](storagefolder_createfolderasync_660577586.md) method may fail.

## -examples
The following example shows how to create a new [StorageFolder](storagefolder.md) in the current folder by calling the [CreateFolderAsync(String, CreationCollisionOption)](storagefolder_createfolderasync_1043039832.md) overloaded method. This example explicitly specifies a value for *options* that causes the operation to fail if a folder with the specified *desiredName* already exists in the current folder.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's local folder.
StorageFolder localFolder =
    Windows.Storage.ApplicationData.Current.LocalFolder;

// Create a new subfolder in the current folder.
// Raise an exception if the folder already exists.
string desiredName = "Subfolder";
StorageFolder newFolder =
    await localFolder.CreateFolderAsync(desiredName, CreationCollisionOption.FailIfExists);
```

```javascript
// Get the app's local folder.
var localFolder = Windows.Storage.ApplicationData.current.localFolder;

// Create a new subfolder in the current folder.
// Raise an exception if the folder already exists.
var desiredName = "Subfolder";
var CreationCollisionOption = Windows.Storage.CreationCollisionOption;
var newFolderPromise = localFolder.createFolderAsync(desiredName, CreationCollisionOption.failIfExists);
newFolderPromise.done(function createFolderSuccess(newFolder) {
    // Subfolder was created in the current folder.

}, function createFolderFail(error) {
    // Subfolder creation fails if the folder already exists. 
});
```

```cpp
 //Get apps local folder
 StorageFolder^ localFolder = Windows::Storage::ApplicationData::Current->LocalFolder;
 
 // Create a new subfolder in the current folder
 // Raise an exception if it already exists
 String^ desiredName = "Subfolder";
 create_task(localFolder->CreateFolderAsync(desiredName,Windows::Storage::CreationCollisionOption::FailIfExists)).then([](StorageFolder^ folder)
 {
    //Do something with folder
 });
```



## -see-also
[CreateFolderAsync(String, CreationCollisionOption)](storagefolder_createfolderasync_1043039832.md)