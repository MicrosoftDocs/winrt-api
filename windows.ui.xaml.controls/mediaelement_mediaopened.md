---
-api-id: E:Windows.UI.Xaml.Controls.MediaElement.MediaOpened
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler MediaOpened
-->

# Windows.UI.Xaml.Controls.MediaElement.MediaOpened

## -description
Occurs when the media stream has been validated and opened, and the file headers have been read.

## -xaml-syntax
```xaml
<MediaElement MediaOpened="eventhandler" .../>
```


## -remarks
Live media streams report a [NaturalDuration](mediaelement_naturalduration.md) of **Int64.MaxValue**.

Any calls to [Play](mediaelement_play.md), [Pause](mediaelement_pause.md), and [Stop](mediaelement_stop.md) methods that occur before the [MediaOpened](mediaelement_mediaopened.md) event is raised are ignored.

## -examples
The following code shows how to determine if a media stream is a live stream.



[!code-csharp[MediaOpenedLiveStream](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetMediaOpenedLiveStream)]

## -see-also
