---
-api-id: T:Windows.Storage.AccessCache.StorageApplicationPermissions
-api-type: winrt class
---

<!-- Class syntax.
public class StorageApplicationPermissions 
-->

# Windows.Storage.AccessCache.StorageApplicationPermissions

## -description

Provides static properties for you to get your app's most recently used list (MRU) (use [StorageApplicationPermissions.MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md)) and future-access list (use [StorageApplicationPermissions.FutureAccessList](storageapplicationpermissions_futureaccesslist.md).

## -remarks

Access the methods and properties of this class statically.

To see more code examples, see the [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) and the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

To learn about using the [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md), see [Track recently used files and folders](/windows/uwp/files/how-to-track-recently-used-files-and-folders).

To learn about what files and locations your app has permission to access, see [File access permissions](/windows/uwp/files/file-access-permissions).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | GetFutureAccessListForUser |
| 1903 | 18362 | GetMostRecentlyUsedListForUser |

## -examples

This example demonstrates how to add an item to the app's [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md).

```csharp
StorageFile file = await savePicker.PickSaveFileAsync();
if (file != null)
{
    // Add to MRU with metadata (For example, a string that represents the date)
    string mruToken = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList.Add(file, "20120716");

    // Add to FA without metadata
    string faToken = Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.Add(file);  
}
else
{
    // The file picker was dismissed with no file selected to save
}
```

```cppwinrt
#include <sstream>
#include <winrt/Windows.Storage.h>
#include <winrt/Windows.Storage.AccessCache.h>
#include <winrt/Windows.Storage.Pickers.h>
using namespace winrt;
using namespace Windows::Storage::Pickers;
using namespace Windows::Storage;
...
winrt::fire_and_forget AddToLists()
{
    FileSavePicker savePicker;
    auto plainTextExtensions{ winrt::single_threaded_vector<winrt::hstring>() };
    plainTextExtensions.Append(L".txt");
    savePicker.FileTypeChoices().Insert(L"Plain Text", plainTextExtensions);
    savePicker.SuggestedFileName(L"New Document");

    StorageFile file{ co_await savePicker.PickSaveFileAsync() };
    if (file)
    {
        // Add to MRU with metadata (For example, a string that represents the date)
        winrt::hstring mruToken { Windows::Storage::AccessCache::StorageApplicationPermissions::MostRecentlyUsedList().Add(file, L"20120716") };

        // Add to FA without metadata
        winrt::hstring faToken { Windows::Storage::AccessCache::StorageApplicationPermissions::FutureAccessList().Add(file) };
    }
    else
    {
        // The file picker was dismissed with no file selected to save
    }
}
```

It is recommended that you store the tokens returned by [StorageApplicationPermissions.MostRecentlyUsedList.Add](storageitemmostrecentlyusedlist_add_118555710.md) and [StorageApplicationPermissions.FutureAccessList.Add](storageitemaccesslist_add_118555710.md) so that you can use them to retrieve the respective list entry for the item that you added. In the example, we store the tokens in `mruToken` and `faToken` respectively but we don't do anything else with them.

Additionally, the `savePicker` variable in the example contains a [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object that was created by the sample. To learn more about saving files with file picker, see [Save a file with a picker](/windows/uwp/files/quickstart-save-a-file-with-a-picker). To learn about accessing files, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

## -see-also
