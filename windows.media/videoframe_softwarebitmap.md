---
-api-id: P:Windows.Media.VideoFrame.SoftwareBitmap
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Imaging.SoftwareBitmap SoftwareBitmap { get; }
-->

# Windows.Media.VideoFrame.SoftwareBitmap

## -description
Gets the SoftwareBitmap object containing the pixel data of the video frame, when one is present.

## -property-value
The SoftwareBitmap object containing the pixel data of the video frame.

## -remarks
The pixel data of a [VideoFrame](videoframe.md) can be stored either in a [Direct3DSurface](videoframe_direct3dsurface.md) or a SoftwareBitmap. This property will be null if the data for the frame is not stored in a SoftwareBitmap. If the data is stored in a Direct3D surface, you can access it using the [Direct3DSurface](videoframe_direct3dsurface.md) property of the [VideoFrame](videoframe.md).

## -examples

## -see-also
