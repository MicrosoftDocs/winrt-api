---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterAudioDecoder(System.String,System.Guid,System.Guid,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterAudioDecoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype, Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.MediaExtensionManager.RegisterAudioDecoder

## -description
Registers an audio decoder for the specified input and output media types with an optional configuration parameter.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the audio decoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the audio decoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the audio decoder.

### -param configuration
An optional parameter that contains the configuration properties to be passed to the audio decoder.

## -remarks

## -examples

## -see-also
[RegisterAudioDecoder(String, Guid, Guid)](mediaextensionmanager_registeraudiodecoder_2105091829.md)