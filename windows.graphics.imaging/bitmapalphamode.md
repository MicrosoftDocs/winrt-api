---
-api-id: T:Windows.Graphics.Imaging.BitmapAlphaMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.BitmapAlphaMode : int
-->

# BitmapAlphaMode

## -description
Specifies the alpha mode of pixel data.

## -enum-fields
### -field Premultiplied:0
The alpha value has been premultiplied. Each color is first scaled by the alpha value.

### -field Straight:1
The alpha value has not been premultiplied. The alpha channel indicates the transparency of the color.

### -field Ignore:2
The alpha value is ignored.


## -remarks
BitmapAlphaMode is used in conjunction with [BitmapPixelFormat](bitmappixelformat.md) to describe the pixel data.

Using the **Ignore** value effectively treats the pixel data as opaque by discarding the alpha channel data. For example, pixel data returned by a decoder with an alpha mode of **Ignore** and a pixel format of **Rgba8** will have alpha channel values of 0.

## -examples

## -see-also
[BitmapPixelFormat](bitmappixelformat.md)
