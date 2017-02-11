---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterVideoDecoder(System.String,System.Guid,System.Guid,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterVideoDecoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype, Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.MediaExtensionManager.RegisterVideoDecoder

## -description
Registers a video decoder for the specified input and output media types with an optional configuration parameter.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the video decoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the video decoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the video decoder.

### -param configuration
An optional parameter that contains the configuration properties to be passed to the video decoder.

## -remarks

## -examples

## -see-also
[RegisterVideoDecoder(String, Guid, Guid)](mediaextensionmanager_registervideodecoder_1412028083.md)