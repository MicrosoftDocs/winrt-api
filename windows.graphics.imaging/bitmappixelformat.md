---
-api-id: T:Windows.Graphics.Imaging.BitmapPixelFormat
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.BitmapPixelFormat : int
-->

# BitmapPixelFormat

## -description
Specifies the pixel format of pixel data. Each enumeration value defines a channel ordering, bit depth, and data type.

## -enum-fields
### -field Unknown:0
The pixel format is unknown.

### -field Rgba16:12
The pixel format is R16G16B16A16 unsigned integer.

### -field Rgba8:30
The pixel format is R8G8B8A8 unsigned integer.

### -field Bgra8:87
The pixel format is B8G8R8A8 unsigned integer.

### -field Gray16:57
The pixel format is 16 bpp grayscale.

### -field Gray8:62
The pixel format is 8 bpp grayscale.

### -field Nv12:103
The pixel format is NV12.

### -field Yuy2:107
The pixel format is YUY2.

### -field P010:104
The pixel format is P010.

## -remarks
BitmapPixelFormat is used in conjunction with [BitmapAlphaMode](bitmapalphamode.md) to fully describe the pixel data.

The set of pixel formats represented by BitmapPixelFormat is smaller than the set of native pixel formats that can be supported by the bitmap codecs. For example, certain codecs support 32 bit floating point values. In these cases there will be a loss in fidelity when obtaining pixel data from the bitmap.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | P010 |

## -examples

## -see-also
[BitmapAlphaMode](bitmapalphamode.md)
