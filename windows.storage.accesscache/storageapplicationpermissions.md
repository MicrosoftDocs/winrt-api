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

To see more code examples, see the [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) and the [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445).

To learn about using the [FutureAccessList](storageapplicationpermissions_futureaccesslist.md) and [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md), see [How to track recently used files and folders](http://msdn.microsoft.com/library/7062d754-877e-4e59-a1ff-be0603020e6c).

To learn about what files and locations your app has permission to access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

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

It is recommended that you store the tokens returned by [StorageApplicationPermissions.MostRecentlyUsedList.Add](storageitemmostrecentlyusedlist_add_118555710.md) and [StorageApplicationPermissions.FutureAccessList.Add](storageitemaccesslist_add_118555710.md) so that you can use them to retrieve the respective list entry for the item that you added. In the example, we store the tokens in `mruToken` and `faToken` respectively but we don't do anything else with them.

Additionally, the `savePicker` variable in the example contains a [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object that was created by the sample. To learn more about saving files with file picker, see [How to save files through ](http://msdn.microsoft.com/library/d29085cb-71d1-4537-a375-4a07fc75efc2). To learn about accessing files, see [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e).

## -see-also