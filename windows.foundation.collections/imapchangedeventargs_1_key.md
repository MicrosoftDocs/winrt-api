---
-api-id: P:Windows.Foundation.Collections.IMapChangedEventArgs`1.Key
-api-type: winrt property
---

<!-- Property syntax
public K Key { get; }
-->

# Windows.Foundation.Collections.IMapChangedEventArgs<K>.Key

## -description
Gets the key of the item that changed.

## -property-value
The key of the item that changed.

## -remarks
.NET developers can get instances of this interface via handling the [PropertySet.MapChanged](propertyset_mapchanged.md) event or the [MapChanged](iobservablemap_2_mapchanged.md) event from an [IObservableMap](iobservablemap_2.md) instance. Even though the remainder of the collection support for [IObservableMap](iobservablemap_2.md) or [PropertySet](propertyset.md) uses language projections that change [IMap<K,V>](imap_2.md) APIs to [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) APIs, the **MapChanged** event, its delegates and its event data aren't changed by the projection and so "Map" (as opposed to "Dictionary") remains in the API names.

## -examples

## -see-also
[IMapChangedEventArgs&lt;K&gt;](imapchangedeventargs_1.md)