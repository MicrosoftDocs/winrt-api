---
-api-id: E:Windows.Foundation.Collections.IObservableMap`2.MapChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.Collections.MapChangedEventHandler MapChanged<K,  V>
-->

# Windows.Foundation.Collections.IObservableMap<K, V>.MapChanged

## -description
Occurs when the map changes.

## -remarks
The event handler receives an [IMapChangedEventArgs&lt;K&gt;](imapchangedeventargs_1.md) object that contains data that describes the event.

### .NET usage

[IObservableMap&lt;K,V&gt;](iobservablemap_2.md) isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) type (using a [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2) as *T*) as a base class, or implement a **Dictionary** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) for .NET code, the base interfaces (and their members) project as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) and [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) (with [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2)). [MapChanged](iobservablemap_2_mapchanged.md) is the only API that's shared between the projections.

## -examples

## -see-also
[IObservableMap&lt;K, V&gt;](iobservablemap_2.md), [MapChangedEventHandler(K, V)](mapchangedeventhandler_2.md), [IMapChangedEventArgs&lt;K&gt;](imapchangedeventargs_1.md)