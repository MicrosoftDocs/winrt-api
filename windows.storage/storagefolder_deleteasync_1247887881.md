---
-api-id: M:Windows.Storage.StorageFolder.DeleteAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteAsync()
-->

# Windows.Storage.StorageFolder.DeleteAsync

## -description
Deletes the current folder.

## -returns
No object or value is returned by this method when it completes.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to delete the specified folder.

## -remarks
This method implicitly uses [StorageDeleteOption.Default](storagedeleteoption.md) to determine whether the item is deleted permanently.

## -examples
The following example shows how to delete the current folder by calling the [DeleteAsync(StorageDeleteOption)](storagefile_deleteasync_1247887881.md) overloaded method. This example explicitly specifies a value for *option* that deletes the file permanently.

```csharp
using Windows.Storage;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the app's local folder.
StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

// Create a temporary folder in the current folder.
string folderName = "Test";
StorageFolder testFolder = await localFolder.CreateFolderAsync(folderName);

// Has the folder been created?
if(await localFolder.TryGetItemAsync(folderName) != null)
    Debug.WriteLine("Folder " + folderName + " exists.");
else
    Debug.WriteLine("Folder " + folderName + " does not exist.");

// Delete the folder permanently.
await testFolder.DeleteAsync(StorageDeleteOption.PermanentDelete);

// Has the folder been deleted?
if(await localFolder.TryGetItemAsync(folderName) != null)
    Debug.WriteLine("Folder " + folderName + " exists.");
else
    Debug.WriteLine("Folder " + folderName + " does not exist.");
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    Windows::Storage::StorageFolder localFolder{ Windows::Storage::ApplicationData::Current().LocalFolder() };

    std::wstring folderName{ L"test" };

    Windows::Storage::StorageFolder newFolder{ co_await localFolder.CreateFolderAsync(folderName) };

    {
        // Check that the folder exists.
        Windows::Storage::IStorageItem newItem{ co_await localFolder.TryGetItemAsync(folderName) };
        std::wstringstream stringstream;
        stringstream << L"Folder: " << folderName.c_str();
        if (newItem)
        {
            stringstream << L" created" << std::endl;
        }
        else
        {
            stringstream << L" not found" << std::endl;
        }
        ::OutputDebugString(stringstream.str().c_str());
    }

    co_await newFolder.DeleteAsync(Windows::Storage::StorageDeleteOption::PermanentDelete);

    {
        // Check that the folder has been deleted.
        Windows::Storage::IStorageItem newItem{ co_await localFolder.TryGetItemAsync(folderName) };
        std::wstringstream stringstream;
        stringstream << L"Folder: " << folderName.c_str();
        if (newItem)
        {
            stringstream << L" not deleted" << std::endl;
        }
        else
        {
            stringstream << L" deleted" << std::endl;
        }
        ::OutputDebugString(stringstream.str().c_str());
    }
}
```

```cppcx
StorageFolder^ localFolder = ApplicationData::Current->LocalFolder;

String^ folderName = "test";

create_task(localFolder->CreateFolderAsync(folderName)).then([=](StorageFolder^ newFolder) -> task<IStorageItem^> {
    //Check the folder exists
    return create_task(localFolder->TryGetItemAsync(folderName));
}).then([=](IStorageItem^ newFolder) -> task<void> {
    String^ output = "";
    if (newFolder == nullptr)
    {
        output = "Folder: " + folderName + " not found\n";
    }
    else
    {
        output = "Folder: " + folderName + " created\n";
    }
    OutputDebugString(output->Begin());
    return create_task(newFolder->DeleteAsync(StorageDeleteOption::PermanentDelete));
}).then([=]() -> task<IStorageItem^> {
    return create_task(localFolder->TryGetItemAsync(folderName));
}).then([=](IStorageItem^ newFolder) {
    String^ output = "";
    if (newFolder == nullptr)
    {
        output = "Folder: " + folderName + " deleted\n";
    }
    else
    {
        output = "Folder: " + folderName + " not deleted\n";
    }
    OutputDebugString(output->Begin());
});
```

## -see-also
[DeleteAsync(StorageDeleteOption)](storagefolder_deleteasync_175645079.md)