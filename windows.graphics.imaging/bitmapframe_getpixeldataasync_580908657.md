---
-api-id: M:Windows.Graphics.Imaging.BitmapFrame.GetPixelDataAsync(Windows.Graphics.Imaging.BitmapPixelFormat,Windows.Graphics.Imaging.BitmapAlphaMode,Windows.Graphics.Imaging.BitmapTransform,Windows.Graphics.Imaging.ExifOrientationMode,Windows.Graphics.Imaging.ColorManagementMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.PixelDataProvider> GetPixelDataAsync(Windows.Graphics.Imaging.BitmapPixelFormat pixelFormat, Windows.Graphics.Imaging.BitmapAlphaMode alphaMode, Windows.Graphics.Imaging.BitmapTransform transform, Windows.Graphics.Imaging.ExifOrientationMode exifOrientationMode, Windows.Graphics.Imaging.ColorManagementMode colorManagementMode)
-->

# Windows.Graphics.Imaging.BitmapFrame.GetPixelDataAsync

## -description
Asynchronously requests the pixel data for the frame using the specified parameters.

## -parameters
### -param pixelFormat
The specified pixel format.

### -param alphaMode
The specified alpha mode.

### -param transform
The set of transformations to be applied to the frame.

### -param exifOrientationMode
Indicates whether the EXIF orientation flag should be ignored or respected.

### -param colorManagementMode
Indicates whether the pixel data should be color managed to the sRGB color space.

## -returns
Object that manages the asynchronous retrieval of the pixel data.

## -remarks
This method should be used instead of [GetPixelDataAsync](bitmapframe_getpixeldataasync_1391309547.md) if the application needs finer grained control over the pixel data array.

If you set the *exifOrientationMode* parameter to **RespectExifOrientation**, the resulting pixel data will have dimensions that are defined by [OrientedPixelWidth](bitmapframe_orientedpixelwidth.md) and [OrientedPixelHeight](bitmapframe_orientedpixelheight.md) instead of the [PixelWidth](bitmapframe_pixelwidth.md) and [PixelHeight](bitmapframe_pixelheight.md). If you are also applying a transformation, refer to [BitmapTransform](bitmaptransform.md) for information about correctly handling coordinate spaces.

## -examples

## -see-also
[Imaging](/windows/uwp/audio-video-camera/imaging), [Imaging](/windows/uwp/audio-video-camera/imaging), [GetPixelDataAsync](bitmapframe_getpixeldataasync_1391309547.md)
