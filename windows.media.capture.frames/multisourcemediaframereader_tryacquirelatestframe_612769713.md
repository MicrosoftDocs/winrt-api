---
-api-id: M:Windows.Media.Capture.Frames.MultiSourceMediaFrameReader.TryAcquireLatestFrame
-api-type: winrt method
---

<!-- Method syntax.
public MultiSourceMediaFrameReference MultiSourceMediaFrameReader.TryAcquireLatestFrame()
-->

# Windows.Media.Capture.Frames.MultiSourceMediaFrameReader.TryAcquireLatestFrame

## -description
Attempts to obtain a [MultiSourceMediaFrameReference](multisourcemediaframereference.md) object which provides access to the latest time-correlated frames from one or more [MediaFrameSource](mediaframesource.md) objects.

## -returns
A [MultiSourceMediaFrameReference](multisourcemediaframereference.md) providing access to the latest frames from the media frame sources.

## -remarks
After getting an instance of [MultiSourceMediaFrameReference](multisourcemediaframereference.md), get the time-correlated media frame from a particular media frame source by calling [MultiSourceMediaFrameReference.TryGetFrameReferenceBySourceId](./multisourcemediaframereference_trygetframereferencebysourceid_1428642806.md) and passing in the value of the [MediaFrameSourceInfo.Id](./mediaframesourceinfo_id.md) property for the desired media frame source.


Each [MultiSourceMediaFrameReader](multisourcemediaframereader.md) maintains a circular buffer of [MediaFrameReference](mediaframereference.md) objects obtained from **TryAcquireLatestFrame**. After all of the **MediaFrameReference** objects in the buffer have been used, subsequent calls to **TryAcquireLatestFrame** will cause the system to call [Close](mediaframereference_close_811482585.md) (or **Dispose** in C#) on the oldest buffer object in order to reuse it. Once the object has been disposed, you can no longer use it to access the frame data. For this reason, you should not store the **MediaFrameReference** object longer than you actually need to process the frame. If your app scenario requires you to keep a reference to the data for longer, you should use one of the APIs provided to get the underlying data. These methods include:


+ [BufferMediaFrame.Buffer](buffermediaframe_buffer.md)
+ [VideoMediaFrame.SoftwareBitmap](videomediaframe_softwarebitmap.md)
+ [VideoMediaFrame.GetVideoFrame](videomediaframe_getvideoframe_824740069.md)
+ [VideoMediaFrame.CameraIntrinsics](videomediaframe_cameraintrinsics.md)
It is the responsibility of the app to call [Close](mediaframereference_close_811482585.md) (or **Dispose**) on the objects returned by these APIs when they are no longer being used.

> [!IMPORTANT]
> If you access the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [Direct3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) objects provided by the [VideoMediaFrame](mediaframereference_videomediaframe.md) property of a [MediaFrameReference](mediaframereference.md), the system creates a strong reference to these objects, which means that they will not be disposed when you call [Dispose](mediaframereference_close_811482585.md) on the containing **MediaFrameReference**. You must explicitly call the **Dispose** method of the **SoftwareBitmap** or **Direct3DSurface** directly for the objects to be immediately disposed. Otherwise, the garbage collector will eventually free the memory for these objects, but you can't know when this will occur, and if the number of allocated bitmaps or surfaces exceeds the maximum amount allowed by the system, the flow of new frames will stop.

## -examples

## -see-also
[MediaFrameReader](mediaframereader.md)

