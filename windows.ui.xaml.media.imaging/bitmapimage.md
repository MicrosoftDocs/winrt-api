---
-api-id: T:Windows.UI.Xaml.Media.Imaging.BitmapImage
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapImage : Windows.UI.Xaml.Media.Imaging.BitmapSource, Windows.UI.Xaml.Media.Imaging.IBitmapImage, Windows.UI.Xaml.Media.Imaging.IBitmapImage2, Windows.UI.Xaml.Media.Imaging.IBitmapImage3
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage

## -description

Provides the practical object source type for the [Image.Source](../windows.ui.xaml.controls/image_source.md) and [ImageBrush.ImageSource](../windows.ui.xaml.media/imagebrush_imagesource.md) properties. You can define a BitmapImage by using a Uniform Resource Identifier (URI) that references an image source file, or by calling [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md) and supplying a stream.



## -xaml-syntax

```xaml
<BitmapImage .../>
```

## -remarks

A BitmapImage can be sourced from these image file formats:

+ Joint Photographic Experts Group (JPEG)
+ Portable Network Graphics (PNG)
+ bitmap (BMP)
+ Graphics Interchange Format (GIF)
+ Tagged Image File Format (TIFF)
+ JPEG XR
+ icons (ICO)

If the image source is a stream, that stream is expected to contain an image file in one of these formats.

The BitmapImage class represents an abstraction so that an image source can be set asynchronously but still be referenced in XAML markup as a property value, or in code as an object that doesn't use awaitable syntax. When you create a BitmapImage object in code, it initially has no valid source. You should then set its source using one of these techniques:

+ Use the [BitmapImage(Uri)](bitmapimage_bitmapimage_843413386.md) constructor rather than the default constructor. Although it's a constructor you can think of this as having an implicit asynchronous behavior: the BitmapImage won't be ready for use until it raises an [ImageOpened](bitmapimage_imageopened.md) event that indicates a successful async source set operation.
+ Set the [UriSource](bitmapimage_urisource.md) property. As with using the **Uri** constructor, this action is implicitly asynchronous, and the BitmapImage won't be ready for use until it raises an [ImageOpened](bitmapimage_imageopened.md) event.
+ Use [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md). This method is explicitly asynchronous.
 The properties where you might use a BitmapImage, such as [Image.Source](../windows.ui.xaml.controls/image_source.md), are designed for this asynchronous behavior, and won't throw exceptions if they are set using a BitmapImage that doesn't have a complete source yet. Rather than handling exceptions, you should handle [ImageOpened](bitmapimage_imageopened.md) or [ImageFailed](bitmapimage_imagefailed.md) events either on the BitmapImage directly or on the control that uses the source (if those events are available on the control class).

[ImageFailed](bitmapimage_imagefailed.md) and [ImageOpened](bitmapimage_imageopened.md) are mutually exclusive. One event or the other will always be raised whenever a BitmapImage object has its source value set or reset.

### BitmapImage and encoding

The underlying codec support for image files is supplied by Windows Imaging Component (WIC)  API in Windows. For more info on specific image formats as documented for the codecs, see [Native WIC Codecs](/windows/desktop/wic/native-wic-codecs). For more info on formats and how to use Uniform Resource Identifier (URI) to access image source files that come from app resources, see [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes).

The API for [Image](../windows.ui.xaml.controls/image.md), BitmapImage and [BitmapSource](bitmapsource.md) doesn't include any dedicated methods for encoding and decoding of media formats. All of the encode and decode operations are built-in, and at most will surface aspects of encode or decode as part of event data for load events. If you want to do any special work with image encode or decode, which you might use if your app is doing image conversions or manipulation, you should use the API that are available in the [Windows.Graphics.Imaging](../windows.graphics.imaging/windows_graphics_imaging.md) namespace. These imaging API can be used by either UWP app using C++, C#, or Visual Basic or Windows app using JavaScript. These APIs are also supported by the Windows Imaging Component (WIC) component of Windows 8.

### Animated images

Starting in Windows 10, version 1607, the XAML [Image](../windows.ui.xaml.controls/image.md) element supports animated GIF images. When you use a BitmapImage as the image [Source](../windows.ui.xaml.controls/image_source.md), you can access BitmapImage  API to control playback of the animated GIF image.

+ Use the [AutoPlay](bitmapimage_autoplay.md) property, which defaults to **true**, to specify whether or not an animated bitmap plays as soon as it loads.
+ Use the [IsAnimatedBitmap](bitmapimage_isanimatedbitmap.md) property to check whether a bitmap is animated.
+ Use the [IsPlaying](bitmapimage_isplaying.md) property along with the [Play](bitmapimage_play_848564459.md) and [Stop](bitmapimage_stop_1201535524.md) methods to control the playback of an animated bitmap.

> [!NOTE]
> For most apps, we recommend that you set [AutoPlay](bitmapimage_autoplay.md) to **false** if [UISettings.AnimationsEnabled](../windows.ui.viewmanagement/uisettings_animationsenabled.md) is **false**, to support the accessibility needs of users. Do not do this if the content of the animated GIF is important for the usability of your app.

If your app runs on releases of Windows 10 prior to version 1607, you must use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of these members before you use them. For more info, see [Version adaptive code: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-code).

This example shows how to use an animated GIF. A button lets the user start or stop the animation. This example uses version adaptive code so it can run on all versions of Windows 10. On versions prior to version 1607, the first frame of the GIF is shown, but it is not animated.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Image Loaded="Image_Loaded">
        <Image.Source>
            <BitmapImage x:Name="imageSource"
                         UriSource="Assets/example.gif"
                         ImageOpened="imageSource_ImageOpened"/>
        </Image.Source>
    </Image>

    <AppBarButton x:Name="playButton"
              Icon="Play"
              Visibility="Collapsed"
              Click="playButton_Click"/>
</Grid>
```

```csharp
// Set the AutoPlay property.
private void Image_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "AutoPlay") == true)
    {
        imageSource.AutoPlay = false;
    }
}

// Show the play/stop button if the image is animated.
private void imageSource_ImageOpened(object sender, RoutedEventArgs e)
{
    var bitmapImage = (BitmapImage)sender;
    // At this point you can query whether the image is animated or not.
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsAnimatedBitmap") 
        && bitmapImage.IsAnimatedBitmap == true)
    {
        // Enable the play button
        playButton.Visibility = Visibility.Visible;
    }
}

// Play or stop the animated bitmap.
void playButton_Click(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsPlaying"))
    {
        // You can call the Play and Stop methods safely because is the IsPlaying property is
        // present, these methods are also present.
        if (imageSource.IsPlaying == true)
        {
            playButton.Icon = new SymbolIcon(Symbol.Play);
            imageSource.Stop();
        }
        else
        {
            playButton.Icon = new SymbolIcon(Symbol.Stop);
            imageSource.Play();
        }
    }
}
```

For more examples, see the [Animated GIF playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AutoPlay |
| 1607 | 14393 | IsAnimatedBitmap |
| 1607 | 14393 | IsPlaying |
| 1607 | 14393 | Play |
| 1607 | 14393 | Stop |

## -examples

Here's an example of using a BitmapImage object to set [Image.Source](../windows.ui.xaml.controls/image_source.md) in C#. In this example, the [Image](../windows.ui.xaml.controls/image.md) object was created in XAML but doesn't have a source or any other property values; instead these values are provided at run-time when the [Image](../windows.ui.xaml.controls/image.md) is loaded from XAML.

```xaml
<Image Loaded="Image_Loaded"/>
```

```csharp
void Image_Loaded(object sender, RoutedEventArgs e)
{
    Image img = sender as Image; 
    BitmapImage bitmapImage = new BitmapImage();
    img.Width = bitmapImage.DecodePixelWidth = 80; 
    // Natural px width of image source.
    // You don't need to set Height; the system maintains aspect ratio, and calculates the other
    // dimension, as long as one dimension measurement is provided.
    bitmapImage.UriSource = new Uri(img.BaseUri,"Assets/StoreLogo.png");
    img.Source = bitmapImage;
}
```

## -see-also

[Image](../windows.ui.xaml.controls/image.md), [BitmapSource](bitmapsource.md), [Image.Source](../windows.ui.xaml.controls/image_source.md), [ImageBrush.ImageSource](../windows.ui.xaml.media/imagebrush_imagesource.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [Animated GIF playback (XAML) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif)
