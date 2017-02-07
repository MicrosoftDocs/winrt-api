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
You can access a [BasicProperties](basicproperties.md) object asynchronously using the [GetBasicPropertiesAsync](../windows.storage/istorageitem_getbasicpropertiesasync.md) method of an item (like a file of folder), or synchronously using the [BasicProperties](../windows.storage.bulkaccess/istorageiteminformation_basicproperties.md) property if it is available.

You can get a [BasicProperties](basicproperties.md) object using any of the following methods and properties:

+ [storageFile.getBasicPropertiesAsync](../windows.storage/storagefile_getbasicpropertiesasync.md) method
+ [storageFolder.getBasicPropertiesAsync](../windows.storage/storagefolder_getbasicpropertiesasync.md) method
+ [FileInformation.basicProperties](../windows.storage.bulkaccess/fileinformation_basicproperties.md) property
+ [FolderInformation.basicProperties](../windows.storage.bulkaccess/folderinformation_basicproperties.md) property


## -examples
The [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445) demonstrates how to retrieve properties of a file, including basic properties like [Size](basicproperties_size.md) and [DateModified](basicproperties_datemodified.md).

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

```javascript

var file = SdkSample.sampleFile;
if (file !== null) {
    var outputDiv = document.getElementById("output");

    // Get top level file properties
    outputDiv.innerHTML = "Filename: " + file.name + "<br/>";
    outputDiv.innerHTML += "File type: " + file.fileType + "<br/>";

    // Get basic properties
    file.getBasicPropertiesAsync().then(function (basicProperties) {
        outputDiv.innerHTML += "Size: " + basicProperties.size + " bytes<br/>";
        outputDiv.innerHTML += "Date modified: " + basicProperties.dateModified + "<br/>";

        // Get extra properties
        return file.properties.retrievePropertiesAsync([fileOwnerProperty, dateAccessedProperty]);
    }).done(function (extraProperties) {
        var propValue = extraProperties[dateAccessedProperty];
        if (propValue !== null) {
            outputDiv.innerHTML += "Date accessed: " + propValue + "<br/>";
        }
        propValue = extraProperties[fileOwnerProperty];
        if (propValue !== null) {
            outputDiv.innerHTML += "File owner: " + propValue;
        }
    },
    // Handle errors with an error function
 function (error) {
     // Handle errors encountered while retrieving properties
    });
}
```

After [GetBasicPropertiesAsync](../windows.storage/storagefile_getbasicpropertiesasync.md) completes, `basicProperties` gets a [BasicProperties](basicproperties.md) object.

In the example, `file` contains a [StorageFile](../windows.storage/storagefile.md) that represents the file to retrieve properties for.

## -see-also
[IStorageItemExtraProperties](istorageitemextraproperties.md), [Windows.Storage.StorageFile.getBasicPropertiesAsync method](../windows.storage/storagefile_getbasicpropertiesasync.md), [Windows.Storage.StorageFolder.getBasicPropertiesAsync method](../windows.storage/storagefolder_getbasicpropertiesasync.md), [Windows.Storage.IStorageItem.GetBasicPropertiesAsync method](../windows.storage/istorageitem_getbasicpropertiesasync.md), [Windows.Storage.BulkAccess.FileInformation.basicProperties property](../windows.storage.bulkaccess/fileinformation_basicproperties.md), [Windows.Storage.BulkAccess.FolderInformation.BasicProperties property](../windows.storage.bulkaccess/folderinformation_basicproperties.md), [Windows.Storage.BulkAccess.IStorageItemInformation.BasicProperties property](../windows.storage.bulkaccess/istorageiteminformation_basicproperties.md)