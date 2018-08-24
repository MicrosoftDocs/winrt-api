---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.SetSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
---

<!-- Method syntax
public void SetSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap bitmap)
-->

# Windows.Graphics.Imaging.BitmapEncoder.SetSoftwareBitmap

## -description
Sets the image data of the current frame using the specified [SoftwareBitmap](softwarebitmap.md).

## -parameters
### -param bitmap
The software bitmap containing the image data.

## -remarks
[BitmapEncoder](bitmapencoder.md) only supports software bitmaps that have a [BitmapPixelFormat](bitmappixelformat.md) of **Rgba16**, **Rgba8**, or **Bgra8**. Attempting to call **SetSoftwareBitmap** with a software bitmap that has a different pixel format results in a format unsupported error. Use the [SoftwareBitmap.Convert](/uwp/api/windows.graphics.imaging.softwarebitmap.convert) method to create a copy of an existing software bitmap with a different pixel format.

## -examples

## -see-also
