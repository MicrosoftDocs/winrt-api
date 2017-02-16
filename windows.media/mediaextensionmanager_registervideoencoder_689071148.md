---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterVideoEncoder(System.String,System.Guid,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterVideoEncoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype)
-->

# Windows.Media.MediaExtensionManager.RegisterVideoEncoder

## -description
Registers a video encoder for the specified input and output media types.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the video encoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the video encoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the video encoder.

## -remarks

## -examples

## -see-also
[RegisterVideoEncoder(String, Guid, Guid, IPropertySet)](mediaextensionmanager_registervideoencoder_681733388.md)