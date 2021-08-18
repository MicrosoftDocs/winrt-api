---
-api-id: M:Windows.Storage.StorageFolder.CreateFileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileAsync(System.String desiredName)
-->

# Windows.Storage.StorageFolder.CreateFileAsync

## -description
Creates a new file with the specified name in the current folder.

## -parameters
### -param desiredName
The name of the new file to create in the current folder.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the new file.

## -exceptions
### T:System.IO.FileNotFoundException

The file name contains invalid characters, or the format of the filename is incorrect. Check the value of *desiredName*.

### T:System.UnauthorizedAccessException

You don't have permission to create a file in the current folder.

## -remarks
This method uses the **FailIfExists** value from the [CreationCollisionOption](creationcollisionoption.md) enumeration by default. That is, this method raises an exception if a file with the same name already exists in the current folder. If you want to handle a file name collision in a different way, call the [CreateFileAsync(String, CreationCollisionOption)](storagefolder_createfileasync_1058061470.md) method.

If you try to create a file in a virtual folder like a library, or a folder that represents a container for a group of files (for example, the return value from some overloads of the [GetFoldersAsync](storagefolder_getfoldersasync_592765033.md) method), the **CreateFileAsync** method may fail.

## -examples
The following example shows how to create a new file in the current folder by calling the [CreateFileAsync (String, CreationCollisionOption)](downloadsfolder_createfileasync_1058061470.md) overloaded method. This example explicitly specifies a value for *options* that causes the operation to fail if a file with the specified *desiredName* already exists in the current folder.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's local folder.
StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

// Create a new file in the current folder.
// Raise an exception if the file already exists.
string desiredName = "test.txt";
StorageFile newFile = await localFolder.CreateFileAsync(desiredName, CreationCollisionOption.FailIfExists);
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    // Gets the app's local folder.
    Windows::Storage::StorageFolder localFolder{ Windows::Storage::ApplicationData::Current().LocalFolder() };

    // Create a new file in the current folder, and throw an exception if the file already exists.
    std::wstring desiredName{ L"test.txt" };
    StorageFile newFile{ co_await localFolder.CreateFileAsync(desiredName, Windows::Storage::CreationCollisionOption::FailIfExists) };
    // Do something with the new file.
}
```

```cppcx
//Gets the app's local folder
StorageFolder^ localFolder = ApplicationData::Current->LocalFolder;

//Create a new file in the current folder
// Raise an exception if the file already exists
String^ desiredName = "test.txt";
auto createFileTask = create_task(localFolder->CreateFileAsync(desiredName, Windows::Storage::CreationCollisionOption::FailIfExists));
createFileTask.then([](StorageFile^ newFile)
{
  //Do something with the new file.
 });
```

## -see-also
[CreateFileAsync(String, CreationCollisionOption)](storagefolder_createfileasync_1058061470.md)