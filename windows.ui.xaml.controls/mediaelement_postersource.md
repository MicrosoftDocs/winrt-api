---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.PosterSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.ImageSource PosterSource { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.PosterSource

## -description
Gets or sets the image source that is used for a placeholder image during [MediaElement](mediaelement.md) loading transition states.


## -xaml-syntax
```xaml
<MediaElement PosterSource="imageUri" />
```


## -property-value
An image source for a transition [ImageBrush](../windows.ui.xaml.media/imagebrush.md) that is applied to the [MediaElement](mediaelement.md) content area.

## -remarks
A PosterSource is an image, such as a album cover or movie poster, that is displayed in place of video. It provides your [MediaElement](mediaelement.md) with a visual representation before the media is loaded, or when the media is audio only.


The PosterSource is displayed in the following situations:

+ When a valid source is not set. For example, [Source](mediaelement_source.md) is not set, [Source](mediaelement_source.md) is set to **Null**, or the source is invalid (as is the case when a [MediaFailed](mediaelement_mediafailed.md) event fires).
+ While media is loading. For example, a valid source is set, but the [MediaOpened](mediaelement_mediaopened.md) event has not fired yet.
+ While media is streaming to another device.
+ When the media is audio only.


## -examples

## -see-also
