---
-api-id: T:Windows.Media.Capture.Frames.VideoMediaFrame
-api-type: winrt class
---

<!-- Class syntax.
public class VideoMediaFrame : Windows.Media.Capture.Frames.IVideoMediaFrame
-->

# Windows.Media.Capture.Frames.VideoMediaFrame

## -description
Represents a frame from a [MediaFrameSource](mediaframesource.md) that provides data in a video frame represented by a [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) or [SoftwareBitmap](videomediaframe_softwarebitmap.md).

## -remarks
Get an instance of this class by accessing the [VideoMediaFrame](mediaframereference_videomediaframe.md) property of a [MediaFrameReference](mediaframereference.md) object that was obtained from a media frame source.



> [!IMPORTANT]
> If you access the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [Direct3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) objects provided by the [VideoMediaFrame](mediaframereference_videomediaframe.md) property of a [MediaFrameReference](mediaframereference.md), the system creates a strong reference to these objects, which means that they will not be disposed when you call [Dispose](mediaframereference_close_811482585.md) on the containing **MediaFrameReference**. You must explicitly call the **Dispose** method of the **SoftwareBitmap** or **Direct3DSurface** directly for the objects to be immediately disposed. Otherwise, the garbage collector will eventually free the memory for these objects, but you can't know when this will occur, and if the number of allocated bitmaps or surfaces exceeds the maximum amount allowed by the system, the flow of new frames will stop. In that same line of thought, if you have called (GetVideoFrame())[videomediaframe_getvideoframe_824740069.md], then the (VideoFrame)[../windows.media/videoframe.md] retrieved has a reference on the **SoftwareBitmap** or **Direct3DSurface** objects provided by the VideoMediaFrame and needs to be disposed of by calling manually its **Dispose** method to avoid blocking the fow of frames. If you intend to hold on to a VideoFrame retrieved via (GetVideoFrame())[videomediaframe_getvideoframe_824740069.md] for an extended period of time, it may be better to hold on to a copy of it instead.

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
