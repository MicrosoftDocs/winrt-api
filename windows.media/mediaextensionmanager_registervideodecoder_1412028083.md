---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterVideoDecoder(System.String,System.Guid,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterVideoDecoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype)
-->

# Windows.Media.MediaExtensionManager.RegisterVideoDecoder

## -description
Registers an video decoder for the specified input and output media types.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the video decoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the video decoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the video decoder.

## -remarks

## -examples

## -see-also
[RegisterVideoDecoder(String, Guid, Guid, IPropertySet)](mediaextensionmanager_registervideodecoder_1436147605.md)