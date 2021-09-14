---
-api-id: M:Windows.UI.Xaml.Media.TimelineMarkerCollection.Append(Windows.UI.Xaml.Media.TimelineMarker)
-api-type: winrt method
---

<!-- Method syntax
public void Append(Windows.UI.Xaml.Media.TimelineMarker value)
-->

# Windows.UI.Xaml.Media.TimelineMarkerCollection.Append

## -description
Adds a new item to the collection.


## -parameters
### -param value
The new item to add.

## -remarks
### Collection API for **TimelineMarkerCollection**

A [TimelineMarkerCollection](timelinemarkercollection.md) is an ordered list where the order is determined by the [Time](timelinemarker_time.md) value of each [TimelineMarker](timelinemarker.md) item contained in the collection. The collection API for [TimelineMarkerCollection](timelinemarkercollection.md) internally processes each new item that is added to the collection and adds it at an index location that corresponds to an updated ordering of all [Time](timelinemarker_time.md) values for all [TimelineMarker](timelinemarker.md) items in the collection.

The intention of having the [TimelineMarkerCollection](timelinemarkercollection.md) always maintain a [Time](timelinemarker_time.md)-based order is so that enumerating/iterating the collection gives the [TimelineMarker](timelinemarker.md) values in the order that corresponds to the [Position](../windows.ui.xaml.controls/mediaelement_position.md) of a media asset that's being played and the order that [MarkerReached](../windows.ui.xaml.controls/mediaelement_markerreached.md) events would fire. Otherwise, if the collection weren't [Time](timelinemarker_time.md)-ordered, it would have been necessary to sort the collection by time prior to use.

If you call Append, the item might be added to the beginning, middle or end of the ordered list, depending on the [Time](timelinemarker_time.md) value of the [TimelineMarker](timelinemarker.md) you are adding. This is different from typical **Append** behavior that extends the index and always adds to the last index.

[Time](timelinemarker_time.md) values aren't exclusive in a [TimelineMarkerCollection](timelinemarkercollection.md), more than one [TimelineMarker](timelinemarker.md) with a shared [Time](timelinemarker_time.md) can be in a list and will be in appropriate [Time](timelinemarker_time.md)-based order. However the relative order between items that share a [Time](timelinemarker_time.md) is indeterminate within the collection and should be considered an implementation detail.

## -examples

## -see-also
