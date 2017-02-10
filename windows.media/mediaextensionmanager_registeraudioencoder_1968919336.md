---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterAudioEncoder(System.String,System.Guid,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterAudioEncoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype)
-->

# Windows.Media.MediaExtensionManager.RegisterAudioEncoder

## -description
Registers an audio encoder for the specified input and output media types.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the audio encoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the audio encoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the audio encoder.

## -remarks

## -examples

## -see-also
[RegisterAudioEncoder(String, Guid, Guid, IPropertySet)](mediaextensionmanager_registeraudioencoder_1961581056.md)