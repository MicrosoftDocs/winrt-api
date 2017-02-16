---
-api-id: P:Windows.Media.VideoFrame.Direct3DSurface
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface Direct3DSurface { get; }
-->

# Windows.Media.VideoFrame.Direct3DSurface

## -description
Gets the [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) object containing the pixel data of the video frame, when one is present.

## -property-value
The [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) object containing the pixel data of the video frame.

## -remarks
The pixel data of a [VideoFrame](videoframe.md) can be stored either in a [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) or a [SoftwareBitmap](videoframe_softwarebitmap.md). This property will be null if the data for the frame is not stored in a [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md). If the data is stored in a software bitmap, you can access it using the [SoftwareBitmap](videoframe_softwarebitmap.md) property of the [VideoFrame](videoframe.md).

## -examples

## -see-also
