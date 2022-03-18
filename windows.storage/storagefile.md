---
-api-id: T:Windows.Storage.StorageFile
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFile : Windows.Storage.IStorageFile, Windows.Storage.IStorageFile2, Windows.Storage.IStorageFilePropertiesWithAvailability, Windows.Storage.IStorageItem, Windows.Storage.IStorageItem2, Windows.Storage.IStorageItemProperties, Windows.Storage.IStorageItemProperties2, Windows.Storage.IStorageItemPropertiesWithProvider, Windows.Storage.Streams.IInputStreamReference, Windows.Storage.Streams.IRandomAccessStreamReference
-->

# Windows.Storage.StorageFile

## -description

Represents a file. Provides information about the file and its content, and ways to manipulate them.

## -remarks

Typically, you access StorageFile objects as the result of asynchronous method and/or function calls. For example, both of the static methods [GetFileFromPathAsync](storagefile_getfilefrompathasync_1252266672.md) and [GetFileFromApplicationUriAsync](storagefile_getfilefromapplicationuriasync_1702427701.md) return a StorageFile that represents the specified file.

Additionally, whenever you call a file picker to let the user pick a file (or files) the file picker will return the file as a StorageFile.

> [!NOTE]
> StorageFile objects can't represent files that are ".lnk", ".url", or ".wsh" file types.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | GetFileFromPathForUserAsync |

## -examples

This example shows you how to call a file picker, using [FileOpenPicker.PickSingleFileAsync](../windows.storage.pickers/fileopenpicker_picksinglefileasync_1320627792.md) to capture and process a file that the users picks.

```csharp
var openPicker = new FileOpenPicker();
StorageFile file = await openPicker.PickSingleFileAsync();
// Process picked file
if (file != null)
{
    // Store file for future access
    Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.Add(file);
}
else
{
    // The user didn't pick a file
}
```

After [PickSingleFileAsync](../windows.storage.pickers/fileopenpicker_picksinglefileasync_1320627792.md) completes, `file` gets the picked file as a StorageFile.

In the example, `openPicker` contains a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) object. To learn more about using file picker see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

Additionally, `fileToken` gets an identifier that you can use to retrieve the file from the [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md). To learn more about storing files and folders so you can access them again later, see [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md), [MostRecentlyUsedList](../windows.storage.accesscache/storageapplicationpermissions_mostrecentlyusedlist.md) and [Track recently used files and folders](/windows/uwp/files/how-to-track-recently-used-files-and-folders).

## -see-also

[StorageFolder](storagefolder.md), [IStorageFile](istoragefile.md), [IStorageItem](istorageitem.md), [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md), [IInputStreamReference](../windows.storage.streams/iinputstreamreference.md), [IStorageItemProperties](istorageitemproperties.md), [IStorageItemProperties2](istorageitemproperties2.md), [IStorageItem2](istorageitem2.md), [IStorageItemPropertiesWithProvider](istorageitempropertieswithprovider.md), [IStorageFilePropertiesWithAvailability](istoragefilepropertieswithavailability.md), [Serializing and deserializing data sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DataReaderWriter), [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess)

## -capabilities

documentsLibrary, musicLibrary, picturesLibrary, videosLibrary
