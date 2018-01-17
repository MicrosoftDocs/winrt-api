---
-api-id: P:Windows.Media.Capture.Frames.AudioMediaFrame.AudioEncodingProperties
-api-type: winrt property
---

<!-- Property syntax.
public AudioEncodingProperties AudioEncodingProperties { get; }
-->

# Windows.Media.Capture.Frames.AudioMediaFrame.AudioEncodingProperties

## -description
Gets an [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) object that provides information about the audio data in the frame. This includes information like the bitrate, sample rate, and channel count of the audio data.

## -property-value
An [AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md) object that provides information about the audio data in the frame.

## -remarks
Use the [CurrentFormat](mediaframesource_currentformat.md) property of a [MediaFrameSource](mediaframesource.md) object to retrieve a [MediaFrameFormat](mediaframeformat.md) object describing the format of the media being provided by the source. For audio sources, you can check the [MediaFrameFormat.AudioEncodingProperties](mediaframeformat_audioencodingproperties.md) to determine the format of the audio data the source produces.  

## -see-also
[AudioEncodingProperties](../windows.media.mediaproperties/audioencodingproperties.md)

## -examples

