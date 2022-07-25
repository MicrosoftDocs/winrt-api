---
-api-id: E:Windows.UI.Xaml.Media.ImageBrush.ImageFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.ExceptionRoutedEventHandler ImageFailed
-->

# Windows.UI.Xaml.Media.ImageBrush.ImageFailed

## -description
Occurs when there is an error associated with image retrieval or format.



## -xaml-syntax
```xaml
<ImageBrush ImageFailed="eventhandler"/>
```


## -remarks
If this event fires, that means that the [ImageSource](imagebrush_imagesource.md) value has been asynchronously determined to not be available, or is not suitable for use. Conditions in which this event can occur include:


+ File not found
+ Invalid (unrecognized or unsupported) file format
+ Unknown file format decoding error after upload
An [ImageBrush](imagebrush.md) in this situation won't display anything. There is no default "missing image" placeholder image for app images as there might be when a browser can't resolve an image URI. If you want behavior like that you'll have to implement it.

ImageFailed and [ImageOpened](imagebrush_imageopened.md) are mutually exclusive. One event or the other will always file whenever an [ImageBrush](imagebrush.md) has the [ImageSource](imagebrush_imagesource.md) value set or reset.

## -examples

## -see-also
