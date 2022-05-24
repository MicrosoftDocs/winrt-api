---
-api-id: M:Windows.UI.Xaml.Media.TimelineMarkerCollection.SetAt(System.UInt32,Windows.UI.Xaml.Media.TimelineMarker)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.Media.TimelineMarker value)
-->

# Windows.UI.Xaml.Media.TimelineMarkerCollection.SetAt

## -description
Sets the value at the specified index to the [TimelineMarker](timelinemarker.md) value specified.


## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
### Collection API for **TimelineMarkerCollection**

A [TimelineMarkerCollection](timelinemarkercollection.md) is an ordered list where the order is determined by the [Time](timelinemarker_time.md) value of each [TimelineMarker](timelinemarker.md) item contained in the collection. The collection API for [TimelineMarkerCollection](timelinemarkercollection.md) internally processes each new item that is added to the collection and adds it at an index location that corresponds to an updated ordering of all [Time](timelinemarker_time.md) values for all [TimelineMarker](timelinemarker.md) items in the collection.

We recommend you don't use SetAt to set (change) values because the integer index position is controlled by the internal logic. Instead, iterate the collection and delete items with specific [Time](timelinemarker_time.md) values or that match a complete [TimelineMarker](timelinemarker.md) set of values.

## -examples

## -see-also
