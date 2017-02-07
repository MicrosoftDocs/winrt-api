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

To see more code examples, see the [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) and the [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445).

To learn about using the [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md), see [How to track recently used files and folders](http://msdn.microsoft.com/library/7062d754-877e-4e59-a1ff-be0603020e6c).

To learn more about what files and locations your app has permission to access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

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

We recommend that you store the tokens that are returned by [StorageApplicationPermissions.MostRecentlyUsedList.Add](storageitemmostrecentlyusedlist_add.md) and [StorageApplicationPermissions.FutureAccessList.Add](storageitemaccesslist_add.md) so that you can use them to retrieve the respective list entry for the item that you added. In the example, we store the tokens in `mruToken` and `faToken` respectively but we don't do anything else with them.

Additionally, the `savePicker` variable in the example contains a [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object that was created by the sample. To learn more about saving files with file picker, see [How to save files through ](http://msdn.microsoft.com/library/d29085cb-71d1-4537-a375-4a07fc75efc2). To learn about accessing files, see [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e).

## -see-also
[StorageApplicationPermissions.futureAccessList](storageapplicationpermissions_futureaccesslist.md)