---
-api-id: T:Windows.Storage.FileProperties.MusicProperties
-api-type: winrt class
---

<!-- Class syntax.
public class MusicProperties : Windows.Storage.FileProperties.IMusicProperties, Windows.Storage.FileProperties.IStorageItemExtraProperties
-->

# Windows.Storage.FileProperties.MusicProperties

## -description
Provides access to the music-related properties of an item (like a file or folder).

## -remarks
You can access a MusicProperties object asynchronously using the [GetMusicPropertiesAsync](storageitemcontentproperties_getmusicpropertiesasync_1352653225.md) method from the [Properties](../windows.storage/istorageitemproperties_properties.md) property of an item (like a file of folder), or synchronously using the [MusicProperties](../windows.storage.bulkaccess/istorageiteminformation_musicproperties.md) property if it is available.
You can get a musicProperties object using any of the following methods and properties:

+ [StorageItemContentProperties.GetMusicPropertiesAsync](storageitemcontentproperties_getmusicpropertiesasync_1352653225.md) method, which can be accessed using the [Properties](../windows.storage/istorageitemproperties_properties.md) property, if it is available.
+ [FileInformation.MusicProperties](../windows.storage.bulkaccess/fileinformation_musicproperties.md) property
+ [FolderInformation.MusicProperties](../windows.storage.bulkaccess/folderinformation_musicproperties.md) property


> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to retrieve properties of a file, including music properties like [Album](musicproperties_album.md) and [Rating](musicproperties_rating.md).

```csharp

try
{
    StorageFile file = rootPage.sampleFile;
    if (file != null)
    {
        StringBuilder outputText = new StringBuilder();

        // Get music properties
        MusicProperties musicProperties = await file.Properties.GetMusicPropertiesAsync();
        outputText.AppendLine("Album: " + musicProperties.Album);
        outputText.AppendLine("Rating: " + musicProperties.Rating);
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
 // For example, handle a file not found error
}
```

After [GetMusicPropertiesAsync](storageitemcontentproperties_getmusicpropertiesasync_1352653225.md) completes, `musicProperties` gets a MusicProperties object.

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[StorageItemContentProperties.getMusicPropertiesAsync method](storageitemcontentproperties_getmusicpropertiesasync_1352653225.md), [Windows.Storage.BulkAccess.fileInformation.musicProperties property](../windows.storage.bulkaccess/fileinformation_musicproperties.md), [Windows.Storage.BulkAccess.folderInformation.musicProperties property](../windows.storage.bulkaccess/folderinformation_musicproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.MusicProperties property](../windows.storage.bulkaccess/istorageiteminformation_musicproperties.md)
