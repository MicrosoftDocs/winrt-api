---
-api-id: P:Windows.Media.Capture.MediaCaptureInitializationSettings.MemoryPreference
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCaptureMemoryPreference MemoryPreference { get;  set; }
-->

# Windows.Media.Capture.MediaCaptureInitializationSettings.MemoryPreference

## -description
Gets or sets an object specifying the preferred memory location for storing frames acquired from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) used by the [MediaCapture](mediacapture.md).

## -property-value
An object specifying preferred the memory location for storing frames acquired from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md).

## -remarks
The [MediaCapture](mediacapture.md) object may store the image data of a [VideoMediaFrame](../windows.media.capture.frames/videomediaframe.md) acquired from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) in either CPU or GPU memory. When **MemoryPreference** is set to [Cpu](mediacapturememorypreference.md), CPU memory is used and therefore the [SoftwareBitmap](../windows.media.capture.frames/videomediaframe_softwarebitmap.md) property of acquired [VideoMediaFrame](../windows.media.capture.frames/videomediaframe.md) objects will be non-null and contain the image data for the frame. When [Auto](mediacapturememorypreference.md) is specified, the system will dynamically choose the optimal memory location for the current device. If the system chooses to use GPU memory, the [Direct3DSurface](../windows.media.capture.frames/videomediaframe_direct3dsurface.md) property of acquired [VideoMediaFrame](../windows.media.capture.frames/videomediaframe.md) objects will be non-null and contain the image data for the frame.

## -examples

## -see-also
