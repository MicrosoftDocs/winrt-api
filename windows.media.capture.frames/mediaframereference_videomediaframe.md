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
If the frame reference wraps a different type of frame, such as a [BufferMediaFrame](buffermediaframe.md), the object returned by this property is null.

## -examples

## -see-also
