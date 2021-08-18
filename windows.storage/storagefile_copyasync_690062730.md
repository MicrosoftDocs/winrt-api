---
-api-id: M:Windows.Storage.StorageFile.CopyAsync(Windows.Storage.IStorageFolder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder)
-->

# Windows.Storage.StorageFile.CopyAsync

## -description
Creates a copy of the file in the specified folder.

## -parameters
### -param destinationFolder
The destination folder where the copy of the file is created.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the copy of the file created in the *destinationFolder*.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to copy a file into the destination folder.

## -remarks
This method uses the **FailIfExists** value from the [CreationCollisionOption](creationcollisionoption.md) enumeration by default. That is, this method raises an exception if a file with the same name already exists in the destination folder. If you want to handle a file name collision in a different way, call the [CopyAsync(IStorageFolder, String, NameCollisionOption)](storagefile_copyasync_460876542.md) overloaded method.

> [!NOTE]
> When StorageFile.CopyAsync is used to copy a file that is encrypted to a destination that is not encrypted, the call will fail with the following exception: `System.UnauthorizedAccessException: Access is denied. (Excep_FromHResult 0x80070005)`

## -examples
The following example copies a file to the specified folder and renames the copy by calling the [CopyAsync(IStorageFolder, String, NameCollisionOption)](storagefile_copyasync_460876542.md) method. This example explicitly specifies a value for *option* that replaces the file in the destination folder if a file with the specified name already exists.

```csharp
using Windows.Storage;
using System.Threading.Tasks;

// Get the app's temporary folder.
StorageFolder tempFolder = ApplicationData.Current.TemporaryFolder;

// Create a sample file in the temporary folder.
string newFileName = "test.txt";
StorageFile newFile = await tempFolder.CreateFileAsync(newFileName);

// Get the app's local folder to use as the destination folder.
StorageFolder localFolder = ApplicationData.Current.LocalFolder;

// Specify a new name for the copied file.
string renamedFileName = "renamed_test.txt";

// Copy the file to the destination folder and rename it.
// Replace the existing file if the file already exists.
StorageFile copiedFile = await newFile.CopyAsync(localFolder, renamedFileName, NameCollisionOption.ReplaceExisting);
```

```cppwinrt
IAsyncAction MainPage::CopyFileAsync()
{
    // Get the app's temporary folder.
    StorageFolder sourceFolder{ ApplicationData::Current().TemporaryFolder() };
    StorageFolder targetFolder{ ApplicationData::Current().LocalFolder() };

    // Choose source file name and new name for the copied file.
    std::wstring newFileName{ L"test.txt" };
    std::wstring copyFileName{ L"renamed_test.txt" };

    // Create a sample file in the temporary folder.
    StorageFile sourceFile{ co_await sourceFolder.CreateFileAsync(newFileName, Windows::Storage::CreationCollisionOption::ReplaceExisting) };
    // Overwrite any existing file with the same name.
    StorageFile copiedFile{ co_await sourceFile.CopyAsync(targetFolder, copyFileName, Windows::Storage::NameCollisionOption::ReplaceExisting) };
    // Do something with copied file.
}
```

```cppcx
//Get the app's temporary folder
StorageFolder^ sourceFolder = ApplicationData::Current->TemporaryFolder;
StorageFolder^ targetFolder = ApplicationData::Current->LocalFolder;

// Choose source file name and new name for the copied file
String^ newFileName = "test.txt";
String^ copyFileName = "renamed_test.txt";

//Create a sample file in the temporary folder
auto copyFileTask = create_task(sourceFolder->CreateFileAsync(newFileName, Windows::Storage::CreationCollisionOption::ReplaceExisting)).then
([targetFolder, copyFileName](StorageFile^ sourceFile) -> task<StorageFile^>
{
    //Overwrite any existing file with the same name 
    auto copyFileTask = sourceFile->CopyAsync(targetFolder, copyFileName, Windows::Storage::NameCollisionOption::ReplaceExisting);
    return create_task(copyFileTask);
}).then([](StorageFile^ copiedFile) {
    //do something with copied file
});
```

## -see-also
[CopyAsync(IStorageFolder, String)](storagefile_copyasync_1709017142.md), [CopyAsync(IStorageFolder, String, NameCollisionOption)](storagefile_copyasync_460876542.md)