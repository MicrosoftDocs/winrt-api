---
-api-id: T:Windows.Media.Capture.Frames.BufferMediaFrame
-api-type: winrt class
---

<!-- Class syntax.
public class BufferMediaFrame : Windows.Media.Capture.Frames.IBufferMediaFrame
-->

# Windows.Media.Capture.Frames.BufferMediaFrame

## -description
Represents a frame from a [MediaFrameSource](mediaframesource.md) that provides data in an [IBuffer](../windows.storage.streams/ibuffer.md).

## -remarks
Get an instance of this class by accessing the BufferMediaFrame property of a [MediaFrameReference](mediaframereference.md) object that was obtained from a media frame source. The **BufferMediaFrame** property of a **MediaFrameReference** will always be non-null. This is not true for other frame types, such as [VideoMediaFrame](videomediaframe.md), which will be null if the buffer doesn't contain 2D image data or contains data in an unknown format.

A **BufferMediaFrame** represents the 1D buffer. If the underlying sample returned by the pipeline contains non-consecutive data, the system uses [IMFMediaBuffer.Lock](/windows/desktop/api/mfobjects/nf-mfobjects-imfmediabuffer-lock) to copy the 2D buffer into the 1D buffer. For this reason, it is recommended that you use BufferMediaFrame for arbitrary buffers, such as skeleton or body tracking data, but that you use [VideoMediaFrame](videomediaframe.md) for 2D buffers to avoid extra copy operations.



For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
