---
-api-id: E:Windows.UI.Xaml.Controls.MediaElement.MarkerReached
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Media.TimelineMarkerRoutedEventHandler MarkerReached
-->

# Windows.UI.Xaml.Controls.MediaElement.MarkerReached

## -description
Occurs when a timeline marker is encountered during media playback.


## -xaml-syntax
```xaml
<MediaElement MarkerReached="eventhandler"/>
```


## -remarks

## -examples
The following example creates a [MediaElement](mediaelement.md) object and responds to its MarkerReached event. Each time a timeline marker is reached, the example displays the timeline marker's [Time](../windows.ui.xaml.media/timelinemarker_time.md), [Type](../windows.ui.xaml.media/timelinemarker_type.md), and [Text](../windows.ui.xaml.media/timelinemarker_text.md) values.



[!code-xaml[TimelineMarkerXAML](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml#SnippetTimelineMarkerXAML)]

[!code-csharp[TimelineMarker](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetTimelineMarker)]

## -see-also
