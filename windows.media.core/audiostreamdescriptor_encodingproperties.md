---
-api-id: P:Windows.Media.Core.AudioStreamDescriptor.EncodingProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.MediaProperties.AudioEncodingProperties EncodingProperties { get; }
-->

# Windows.Media.Core.AudioStreamDescriptor.EncodingProperties

## -description
Gets an object describing the encoding properties for the audio stream. These properties include the sample rate and channel count of the audio.

## -property-value
The encoding properties on the audio stream.

## -remarks
The application can change the encoding properties of the audio stream descriptor at any time.

If the media pipeline cannot handle the new encoding properties, a [MediaStreamSource](mediastreamsource.md) will raise the [Closed](mediastreamsource_closed.md) event which provides information regarding the error.

## -examples

## -see-also
[AudioEncodingProperties](../windows.media.mediaproperties/imediaencodingproperties.md)