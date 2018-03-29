---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameReader.TryAcquireLatestFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Capture.Frames.MediaFrameReference TryAcquireLatestFrame()
-->

# Windows.Media.Capture.Frames.MediaFrameReader.TryAcquireLatestFrame

## -description
Attempts to obtain a [MediaFrameReference](mediaframereference.md) object representing the latest frame from the [MediaFrameSource](mediaframesource.md).

## -returns
A [MediaFrameReference](mediaframereference.md) representing the latest frame from the media frame source.

## -remarks
This method does not always succeed. If the method fails, the returned **MediaFrameReference** will be null, so you should always test to see if the returned object is null before trying to use it. You should call this method from within the handler for the [MediaFrameReader.FrameArrived](mediaframereader_framearrived.md) event instead of manually polling for new frames.

Each [MediaFrameReader](mediaframereader.md) maintains a circular buffer of [MediaFrameReference](mediaframereference.md) objects obtained from **TryAcquireLatestFrame**. After all of the **MediaFrameReference** objects in the buffer have been used, subsequent calls to **TryAcquireLatestFrame** will cause the system to call [Close](mediaframereference_close.md) (or **Dispose** in C#) on the oldest buffer object in order to reuse it. Once the object has been disposed, you can no longer use it to access the frame data. For this reason, you should not store the **MediaFrameReference** object longer than you actually need to process the frame. If your app scenario requires you to keep a reference to the data for longer, you should use one of the APIs provided to get the underlying data. These include:


+ [VideoMediaFrame.SoftwareBitmap](videomediaframe_softwarebitmap.md)
+ [VideoMediaFrame.Direct3DSurface](videomediaframe_direct3dsurface.md)

It is the responsibility of the app to call [Close](mediaframereference_close.md) (or **Dispose**) on the objects returned by these APIs when they are no longer being used.

> [!IMPORTANT]
> If you access the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [Direct3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) objects provided by the [VideoMediaFrame](mediaframereference_videomediaframe.md) property of a [MediaFrameReference](mediaframereference.md), the system creates a strong reference to these objects, which means that they will not be disposed when you call [Dispose](mediaframereference_close.md) on the containing **MediaFrameReference**. This also applies to the **SoftwareBitmap** or **Direct3DSurface** objects provided by the **VideoFrame** object that you obtain from the [MediaFrameReference.VideoMediaFrame](mediaframereference_videomediaframe.md) property. You must explicitly call the **Dispose** method of the **SoftwareBitmap** or **Direct3DSurface** directly for the objects to be immediately disposed. Otherwise, the garbage collector will eventually free the memory for these objects, but you can't know when this will occur, and if the number of allocated bitmaps or surfaces exceeds the maximum amount allowed by the system, the flow of new frames will stop.

## -examples

## -see-also
