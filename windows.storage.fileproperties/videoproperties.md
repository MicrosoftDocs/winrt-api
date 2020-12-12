---
-api-id: T:Windows.Storage.FileProperties.VideoProperties
-api-type: winrt class
---

<!-- Class syntax.
public class VideoProperties : Windows.Storage.FileProperties.IStorageItemExtraProperties, Windows.Storage.FileProperties.IVideoProperties
-->

# Windows.Storage.FileProperties.VideoProperties

## -description
Provides access to the video-related properties of an item (like a file or folder).

## -remarks
You can access a VideoProperties object asynchronously using the [getVideoPropertiesAsync](storageitemcontentproperties_getvideopropertiesasync_1365065087.md) method from the [Properties](../windows.storage/istorageitemproperties_properties.md) property of an item (like a file of folder), or synchronously using the [VideoProperties](../windows.storage.bulkaccess/istorageiteminformation_videoproperties.md) property if it is available.
You can get a VideoProperties object using any of the following methods and properties:

+ [StorageItemContentProperties.getVideoPropertiesAsync](storageitemcontentproperties_getvideopropertiesasync_1365065087.md) method, which can be accessed using the [Properties](../windows.storage/istorageitemproperties_properties.md) property, if it is available.
+ [FileInformation.videoProperties](../windows.storage.bulkaccess/fileinformation_videoproperties.md) property
+ [FolderInformation.videoProperties](../windows.storage.bulkaccess/folderinformation_videoproperties.md) property


> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to retrieve properties of a file, including video properties like [Year](videoproperties_year.md) and [Rating](musicproperties_rating.md).

```csharp

try
{
    StorageFile file = rootPage.sampleFile;
    if (file != null)
    {
        StringBuilder outputText = new StringBuilder();

        // Get video properties
        VideoProperties videoProperties = await file.Properties.GetVideoPropertiesAsync();
        outputText.AppendLine("Year: " + videoProperties.Year);
        outputText.AppendLine("Rating: " + videoProperties.Rating);
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
 // For example, handle a file not found error
}
```

After [GetVideoPropertiesAsync](storageitemcontentproperties_getvideopropertiesasync_1365065087.md) completes, `videoProperties` gets a VideoProperties object.

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[StorageItemContentProperties.getVideoPropertiesAsync method](storageitemcontentproperties_getvideopropertiesasync_1365065087.md), [Windows.Storage.BulkAccess.FileInformation.videoProperties property](../windows.storage.bulkaccess/fileinformation_videoproperties.md), [Windows.Storage.BulkAccess.FolderInformation.videoProperties property](../windows.storage.bulkaccess/folderinformation_videoproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.VideoProperties property](../windows.storage.bulkaccess/istorageiteminformation_videoproperties.md)
