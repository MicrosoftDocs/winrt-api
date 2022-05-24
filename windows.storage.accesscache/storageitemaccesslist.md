---
-api-id: T:Windows.Storage.AccessCache.StorageItemAccessList
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemAccessList : Windows.Storage.AccessCache.IStorageItemAccessList
-->

# Windows.Storage.AccessCache.StorageItemAccessList

## -description
Represents your app's future-access list (obtained from the static [StorageApplicationPermissions.FutureAccessList](storageapplicationpermissions_futureaccesslist.md) property). By picking files and folders, your user grants your app permission to access items that might not be accessible otherwise. If you add these items to your future-access list then you'll retain that permission when your app wants to access those items again later. Items are stored in the future-access list as [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks
Use this future-access list to preserve access to files and locations that may not be included with the accessible locations specified by the capabilities in your app manifest. For example, if your app uses a file picker to access a file (or location), we recommend that you store the [StorageFile](../windows.storage/storagefile.md) that is returned from the file picker in this future-access list.

This list can store up to 1000 items and must be maintained by the app.

To see more code examples, see the [File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) and the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

To learn about using the [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md), see [Track recently used files and folders](/windows/uwp/files/how-to-track-recently-used-files-and-folders).

To learn more about what files and locations your app has permission to access, see [File access permissions](/windows/uwp/files/file-access-permissions).

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

We recommend that you store the tokens that are returned by [StorageApplicationPermissions.MostRecentlyUsedList.Add](storageitemmostrecentlyusedlist_add_118555710.md) and [StorageApplicationPermissions.FutureAccessList.Add](storageitemaccesslist_add_118555710.md) so that you can use them to retrieve the respective list entry for the item that you added. In the example, we store the tokens in `mruToken` and `faToken` respectively but we don't do anything else with them.

Additionally, the `savePicker` variable in the example contains a [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object that was created by the sample. To learn more about using the file picker, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers) and [Save a file with a picker](/windows/uwp/files/quickstart-save-a-file-with-a-picker).

## -see-also
[StorageApplicationPermissions.futureAccessList](storageapplicationpermissions_futureaccesslist.md)