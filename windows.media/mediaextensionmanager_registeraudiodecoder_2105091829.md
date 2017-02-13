---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterAudioDecoder(System.String,System.Guid,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterAudioDecoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype)
-->

# Windows.Media.MediaExtensionManager.RegisterAudioDecoder

## -description
Registers an audio decoder for the specified input and output media types.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the audio decoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the audio decoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the audio decoder.

## -remarks

## -examples

## -see-also
[RegisterAudioDecoder(String, Guid, Guid, IPropertySet)](mediaextensionmanager_registeraudiodecoder_2093559763.md)