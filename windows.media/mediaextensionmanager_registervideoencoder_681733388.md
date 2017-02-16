---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterVideoEncoder(System.String,System.Guid,System.Guid,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterVideoEncoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype, Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.MediaExtensionManager.RegisterVideoEncoder

## -description
Registers a video encoder for the specified input and output media types with an optional configuration parameter.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the video encoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the video encoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the video encoder.

### -param configuration
An optional parameter that contains the configuration properties to be passed to the video encoder.

## -remarks

## -examples

## -see-also
[RegisterVideoEncoder(String, Guid, Guid)](mediaextensionmanager_registervideoencoder_689071148.md)