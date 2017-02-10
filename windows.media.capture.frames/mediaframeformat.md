---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameFormat
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameFormat : Windows.Media.Capture.Frames.IMediaFrameFormat
-->

# Windows.Media.Capture.Frames.MediaFrameFormat

## -description
Describes the format of a media frame obtained from a [MediaFrameSource](mediaframesource.md) and represented by a [MediaFrameReference](mediaframereference.md).

## -remarks
The [MediaFrameSource](mediaframesource.md) class uses this object to specify the current format of the media frames it generates. Get the current format of a media frame source by accessing the [CurrentFormat](mediaframesource_currentformat.md) property. Set the current format of a media frame source by calling [SetFormatAsync](mediaframesource_setformatasync.md).

Get the format of a media frame represented by a [MediaFrameReference](mediaframereference.md) by accessing the [Format](mediaframereference_format.md) property.

Get the format of a video frame represented by a [VideoMediaFrame](videomediaframe.md) by accessing the [VideoFormat](depthmediaframeformat_videoformat.md) property and then using the returned object's [MediaFrameFormat](mediaframeformat.md) property.

## -examples

## -see-also
