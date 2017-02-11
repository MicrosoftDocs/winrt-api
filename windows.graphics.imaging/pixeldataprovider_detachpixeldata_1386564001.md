---
-api-id: M:Windows.Graphics.Imaging.PixelDataProvider.DetachPixelData
-api-type: winrt method
---

<!-- Method syntax
public byte[] DetachPixelData()
-->

# Windows.Graphics.Imaging.PixelDataProvider.DetachPixelData

## -description
Returns the internally-stored pixel data.

## -returns
The pixel data.

## -remarks
[PixelDataProvider](pixeldataprovider.md) doesn't retain a copy of the pixel data after a successful call to this method. This means that subsequent calls to the method will fail.

The return value is an array of 8 bit unsigned values. However, depending on the requested pixel format, the pixel data may represent another type. For example, if the pixel format is Rgba16, then each color value is a 16 bit unsigned integer that takes up two 8 bit elements of the array. You must convert the array to the correct type before you use it.

## -examples

## -see-also
