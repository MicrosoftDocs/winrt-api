---
-api-id: P:Windows.Media.Capture.Frames.VideoMediaFrame.SoftwareBitmap
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Imaging.SoftwareBitmap SoftwareBitmap { get; }
-->

# Windows.Media.Capture.Frames.VideoMediaFrame.SoftwareBitmap

## -description
Gets a [SoftwareBitmap](videomediaframe_softwarebitmap.md) object containing the image data for the [VideoMediaFrame](videomediaframe.md).

## -property-value
A [SoftwareBitmap](videomediaframe_softwarebitmap.md) object containing the image data for the [VideoMediaFrame](videomediaframe.md).

## -remarks
Initialize a [MediaCapture](../windows.media.capture/mediacapture.md) object to use CPU memory for captured frames by setting the [MemoryPreference](../windows.media.capture/mediacaptureinitializationsettings_memorypreference.md) property of the [MediaCaptureInitializationSettings](../windows.media.capture/mediacaptureinitializationsettings.md) to [Cpu](../windows.media.capture/mediacapturememorypreference.md). Doing this guarantees that the **SoftwareBitmap** property of a received [VideoMediaFrame](videomediaframe.md) will be non-null and contain the image data from the frame. Setting the memory preference to [Auto](../windows.media.capture/mediacapturememorypreference.md) allows the system to choose the optimal memory location for the current device. If the system chooses to use GPU memory, the **SoftwareBitmap** property will be null and the [Direct3DSurface](videomediaframe_direct3dsurface.md) property should be used instead.

## -examples

## -see-also
