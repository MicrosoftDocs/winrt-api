---
-api-id: M:Windows.Storage.FileProperties.StorageItemContentProperties.SavePropertiesAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.Object}})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SavePropertiesAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>> propertiesToSave)
-->

# Windows.Storage.FileProperties.StorageItemContentProperties.SavePropertiesAsync

## -description
Saves the specified properties and values associated with the item.

## -parameters
### -param propertiesToSave
A collection that contains the names and values of the properties to save as key-value pairs (type [IKeyValuePair](../windows.foundation.collections/ikeyvaluepair_2.md)).

## -returns
No object or value is returned when this method completes.

## -remarks
### **System.ExpandoProperties**

Expando properties are a set of named values associated with a storage file instance in memory. They are not saved persistently in the file system but are retained when a file is saved in the access cache.

They can be written and read by any app, and therefore provide a way to associate information with a storage file. This is useful in scenarios where a storage file is passed from one app to another to communicate extra information about that file.

Expando properties are accessed using the Windows Runtime storage API. They are retrieved as a value using [RetrievePropertiesAsync](storageitemcontentproperties_retrievepropertiesasync_507906171.md) with the "System.ExpandoProperties" property name. The expando properties are written using SavePropertiesAsync. That value is a property set itself so the values within it are accessed using the PropertySet programming model.

The names used to identify values in the System.ExpandoProperties set do not need to conform to the system's property naming scheme (which prefixes property names with "System"). They can be any string value.

The system defines some of the names that should be used. For example, "OriginURL" is used to communicate where a locally-stored file came from if it was downloaded from a remote source. (See [Customizing the download experience](/previous-versions/windows/internet-explorer/ie-developer/compatibility/jj542450(v=vs.85)).)

Apps may define and document the properties that they use so other applications can interoperate with them. For example, System.ExpandoProperties can be used to allow a provider app to pass license information to a Universal Office app, to indicate whether a file can be personal or for business.

## -examples

## -see-also
[storageItemContentProperties class](storageitemcontentproperties.md), [storageItemContentProperties.savePropertiesAsync() method](storageitemcontentproperties_savepropertiesasync_330113698.md), [Windows.Foundation.Collections.IKeyValuePair interface](../windows.foundation.collections/ikeyvaluepair_2.md), [System.Dynamic.ExpandoObject](/dotnet/api/system.dynamic.expandoobject?view=dotnet-uwp-10.0&preserve-view=true)
