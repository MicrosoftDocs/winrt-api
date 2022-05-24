---
-api-id: M:Windows.Graphics.Imaging.BitmapFrame.GetPixelDataAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.PixelDataProvider> GetPixelDataAsync()
-->

# Windows.Graphics.Imaging.BitmapFrame.GetPixelDataAsync

## -description
Asynchronously requests the pixel data for the frame. The resulting pixel data array will use the bitmap pixel format and alpha mode specified in the [BitmapPixelFormat](bitmapframe_bitmappixelformat.md) and [BitmapAlphaMode](bitmapframe_bitmapalphamode.md) properties. It will also have color management and EXIF orientation applied (see the Remarks section for more information).

## -returns
Object that manages the asynchronous retrieval of the pixel data.

## -remarks
The pixel data array will use the bitmap pixel format and alpha mode specified in the [BitmapPixelFormat](bitmapdecoder_bitmappixelformat.md) and [BitmapAlphaMode](bitmapdecoder_bitmapalphamode.md) properties. It will also have color management and EXIF orientation applied.

As a convenience, this method performs color management from the frame's embedded color space (if it exists) to the sRGB color space. If there is no embedded color profile data, then no color management is performed. This method also attempts to read the EXIF orientation flag on the frame, and if it exists, will perform the necessary transformation to correctly orient the pixel data.

In order to retrieve the correct bitmap pixel width and height, the application should read the [OrientedPixelWidth](bitmapframe_orientedpixelwidth.md) and [OrientedPixelHeight](bitmapframe_orientedpixelheight.md) properties, instead of the [PixelWidth](bitmapframe_pixelwidth.md) and [PixelHeight](bitmapframe_pixelheight.md) properties.

This method is equivalent to calling the [GetPixelDataAsync(BitmapPixelFormat, BitmapAlphaMode, BitmapTransform, ExifOrientationMode, ColorManagementMode)](bitmapframe_getpixeldataasync_580908657.md) method with the following arguments:

| Argument | Value |
|---|---|
| *pixelFormat* | The value of the [BitmapPixelFormat](bitmapframe_bitmappixelformat.md) property. |
| *alphaMode* | The value of the [BitmapAlphaMode](bitmapframe_bitmapalphamode.md) property |
| *transform* | An empty transform. |
| *exifOrientationMode* | The [ExifOrientationMode](exiforientationmode.md) value **RespectExifOrientation**. |
| *colorManagementMode* | The [ColorManagementMode](colormanagementmode.md) value **ColorManageToSRgb**. |

## -examples

## -see-also
[Imaging](/windows/uwp/audio-video-camera/imaging), [Imaging](/windows/uwp/audio-video-camera/imaging), [GetPixelDataAsync(BitmapPixelFormat, BitmapAlphaMode, BitmapTransform, ExifOrientationMode, ColorManagementMode)](bitmapframe_getpixeldataasync_580908657.md), [PixelDataProvider](pixeldataprovider.md)
