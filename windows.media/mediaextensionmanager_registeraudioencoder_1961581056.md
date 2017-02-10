---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterAudioEncoder(System.String,System.Guid,System.Guid,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterAudioEncoder(System.String activatableClassId, System.Guid inputSubtype, System.Guid outputSubtype, Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.MediaExtensionManager.RegisterAudioEncoder

## -description
Registers an audio encoder for the specified input and output media types with an optional configuration parameter.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the audio encoder. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param inputSubtype
The guid identifier of the media type that the audio encoder accepts as input.

### -param outputSubtype
The guid identifier of the media type that is output by the audio encoder.

### -param configuration
An optional parameter that contains the configuration properties to be passed to the audio encoder.

## -remarks

## -examples

## -see-also
[RegisterAudioEncoder(String, Guid, Guid)](mediaextensionmanager_registeraudioencoder_1968919336.md)