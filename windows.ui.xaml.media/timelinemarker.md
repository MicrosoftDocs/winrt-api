---
-api-id: T:Windows.UI.Xaml.Media.TimelineMarker
-api-type: winrt class
---

<!-- Class syntax.
public class TimelineMarker : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.ITimelineMarker
-->

# Windows.UI.Xaml.Media.TimelineMarker

## -description
Represents metadata associated with a specific point in a media file.


## -remarks
A timeline marker is metadata associated with a particular point in a media file. These markers are usually created ahead of time and stored in the media file itself. They are typically used to name different scenes in a video or provide scripting cues. By handling the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) object's [MarkerReached](../windows.ui.xaml.controls/mediaelement_markerreached.md) event or by accessing the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) object's [Markers](../windows.ui.xaml.controls/mediaelement_markers.md) property, you can use timeline markers to trigger actions or enable users to seek to selected positions in the media file.

## -examples
The following example creates a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) object and responds to its [MarkerReached](../windows.ui.xaml.controls/mediaelement_markerreached.md) event. Each time a timeline marker is reached, the example displays the timeline marker's [Time](timelinemarker_time.md), [Type](timelinemarker_type.md), and [Text](timelinemarker_text.md) values.



[!code-xaml[TimelineMarkerXAML](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml#SnippetTimelineMarkerXAML)]

[!code-csharp[TimelineMarker](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetTimelineMarker)]

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md)
