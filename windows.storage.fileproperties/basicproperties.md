---
-api-id: T:Windows.Storage.FileProperties.BasicProperties
-api-type: winrt class
---

<!-- Class syntax.
public class BasicProperties : Windows.Storage.FileProperties.IBasicProperties, Windows.Storage.FileProperties.IStorageItemExtraProperties
-->

# Windows.Storage.FileProperties.BasicProperties

## -description
Provides access to the basic properties, like the size of the item or the date the item was last modified, of the item (like a file or folder).

## -remarks
You can access a BasicProperties object asynchronously using the [GetBasicPropertiesAsync](../windows.storage/istorageitem_getbasicpropertiesasync_375277280.md) method of an item (like a file of folder), or synchronously using the [BasicProperties](../windows.storage.bulkaccess/istorageiteminformation_basicproperties.md) property if it is available.

You can get a BasicProperties object using any of the following methods and properties:

+ [storageFile.getBasicPropertiesAsync](../windows.storage/storagefile_getbasicpropertiesasync_375277280.md) method
+ [storageFolder.getBasicPropertiesAsync](../windows.storage/storagefolder_getbasicpropertiesasync_375277280.md) method
+ [FileInformation.basicProperties](../windows.storage.bulkaccess/fileinformation_basicproperties.md) property
+ [FolderInformation.basicProperties](../windows.storage.bulkaccess/folderinformation_basicproperties.md) property


## -examples
The [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) demonstrates how to retrieve properties of a file, including basic properties like [Size](basicproperties_size.md) and [DateModified](basicproperties_datemodified.md).

```csharp
try
{
    StorageFile file = rootPage.sampleFile;
    if (file != null)
    {
        StringBuilder outputText = new StringBuilder();

        // Get basic properties
        BasicProperties basicProperties = await file.GetBasicPropertiesAsync();
        outputText.AppendLine("File size: " + basicProperties.Size + " bytes");
        outputText.AppendLine("Date modified: " + basicProperties.DateModified);

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

After [GetBasicPropertiesAsync](../windows.storage/storagefile_getbasicpropertiesasync_375277280.md) completes, `basicProperties` gets a BasicProperties object.

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[IStorageItemExtraProperties](istorageitemextraproperties.md), [Windows.Storage.StorageFile.getBasicPropertiesAsync method](../windows.storage/storagefile_getbasicpropertiesasync_375277280.md), [Windows.Storage.StorageFolder.getBasicPropertiesAsync method](../windows.storage/storagefolder_getbasicpropertiesasync_375277280.md), [Windows.Storage.IStorageItem.GetBasicPropertiesAsync method](../windows.storage/istorageitem_getbasicpropertiesasync_375277280.md), [Windows.Storage.BulkAccess.FileInformation.basicProperties property](../windows.storage.bulkaccess/fileinformation_basicproperties.md), [Windows.Storage.BulkAccess.FolderInformation.BasicProperties property](../windows.storage.bulkaccess/folderinformation_basicproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.BasicProperties property](../windows.storage.bulkaccess/istorageiteminformation_basicproperties.md)
