---
-api-id: E:Windows.UI.Xaml.Media.ImageBrush.ImageOpened
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler ImageOpened
-->

# Windows.UI.Xaml.Media.ImageBrush.ImageOpened

## -description
Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the size of an image before rendering it.



## -xaml-syntax
```xaml
<ImageBrush ImageOpened="eventhandler"/>
```


## -remarks
For the scenario of checking the size of an image before rendering, that info isn't part of the ImageOpened event data. Instead, the fact that the event fired is the notification that the [PixelHeight](../windows.ui.xaml.media.imaging/bitmapsource_pixelheight.md) and [PixelWidth](../windows.ui.xaml.media.imaging/bitmapsource_pixelwidth.md) values of the image source ([ImageSource](imagebrush_imagesource.md) value) are available.

## -examples

## -see-also
