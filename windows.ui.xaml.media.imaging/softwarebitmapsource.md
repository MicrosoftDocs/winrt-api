---
-api-id: T:Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource
-api-type: winrt class
---

<!-- Class syntax.
public class SoftwareBitmapSource : Windows.UI.Xaml.Media.ImageSource, Windows.Foundation.IClosable, Windows.UI.Xaml.Media.Imaging.ISoftwareBitmapSource
-->

# Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource

## -description
Provides a source object, backed by a [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md), for properties that use a bitmap-format image source.

## -remarks
[SoftwareBitmapSource](softwarebitmapsource.md) lets you to use a [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) as an image source to be displayed using an [ImageBrush](../windows.ui.xaml.media/imagebrush.md) or directly in an [Image](../windows.ui.xaml.controls/image.md) control. For example, you can use a [SoftwareBitmapSource](softwarebitmapsource.md) to display a photo just taken by a device's camera using the [LowLagPhotoCapture](../windows.media.capture/lowlagphotocapture.md) class, to display an image you have manually decoded using the [BitmapDecoder.GetSoftwareBitmapAsync](../windows.graphics.imaging/bitmapdecoder_getsoftwarebitmapasync.md) method, or to display a custom [IWICBitmap](http://msdn.microsoft.com/library/15dcc80d-ef58-453d-a57a-348ffc7ddc6b) in advanced C++ scenarios where you want to manually manage image memory.

A [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) displayed in a XAML app must be in BGRA pixel format with pre-multiplied alpha values.

A [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) typically stores uncompressed image data. This means it can require a large amount of system memory compared to a compressed format like a Portable Network Graphics (PNG) or JPEG file. Therefore, using a [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) can increase the amount of system memory your app is using, which could impact your app’s performance. Because storing uncompressed image data can use a lot of memory, you can call the [Dispose](softwarebitmapsource_dispose.md) (C#/VB) or [Close](softwarebitmapsource_close.md) (C++) method to reduce memory usage when the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) is longer needed. This causes the associated system resources to be freed immediately rather than waiting for garbage collection.

## -examples

## -see-also
[ImageSource](../windows.ui.xaml.media/imagesource.md), [IClosable](../windows.foundation/iclosable.md)