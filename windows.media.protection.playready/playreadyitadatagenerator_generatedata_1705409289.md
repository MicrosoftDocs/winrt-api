---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyITADataGenerator.GenerateData(System.Guid,System.UInt32,Windows.Foundation.Collections.IPropertySet,Windows.Media.Protection.PlayReady.PlayReadyITADataFormat)
-api-type: winrt method
---

<!-- Method syntax
public byte[] GenerateData(System.Guid guidCPSystemId, System.UInt32 countOfStreams, Windows.Foundation.Collections.IPropertySet configuration, Windows.Media.Protection.PlayReady.PlayReadyITADataFormat format)
-->

# Windows.Media.Protection.PlayReady.PlayReadyITADataGenerator.GenerateData

## -description
Returns a serialized blob of the specified [IPropertySet](../windows.foundation.collections/ipropertyset.md) data that the PlayReady ITA can consume if wrapped in a content protection instantiation format.

## -parameters
### -param guidCPSystemId
The content protection system **GUID**.

### -param countOfStreams
The stream count.

### -param configuration
The data to be returned as a serialized blob.

### -param format
The format for the ITA serialized data.

## -returns
The serialized blob. See Remarks.

## -remarks
The following schema describes the serialized blob that is returned from this method:


1. **GUID** – the content protection system **GUID**.
1. **DWORD** – the stream count.
1. **DWORD** – next stream ID.
1. **DWORD** – next stream’s binary data size.
1. **BYTE*** - next stream’s binary data.
1. Repeat steps 3, 4, and 5 for each stream.


**IPropertySet** may contain any of the following values but must contain at least one of them.


+ The property *N*, where *N* is replaced by the base-10 stream number being decrypted, set to the PlayReady Object corresponding to that stream.
+ The property  set to a PlayReady Object that will be used for any stream number that was not set using *N* as described above.


For more information about the serialized blob, see [PlayReadyITADataFormat](playreadyitadataformat.md).

## -examples

## -see-also
