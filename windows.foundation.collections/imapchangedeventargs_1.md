---
-api-id: T:Windows.Foundation.Collections.IMapChangedEventArgs`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMapChangedEventArgs<K> : 
-->

# Windows.Foundation.Collections.IMapChangedEventArgs<K>

## -description
Provides data for the changed event of a map collection.

## -remarks
[IMapChangedEventArgs&lt;K&gt;](imapchangedeventargs_1.md) is specifically used for the [MapChanged](iobservablemap_2_mapchanged.md) event of the [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) interface, via the [MapChangedEventHandler&lt;K,V&gt;](mapchangedeventhandler_2.md) delegate. It's also used for [PropertySet.MapChanged](propertyset_mapchanged.md).

.NET developers can get instances of this interface via handling the [PropertySet.MapChanged](propertyset_mapchanged.md) event or the [MapChanged](iobservablemap_2_mapchanged.md) event from an [IObservableMap](iobservablemap_2.md) instance. Even though the remainder of the collection support for [IObservableMap](iobservablemap_2.md) or [PropertySet](propertyset.md) uses language projections that change [IMap&lt;K,V&gt;](imap_2.md) APIs to [IDictionary&lt;TKey,TValue&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) APIs, the **MapChanged** event, its delegates and its event data aren't changed by the projection and so "Map" (as opposed to "Dictionary") remains in the API names.

## -examples

## -see-also
[PropertySet](propertyset.md), [IObservableMap&lt;K,V&gt;](iobservablemap_2.md)