---
-api-id: M:Windows.Storage.Search.QueryOptions.SetPropertyPrefetch(Windows.Storage.FileProperties.PropertyPrefetchOptions,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public void SetPropertyPrefetch(Windows.Storage.FileProperties.PropertyPrefetchOptions options, Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Storage.Search.QueryOptions.SetPropertyPrefetch

## -description
Specifies properties that the system should load in advance for all items in the query result set while the query is being executed (instead of retrieving them on a case-by-case basis). If many properties are specified, the query might take longer to execute, but subsequent property retrieval on query results will be faster.

## -parameters
### -param options
A value that specifies the set of properties to retrieve in advance.

The possible property sets match the sets of properties available on from the [StorageFile](../windows.storage/storagefile.md) class. For example, [PropertyPrefetchOptions.BasicProperties](../windows.storage.fileproperties/propertyprefetchoptions.md) will retrieve all of the properties available through [StorageFile.GetBasicPropertiesAsync](../windows.storage/storagefile_getbasicpropertiesasync_375277280.md) in advance.

### -param propertiesToRetrieve
A custom list of properties to retrieve in advance as an array of property names. Use the system property names to specify properties, for example [System.Copyright](/windows/desktop/properties/props-system-copyright) and [System.Image.ColorSpace](/windows/desktop/properties/props-system-image-colorspace).

A list of additional properties to retrieve.

## -remarks

## -examples

## -see-also
[Folder enumeration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration)
