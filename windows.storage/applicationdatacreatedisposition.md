---
-api-id: T:Windows.Storage.ApplicationDataCreateDisposition
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.ApplicationDataCreateDisposition : int
-->

# ApplicationDataCreateDisposition

## -description
Specifies options for creating application data containers or returning existing containers. This enumeration is used by the [ApplicationDataContainer.CreateContainer](applicationdatacontainer_createcontainer_1839874827.md) method.

## -enum-fields
### -field Always:0
Always returns the specified container. Creates the container if it does not exist.

### -field Existing:1
Returns the specified container only if it already exists. Raises an exception of type **System.Exception** if the specified container does not exist.

## -remarks

## -examples
See the code example in [ApplicationDataContainer](applicationdatacontainer.md).

## -see-also
[Quickstart: Local application data (JavaScript)](http://msdn.microsoft.com/library/87dfe8e5-2d01-45cf-bcb1-25f54219a439), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Quickstart: Roaming application data (JavaScript)](http://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [ApplicationDataContainer.CreateContainer](applicationdatacontainer_createcontainer_1839874827.md)