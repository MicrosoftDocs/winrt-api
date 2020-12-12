---
-api-id: T:Windows.Storage.FileProperties.ImageProperties
-api-type: winrt class
---

<!-- Class syntax.
public class ImageProperties : Windows.Storage.FileProperties.IImageProperties, Windows.Storage.FileProperties.IStorageItemExtraProperties
-->

# Windows.Storage.FileProperties.ImageProperties

## -description
Provides access to the image-related properties of an item (like a file or folder).

## -remarks
You can access a ImageProperties object asynchronously using the [getImagePropertiesAsync](storageitemcontentproperties_getimagepropertiesasync_292219360.md) method from the [Properties](../windows.storage/istorageitemproperties_properties.md) property of an item (like a file of folder), or synchronously using the [ImageProperties](../windows.storage.bulkaccess/istorageiteminformation_imageproperties.md) property if it is available.
You can get a ImageProperties object using any of the following methods and properties:

+ [StorageItemContentProperties.getImagePropertiesAsync](storageitemcontentproperties_getimagepropertiesasync_292219360.md) method, which can be accessed using the [Properties](../windows.storage/istorageitemproperties_properties.md) property, if it is available.
+ [FileInformation.imageProperties](../windows.storage.bulkaccess/fileinformation_imageproperties.md) property
+ [FolderInformation.imageProperties](../windows.storage.bulkaccess/folderinformation_imageproperties.md) property


> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to retrieve properties of a file, including image properties like [DateTaken](imageproperties_datetaken.md) and [Rating](imageproperties_rating.md).

```csharp

try
{
    StorageFile file = rootPage.sampleFile;
    if (file != null)
    {
        StringBuilder outputText = new StringBuilder();

        // Get image properties
        ImageProperties imageProperties = await file.Properties.GetImagePropertiesAsync();
        outputText.AppendLine("Date taken: " + imageProperties.DateTaken);
        outputText.AppendLine("Rating: " + imageProperties.Rating);
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
 // For example, handle a file not found error
}
```

After [GetImagePropertiesAsync](storageitemcontentproperties_getimagepropertiesasync_292219360.md) completes, `imageProperties` gets a ImageProperties object.

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[StorageItemContentProperties.getImagePropertiesAsync method](storageitemcontentproperties_getimagepropertiesasync_292219360.md), [Windows.Storage.BulkAccess.FileInformation.imageProperties  property](../windows.storage.bulkaccess/fileinformation_imageproperties.md), [Windows.Storage.BulkAccess.FolderInformation.imageProperties property](../windows.storage.bulkaccess/folderinformation_imageproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.ImageProperties property](../windows.storage.bulkaccess/istorageiteminformation_imageproperties.md)
