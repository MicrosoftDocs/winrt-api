---
-api-id: M:Windows.UI.Xaml.Media.TimelineMarkerCollection.RemoveAt(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void RemoveAt(System.UInt32 index)
-->

# Windows.UI.Xaml.Media.TimelineMarkerCollection.RemoveAt

## -description
Removes the item at the specified index.


## -parameters
### -param index
The index position of the item to remove.

## -remarks
### Collection API for **TimelineMarkerCollection**

A [TimelineMarkerCollection](timelinemarkercollection.md) is an ordered list where the order is determined by the [Time](timelinemarker_time.md) value of each [TimelineMarker](timelinemarker.md) item contained in the collection. The collection API for [TimelineMarkerCollection](timelinemarkercollection.md) internally processes each new item that is added to the collection and adds it at an index location that corresponds to an updated ordering of all [Time](timelinemarker_time.md) values for all [TimelineMarker](timelinemarker.md) items in the collection.

**RemoveAt** will remove the specified indexed item, but won't remove possible duplicate items when the collection index shifts for the remaining [Time](timelinemarker_time.md) values. We recommend you don't use **RemoveAt**.

## -examples

## -see-also
