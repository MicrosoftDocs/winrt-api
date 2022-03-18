---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameReference
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameReference : Windows.Foundation.IClosable, Windows.Media.Capture.Frames.IMediaFrameReference
-->

# Windows.Media.Capture.Frames.MediaFrameReference

## -description
A wrapper class that represents a frame obtained from a [MediaFrameSource](mediaframesource.md). Use the properties of this class to access the specific frame type provided by the source, such as a [VideoMediaFrame](videomediaframe.md) or [BufferMediaFrame](buffermediaframe.md).

## -remarks
To get an instance of MediaFrameReference from a media frame source, create a [MediaFrameReader](mediaframereader.md) by calling [CreateFrameReaderAsync](../windows.media.capture/mediacapture_createframereaderasync_1014922223.md) on a [MediaCapture](/windows/uwp/audio-video-camera/capture-photos-and-video-with-mediacapture) object that has been initialized to use the desired media frame source. After the frame reader has been started by calling [StartAsync](mediaframereader_startasync_1931900819.md), call [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md) to get a MediaFrameReference representing the latest frame from the media frame source.

Each [MediaFrameReader](mediaframereader.md) maintains a circular buffer of **MediaFrameReference** objects obtained from [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md). After all of the **MediaFrameReference** objects in the buffer have been used, subsequent calls to **TryAcquireLatestFrame** will cause the system to call [Close](mediaframereference_close_811482585.md) (or **Dispose** in C#) on the oldest buffer object in order to reuse it. Once the object has been disposed, you can no longer use it to access the frame data. For this reason, you should not store the **MediaFrameReference** object longer than you actually need to process the frame. If your app scenario requires you to keep a reference to the data for longer, you should use one of the APIs provided to get the underlying data. These include:

+ [VideoMediaFrame.SoftwareBitmap](videomediaframe_softwarebitmap.md)
+ [VideoMediaFrame.Direct3DSurface](videomediaframe_direct3dsurface.md)

It is the responsibility of the app to call [Close](mediaframereference_close_811482585.md) (or **Dispose**) on the objects returned by these APIs when they are no longer being used.

> [!IMPORTANT]
> If you access the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [Direct3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) objects provided by the [VideoMediaFrame](mediaframereference_videomediaframe.md) property of a MediaFrameReference, the system creates a strong reference to these objects, which means that they will not be disposed when you call [Dispose](mediaframereference_close_811482585.md) on the containing **MediaFrameReference**. This also applies to the **SoftwareBitmap** or **Direct3DSurface** objects provided by the **VideoFrame** object that you obtain from the [MediaFrameReference.VideoMediaFrame](mediaframereference_videomediaframe.md) property. You must explicitly call the **Dispose** method of the **SoftwareBitmap** or **Direct3DSurface** directly for the objects to be immediately disposed. Otherwise, the garbage collector will eventually free the memory for these objects, but you can't know when this will occur, and if the number of allocated bitmaps or surfaces exceeds the maximum amount allowed by the system, the flow of new frames will stop.

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | AudioMediaFrame |

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
