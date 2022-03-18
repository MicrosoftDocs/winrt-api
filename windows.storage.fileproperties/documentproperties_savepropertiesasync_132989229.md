---
-api-id: M:Windows.Storage.FileProperties.DocumentProperties.SavePropertiesAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.Object}})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SavePropertiesAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>> propertiesToSave)
-->

# Windows.Storage.FileProperties.DocumentProperties.SavePropertiesAsync

## -description
Saves the specified properties and values associated with the item.

## -parameters
### -param propertiesToSave
A collection that contains the names and values of the properties to save as key-value pairs (type [IKeyValuePair](../windows.foundation.collections/ikeyvaluepair_2.md)).

## -returns
No object or value is returned when this method completes.

## -remarks
To save file properties, create a **[PropertySet](/uwp/api/Windows.Foundation.Collections.PropertySet#Windows_Foundation_Collections_PropertySet__ctor)** and **[Add](/uwp/api/windows.foundation.collections.propertyset#Windows_Foundation_Collections_PropertySet_Add__0__1_)** the file properties to be saved. Once added, use **SavePropertiesAsync** to save the changes.

## -examples

## -see-also
[documentProperties.savePropertiesAsync methods, [documentProperties.savePropertiesAsync() method](documentproperties_savepropertiesasync_330113698.md), [Windows.Foundation.Collections.IKeyValuePair interface](../windows.foundation.collections/ikeyvaluepair_2.md)
