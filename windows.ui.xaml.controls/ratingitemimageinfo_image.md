---
-api-id: P:Windows.UI.Xaml.Controls.RatingItemImageInfo.Image
-api-type: winrt property
---

<!-- Property syntax.
public ImageSource Image { get;  set; }
-->

# Windows.UI.Xaml.Controls.RatingItemImageInfo.Image

## -description

Gets or sets an image that represents a rating element that has been set by the user.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RatingItemImageInfo.Image](/windows/winui/api/microsoft.ui.xaml.controls.ratingitemimageinfo.image) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<RatingItemImageInfo Image="uri"/>
```

## -xaml-values

<dl><dt>uri</dt><dd>uriThe location of the image source file. In XAML syntax, you can specify what appears to be a relative that is relative to a base . The base is interpreted based on the location of the XAML file that loads it, and uses the ms-appx: scheme implicitly. For more info see Image.Source.</dd>
</dl>

## -property-value

An object that represents the image source file for the drawn image. Typically you set this with a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) with a stream, perhaps a stream from a storage file.

## -remarks

## -see-also

## -examples

