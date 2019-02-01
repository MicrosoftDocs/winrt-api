---
-api-id: M:Windows.Storage.FileProperties.BasicProperties.RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> RetrievePropertiesAsync(Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Storage.FileProperties.BasicProperties.RetrievePropertiesAsync

## -description
Retrieves the specified properties associated with the item.

## -parameters
### -param propertiesToRetrieve
A collection that contains the names of the properties to retrieve.

## -returns
When this method completes successfully, it returns a collection (type [IMap](../windows.foundation.collections/imap_2.md)) that contains the specified properties and values as key-value pairs.

## -remarks

In JavaScript, use [then](https://msdn.microsoft.com/library/c63904fc-465b-4fd5-a1d6-e4fb200248e7) or [done](https://msdn.microsoft.com/library/9a5e6877-a2cf-421f-a91e-37d84ccb40da) to specify handler functions that will capture and process the collection when it is returned.

## -examples

## -see-also
[Windows.Foundation.Collections.IMap interface](../windows.foundation.collections/imap_2.md)