---
-api-id: T:Windows.Storage.FileProperties.StorageItemContentProperties
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemContentProperties : Windows.Storage.FileProperties.IStorageItemContentProperties, Windows.Storage.FileProperties.IStorageItemExtraProperties
-->

# Windows.Storage.FileProperties.StorageItemContentProperties

## -description
Provides access to the content-related properties of an item (like a file or folder).

## -remarks
You can get a StorageItemContentProperties object using the [Properties](../windows.storage/istorageitemproperties_properties.md) property that is available on the following objects:

+ [StorageFile.Properties](../windows.storage/storagefile_properties.md) property
+ [StorageFolder.Properties](../windows.storage/storagefolder_properties.md) property
+ [FileInformation.Properties](../windows.storage.bulkaccess/fileinformation_properties.md) property
+ [FolderInformation.Properties](../windows.storage.bulkaccess/folderinformation_properties.md) property


> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to retrieve content properties or specified properties from a file using [StorageFile.Properties](../windows.storage/storagefile_properties.md).

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

        // Specify more properties to retrieve
        readonly string dateAccessedProperty = "System.DateAccessed";
        readonly string fileOwnerProperty = "System.FileOwner";
        List<string> propertiesName = new List<string>();
        propertiesName.Add(dateAccessedProperty);
        propertiesName.Add(fileOwnerProperty);

        // Get the specified properties through StorageFile.Properties
        IDictionary<string, object> extraProperties = await file.Properties.RetrievePropertiesAsync(propertiesName);
        var propValue = extraProperties[dateAccessedProperty];
        if (propValue != null)
        {
            outputText.AppendLine("Date accessed: " + propValue);
        }
        propValue = extraProperties[fileOwnerProperty];
        if (propValue != null)
        {
            outputText.AppendLine("File owner: " + propValue);
        }
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
 // For example, handle a file not found error
}
```

After [GetImagePropertiesAsync](storageitemcontentproperties_getimagepropertiesasync_292219360.md) completes, **imageProperties** gets a [ImageProperties](imageproperties.md) object. Additionally, after [RetrievePropertiesAsync](storageitemcontentproperties_retrievepropertiesasync_507906171.md) completes, **extraProperties** gets an object that contains the specified properties (the list of supported properties can be found on the [Core properties page](/windows/desktop/properties/core-bumper)).

In the example, **file** contains a [StorageFile](../windows.storage/storagefile.md) that represents the file for which to retrieve properties.

## -see-also
[Core properties page](/windows/desktop/properties/core-bumper)
