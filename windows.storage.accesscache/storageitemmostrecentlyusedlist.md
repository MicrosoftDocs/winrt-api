---
-api-id: T:Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemMostRecentlyUsedList : Windows.Storage.AccessCache.IStorageItemAccessList, Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList, Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList2
-->

# Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList

## -description
Represents your app's most recently used list (MRU) (obtained from the static [StorageApplicationPermissions.MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md) property). You use your MRU to track items (files and/or folders) that the user has accessed most recently. Items are stored in the MRU as [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects.

## -remarks
Use the most recently used (MRU) list to track files and/or locations that your user accesses frequently.

This list can store up to 25 items. While the app must add items to the MRU in order to track them, Windows maintains the 25-item limit by removing stale items if necessary.

> [!NOTE]
> If you want to respond to [ItemRemoved](storageitemmostrecentlyusedlist_itemremoved.md) events you must register your event handle every time you get a new reference to the StorageItemMostRecentlyUsedList.

To see more code examples, see the [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) and the [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445).

To learn about using the [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md), see [How to track recently used files and folders](https://docs.microsoft.com/previous-versions/windows/apps/hh972603(v=win.10)).

To learn more about what files and locations your app has permission to access, see [File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions).

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

```javascript
savePicker.pickSaveFileAsync().then(function (file) {
    if (file) {
        // Add to MRU with metadata (For example, a string that represents the date)
        var mruToken = StorageApplicationPermissions.mostRecentlyUsedList.add(file, "20120716");

        // Add to FA without metadata
        var faToken = Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.add(file);
    } else {
        // The file picker was dismissed with no file selected to save
    }
});
```

We recommend that you store the tokens that are returned by [StorageApplicationPermissions.MostRecentlyUsedList.Add](storageitemmostrecentlyusedlist_add_118555710.md) and [StorageApplicationPermissions.FutureAccessList.Add](storageitemaccesslist_add_118555710.md) so that you can use them to retrieve the respective list entry for the item that you added. In the example, we store the tokens in `mruToken` and `faToken` respectively but we don't do anything else with them.

Additionally, the `savePicker` variable in the example contains a [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object that was created by the sample. To learn more about saving files with file picker, see [How to save files through ](https://docs.microsoft.com/previous-versions/windows/apps/jj150595(v=win.10)). To learn about accessing files, see [Quickstart: Accessing files with ](https://docs.microsoft.com/previous-versions/windows/apps/hh465199(v=win.10)).

## -see-also
[StorageItemMostrecentlyUsedList.mostRecentlyUsedList property](storageapplicationpermissions_mostrecentlyusedlist.md)
