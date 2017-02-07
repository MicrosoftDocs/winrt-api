---
-api-id: T:Windows.Graphics.Imaging.BitmapInterpolationMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.BitmapInterpolationMode : int
-->

# BitmapInterpolationMode

## -description
Specifies the interpolation mode used for scaling pixel data.

## -enum-fields
### -field NearestNeighbor:0
A nearest neighbor interpolation algorithm. Also known as nearest pixel or point interpolation. The output pixel is assigned the value of the pixel that the point falls within. No other pixels are considered.

### -field Linear:1
A bilinear interpolation algorithm. The output pixel values are computed as a weighted average of the nearest four pixels in a 2x2 grid.

### -field Cubic:2
A bicubic interpolation algorithm. Destination pixel values are computed as a weighted average of the nearest sixteen pixels in a 4x4 grid.

### -field Fant:3
A Fant resampling algorithm. Destination pixel values are computed as a weighted average of the all the pixels that map to the new pixel in a box shaped kernel.


## -remarks
This enumeration is used when setting the [InterpolationMode](bitmaptransform_interpolationmode.md) property of a [BitmapTransform](bitmaptransform.md).

In general, moving from **NearestNeighbor** to **Fant**, interpolation quality increases while performance decreases.

## -examples

## -see-also
[BitmapTransform](bitmaptransform.md)