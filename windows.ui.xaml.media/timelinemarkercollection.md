---
-api-id: T:Windows.UI.Xaml.Media.TimelineMarkerCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TimelineMarkerCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.TimelineMarker>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.TimelineMarker>
-->

# Windows.UI.Xaml.Media.TimelineMarkerCollection

## -description
Represents a collection of [TimelineMarker](timelinemarker.md) objects that can be individually accessed by index. A TimelineMarkerCollection is an ordered list where the order is determined by the [Time](timelinemarker_time.md) value of each [TimelineMarker](timelinemarker.md) item contained in the collection. For more info on how this affects the collection API, see Remarks.


## -remarks
### Collection API for **TimelineMarkerCollection**

A TimelineMarkerCollection is an ordered list where the order is determined by the [Time](timelinemarker_time.md) value of each [TimelineMarker](timelinemarker.md) item contained in the collection. The collection API for TimelineMarkerCollection internally processes each new item that is added to the collection and adds it at an index location that corresponds to an updated ordering of all [Time](timelinemarker_time.md) values for all [TimelineMarker](timelinemarker.md) items in the collection.

The intention of having the TimelineMarkerCollection always maintain a [Time](timelinemarker_time.md)-based order is so that enumerating/iterating the collection gives the [TimelineMarker](timelinemarker.md) values in the order that corresponds to the [Position](../windows.ui.xaml.controls/mediaelement_position.md) of a media asset that's being played and the order that [MarkerReached](../windows.ui.xaml.controls/mediaelement_markerreached.md) events would fire. Otherwise, if the collection weren't [Time](timelinemarker_time.md)-ordered, it would have been necessary to sort the collection by time prior to use.

+ If you call [Append](timelinemarkercollection_append_1255071253.md) (for C++), the item might be added to the beginning, middle or end of the ordered list, depending on the [Time](timelinemarker_time.md) value of the [TimelineMarker](timelinemarker.md) you are adding.
+ If you call [InsertAt](timelinemarkercollection_insertat_23480440.md) (for C++) the *index* parameter is ignored. The [TimelineMarker](timelinemarker.md) item is added at an index position that maintains the collection's order by [Time](timelinemarker_time.md) values.
+ If you use the [GetAt](timelinemarkercollection_getat_496709656.md) method (for C++) to read a value, the index is correct, based on how the item was added by the internal logic. But since you didn't directly control that logic, it's usually a better idea to use [IndexOf](timelinemarkercollection_indexof_41603371.md) (for C++) to find a specific [TimelineMarker](timelinemarker.md) in the ordered list.
+ If you use the [SetAt](timelinemarkercollection_setat_1882793992.md) method (for C++) to set a value, you will delete a value that was previously at that index, but the collection will reorder itself to maintain the [Time](timelinemarker_time.md) value ordering, so the new [TimelineMarker](timelinemarker.md) you added might not be at the index you were setting to. This is probably a bad idea, because you won't be sure which item gets deleted. We recommend you don't use the indexer to set values.
+ [RemoveAt](/uwp/api/windows.ui.xaml.media.timelinemarkercollection.removeat) will remove the specified indexed item, but won't remove possible duplicate items when the collection index shifts for the remaining [Time](timelinemarker_time.md) values. We recommend you don't use [RemoveAt](/uwp/api/windows.ui.xaml.media.timelinemarkercollection.removeat).

<!--Begin NET note for IEnumerable support-->

### Enumerating the collection in C# or Microsoft Visual Basic

A TimelineMarkerCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<TimelineMarker>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [TimelineMarker](timelinemarker.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
