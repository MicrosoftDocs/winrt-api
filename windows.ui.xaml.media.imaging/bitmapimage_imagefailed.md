---
-api-id: E:Windows.UI.Xaml.Media.Imaging.BitmapImage.ImageFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.ExceptionRoutedEventHandler ImageFailed
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.ImageFailed

## -description
Occurs when there is an error associated with image retrieval or format.



## -xaml-syntax
```xaml
<BitmapImage ImageFailed="eventhandler"/>
```


## -remarks
One scenario for handling ImageFailed is to set the [UriSource](bitmapimage_urisource.md) to a different local image file that can serve as a fallback value. For example, if you are trying to display an external image where it's possible that the source is no longer there, or for when the user has no Internet connection, you could set the [UriSource](bitmapimage_urisource.md) to reference a local fallback or placeholder image that's part of your app package and is always guaranteed to be available.



```csharp
private void BitmapImage_ImageFailed(object sender, ExceptionRoutedEventArgs e) {
    BitmapImage bitmapImage = sender as BitmapImage;
    bitmapImage.UriSource = new Uri("ms-appx:///Images/fallback.png");
}
```



## -examples

## -see-also
[ImageOpened](bitmapimage_imageopened.md), [Image.ImageFailed](../windows.ui.xaml.controls/image_imagefailed.md), [ImageBrush.ImageFailed](../windows.ui.xaml.media/imagebrush_imagefailed.md), [Image control](../windows.ui.xaml.controls/image.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
