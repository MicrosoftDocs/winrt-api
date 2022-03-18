---
-api-id: P:Windows.Storage.StorageFile.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.FileProperties.StorageItemContentProperties Properties { get; }
-->

# Windows.Storage.StorageFile.Properties

## -description
Gets an object that provides access to the content-related properties of the file.

## -property-value
The object that provides access to the content-related properties of the file.

## -remarks
> [!NOTE]
> Properties that are get or set using a property handler that is defined by another app (like Microsoft Word) may not be accessible. Instead, you can try to get these properties using a file query that is backed by the system index. For more information, see [QueryOptions](../windows.storage.search/queryoptions.md).

For more code samples about accessing properties, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

## -examples
This example demonstrates how to retrieve content properties or specified properties from a file using StorageFile.Properties.

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

After [GetImagePropertiesAsync](../windows.storage.fileproperties/storageitemcontentproperties_getimagepropertiesasync_292219360.md) completes, `imageProperties` gets a [ImageProperties](../windows.storage.fileproperties/imageproperties.md) object. Additionally, after [RetrievePropertiesAsync](../windows.storage.fileproperties/storageitemcontentproperties_retrievepropertiesasync_507906171.md) completes, `extraProperties` gets an object that contains the specified properties.

In the example, `file` contains a [StorageFile](storagefile.md) that represents the file to retrieve properties for.

## -see-also
