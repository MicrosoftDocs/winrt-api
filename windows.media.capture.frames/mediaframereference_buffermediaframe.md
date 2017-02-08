---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameReference.BufferMediaFrame
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.Frames.BufferMediaFrame BufferMediaFrame { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameReference.BufferMediaFrame

## -description
Gets the [BufferMediaFrame](buffermediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md), if that is the type of frame represented.

## -property-value
The [BufferMediaFrame](buffermediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md).

## -remarks
If the frame reference wraps a different type of frame, such as a [VideoMediaFrame](videomediaframe.md), the object returned by this property is null.

## -examples

## -see-also
