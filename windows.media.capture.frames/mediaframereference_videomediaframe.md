---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameReference.VideoMediaFrame
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.Frames.VideoMediaFrame VideoMediaFrame { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameReference.VideoMediaFrame

## -description
Gets the [VideoMediaFrame](videomediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md), if that is the type of frame represented.

## -property-value
The [VideoMediaFrame](videomediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md).

## -remarks
If the frame reference wraps a different type of frame, or if the video frame data is in a format that is unsupported, such as RGB24, then this property is null. In this case, you can access the [BufferMediaFrame](mediaframereference_buffermediaframe.md) property, which is always non-null.

## -examples

## -see-also
