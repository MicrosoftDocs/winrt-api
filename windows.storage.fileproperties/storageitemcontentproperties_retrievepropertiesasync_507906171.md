---
-api-id: M:Windows.Storage.FileProperties.StorageItemContentProperties.RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Storage.FileProperties.StorageItemContentProperties.RetrievePropertiesAsync

## -description
Retrieves the specified properties associated with the item.

## -parameters
### -param propertiesToRetrieve
A collection that contains the names of the properties to retrieve. The list of supported properties can be found on the [Core properties page](/windows/desktop/properties/core-bumper).

## -returns
When this method completes successfully, it returns a collection (type [IMap](../windows.foundation.collections/imap_2.md)) that contains the specified properties and values as key-value pairs. The return value of properties can be null.

## -remarks
Expando properties can be retrieved by RetrievePropertiesAsync. See the remarks under [SavePropertiesAsync(IIterable(IKeyValuePair))](storageitemcontentproperties_savepropertiesasync_132989229.md).

## -examples

## -see-also
[Core properties page](/windows/desktop/properties/core-bumper),[StorageItemContentProperties class](storageitemcontentproperties.md), [SavePropertiesAsync(IIterable(IKeyValuePair))](storageitemcontentproperties_savepropertiesasync_132989229.md), [Windows.Foundation.Collections.IMap interface](../windows.foundation.collections/imap_2.md)
