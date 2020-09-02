---
-api-id: M:Windows.Storage.FileProperties.MusicProperties.RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Storage.FileProperties.MusicProperties.RetrievePropertiesAsync

## -description
Retrieves the specified music-related Windows file properties associated with the item.

## -parameters
### -param propertiesToRetrieve
A collection that contains the names of the properties to retrieve.

## -returns
When this method completes successfully, it returns a collection (type [IMap](../windows.foundation.collections/imap_2.md)) that contains the specified properties and values as key-value pairs.

## -remarks
For more information about the music-related file properties you can retrieve using this method, see [Music Windows Properties](/windows/desktop/properties/music-bumper).

In JavaScript, use [then](/previous-versions/windows/apps/br229728(v=win.10)) or [done](/previous-versions/windows/apps/hh701079(v=win.10)) to specify handler functions that will capture and process the collection when it is returned.

## -examples

## -see-also
[Windows.Foundation.Collections.IMap interface](../windows.foundation.collections/imap_2.md)