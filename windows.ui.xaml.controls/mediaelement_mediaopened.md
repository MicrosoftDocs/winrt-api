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

Any calls to [Play](mediaelement_play_848564459.md), [Pause](mediaelement_pause_1953642114.md), and [Stop](mediaelement_stop_1201535524.md) methods that occur before the MediaOpened event is raised are ignored.

## -examples
The following code shows how to determine if a media stream is a live stream.



[!code-csharp[MediaOpenedLiveStream](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetMediaOpenedLiveStream)]

## -see-also
