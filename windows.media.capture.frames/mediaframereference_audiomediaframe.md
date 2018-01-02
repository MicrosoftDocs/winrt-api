---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameReference.AudioMediaFrame
-api-type: winrt property
---

<!-- Property syntax.
public AudioMediaFrame AudioMediaFrame { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameReference.AudioMediaFrame

## -description
Gets the [AudioMediaFrame](audiomediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md), if that is the type of frame represented.

## -property-value
The [AudioMediaFrame](audiomediaframe.md) wrapped by the [MediaFrameReference](mediaframereference.md).

## -remarks
If the frame reference wraps a different type of frame, or if the audio frame data is in a format that is unsupported, then this property is null. In this case, you can access the [BufferMediaFrame](mediaframereference_buffermediaframe.md) property, which is always non-null.

## -see-also

## -examples

