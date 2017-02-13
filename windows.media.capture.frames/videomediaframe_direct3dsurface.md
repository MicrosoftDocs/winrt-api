---
-api-id: P:Windows.Media.Capture.Frames.VideoMediaFrame.Direct3DSurface
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface Direct3DSurface { get; }
-->

# Windows.Media.Capture.Frames.VideoMediaFrame.Direct3DSurface

## -description
Gets an [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) object containing the image data for the [VideoMediaFrame](videomediaframe.md).

## -property-value
An [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) object containing the image data for the [VideoMediaFrame](videomediaframe.md).

## -remarks
If you initialize a [MediaCapture](../windows.media.capture/mediacapture.md) object to use CPU memory for captured frames by setting the [MemoryPreference](../windows.media.capture/mediacaptureinitializationsettings_memorypreference.md) property of the [MediaCaptureInitializationSettings](../windows.media.capture/mediacaptureinitializationsettings.md) to [Cpu](../windows.media.capture/mediacapturememorypreference.md), the Direct3DSurface property of a received [VideoMediaFrame](videomediaframe.md) will be null and the [SoftwareBitmap](videomediaframe_softwarebitmap.md) property will be non-null and contain the image data from the frame. Setting the memory preference to [Auto](../windows.media.capture/mediacapturememorypreference.md) allows the system to choose the optimal memory location for the current device. If the system chooses to use GPU memory, the [SoftwareBitmap](videomediaframe_softwarebitmap.md) property will be null and the **Direct3DSurface** property will contain the frame's image data..

## -examples

## -see-also
