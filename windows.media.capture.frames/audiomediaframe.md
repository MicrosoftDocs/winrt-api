---
-api-id: T:Windows.Media.Capture.Frames.AudioMediaFrame
-api-type: winrt class
---

<!-- Class syntax.
public class AudioMediaFrame 
-->

# Windows.Media.Capture.Frames.AudioMediaFrame

## -description
Represents a frame of audio data retreived from a [MediaFrameSource](mediaframesource.md).

## -remarks
Get an instance of this class by accessing the [AudioMediaFrame](mediaframereference_audiomediaframe.md) property of a [MediaFrameReference](mediaframereference.md) object that was obtained from a media frame source with a call to [MediaFrameReader.TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md). Call [GetAudioFrame](audiomediaframe_getaudioframe_2089312515.md) to get a copy of the frame as an [AudioFrame](../windows.media/audioframe.md) object, which provides access to the underlying audio data.


## -see-also
[MediaFrameReference](mediaframereference.md),[TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md),[AudioFrame](../windows.media/audioframe.md)

## -examples

