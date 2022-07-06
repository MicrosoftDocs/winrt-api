---
-api-id: E:Windows.UI.Xaml.Media.Imaging.BitmapImage.ImageOpened
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler ImageOpened
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.ImageOpened

## -description
Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the size of an image before rendering it.



## -xaml-syntax
```xaml
<BitmapImage ImageOpened="eventhandler"/>
```


## -remarks
When ImageOpened fires, that serves as the notification that any asynchronous operations have completed and all the properties of a [BitmapImage](bitmapimage.md) are ready for use. For example, to determine the size of the image before rendering it, handle ImageOpened, and check the value of the [PixelWidth](bitmapsource_pixelwidth.md) and [PixelHeight](bitmapsource_pixelheight.md) properties on the [BitmapImage](bitmapimage.md) that fired the event. The event data for the ImageOpened event isn't typically useful.

The [Image](surfaceimagesource.md) class also has an [ImageOpened](../windows.ui.xaml.controls/image_imageopened.md) event (as does [ImageBrush](../windows.ui.xaml.media/imagebrush.md)). For the other **ImageOpened** events, these fire at a time when the image has probably already rendered. The BitmapImage.ImageOpened fires at a time that is potentially before you've assigned your [BitmapImage](bitmapimage.md) to be the source of an [Image](bitmapimage.md) or [ImageBrush](../windows.ui.xaml.media/imagebrush.md). If you want to change properties that affect rendering of the image based on reading properties of the [BitmapImage](bitmapimage.md), it's often best to handle the underlying [BitmapImage](bitmapimage.md)'s event prior to assigning it as a source. 
<!--Otherwise it's possible that rerunning the layout can produce a transition that's visible to the user.-->

## -examples

## -see-also
[ImageFailed](bitmapimage_imagefailed.md), [Image control](../windows.ui.xaml.controls/image.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
