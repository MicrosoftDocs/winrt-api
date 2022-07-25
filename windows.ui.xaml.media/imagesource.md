---
-api-id: T:Windows.UI.Xaml.Media.ImageSource
-api-type: winrt class
---

<!-- Class syntax.
public class ImageSource : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IImageSource
-->

# Windows.UI.Xaml.Media.ImageSource

## -description
Provides an object source type for the [Image.Source](../windows.ui.xaml.controls/image_source.md) and [ImageBrush.ImageSource](imagebrush_imagesource.md) properties.



## -remarks
> [!IMPORTANT]
> You don't typically use or create an [ImageSource](imagebrush_imagesource.md) type directly, that's why you don't see code examples on this page. It's more common to create a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) and use that as a value. For code examples and more info, see the reference page for [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md).

ImageSource and [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) are intermediate base classes for [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md). For more info on how to create an image source to use for [Image.Source](../windows.ui.xaml.controls/image_source.md) and [ImageBrush.ImageSource](imagebrush_imagesource.md), see [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes) and [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md).

The [ImageSource](imagebrush_imagesource.md) type is also the value to use for the [MediaElement.PosterSource](../windows.ui.xaml.controls/mediaelement_postersource.md) property.

### **ImageSource** derived classes

ImageSource is the parent class for [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) and [RenderTargetBitmap](../windows.ui.xaml.media.imaging/rendertargetbitmap.md).

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md), [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md), [Image.Source](../windows.ui.xaml.controls/image_source.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
