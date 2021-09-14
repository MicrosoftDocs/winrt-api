---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.Markers
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.TimelineMarkerCollection Markers { get; }
-->

# Windows.UI.Xaml.Controls.MediaElement.Markers

## -description
Gets the collection of timeline markers associated with the currently loaded media file.


## -property-value
The collection of timeline markers (represented as [TimelineMarker](../windows.ui.xaml.media/timelinemarker.md) objects) associated with the currently loaded media file. The default is an empty collection.

## -remarks
A timeline marker is metadata associated with a particular point in a media file. These markers are usually created ahead of time and stored in the media file itself. They are typically used to name different scenes in a video or provide scripting cues. By handling the [MediaElement](mediaelement.md) object's [MarkerReached](mediaelement_markerreached.md) event or by accessing the [MediaElement](mediaelement.md) object's Markers property, you can use timeline markers to trigger actions or enable users to seek to selected positions in the media file.

## -examples
The following example creates a [MediaElement](mediaelement.md) object and responds to its [MarkerReached](mediaelement_markerreached.md) event. Each time a timeline marker is reached, the example displays the timeline marker's [Time](../windows.ui.xaml.media/timelinemarker_time.md), [Type](../windows.ui.xaml.media/timelinemarker_type.md), and [Text](../windows.ui.xaml.media/timelinemarker_text.md) values.



[!code-xaml[TimelineMarkerXAML](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml#SnippetTimelineMarkerXAML)]

[!code-csharp[TimelineMarker](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetTimelineMarker)]

## -see-also
