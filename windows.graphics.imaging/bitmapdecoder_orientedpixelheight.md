---
-api-id: P:Windows.Graphics.Imaging.BitmapDecoder.OrientedPixelHeight
-api-type: winrt property
---

<!-- Property syntax
public uint OrientedPixelHeight { get; }
-->

# Windows.Graphics.Imaging.BitmapDecoder.OrientedPixelHeight

## -description
The height of the first frame in pixels, after any EXIF orientation has been applied to the bitmap.

## -property-value
The height of the first frame in pixels, after any EXIF orientation has been applied.

## -remarks
Use this property if you need to know the height of an image or of pixel data that has EXIF orientation applied, for example, if you call [GetPixelDataAsync](bitmapdecoder_getpixeldataasync.md) and specify **RespectExifOrientation**. Also, the [HTML img element](https://msdn.microsoft.com/library/windows/apps/hh466114.aspx) in Windows app using JavaScript, and [Windows.UI.Xaml.Controls.Image](../windows.ui.xaml.controls/image.md) respect EXIF orientation.

If you need pixel dimensions of the image as it is natively stored, use the [PixelHeight](bitmapdecoder_pixelheight.md) property.

## -examples

## -see-also
