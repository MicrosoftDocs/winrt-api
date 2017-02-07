---
-api-id: T:Windows.Foundation.Collections.IObservableMap`2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IObservableMap<K, V> : Windows.Foundation.Collections.IMap<K, V>
-->

# Windows.Foundation.Collections.IObservableMap<K, V>

## -description
Notifies listeners of dynamic changes to a map, such as when items are added or removed.

## -remarks
The [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) interface enables clients to register for notification events to [IMap&lt;K,V&gt;](imap_2.md) collections. For example, you might use [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) when you need to keep two map structures synchronized. In this case, use the [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) interface to receive notification of changes, so that the associated data structure can be updated.

Observable collections are mainly useful for XAML data binding scenarios. For more info, see [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

### Interface inheritance

[IObservableMap&lt;K,V&gt;](iobservablemap_2.md) inherits [IMap&lt;K,V&gt;](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md). Types that implement [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) also implement the interface members of [IMap&lt;K,V&gt;](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md), with an [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md) type constraint.

### .NET usage

[IObservableMap&lt;K,V&gt;](iobservablemap_2.md) isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection&lt;T&gt;](XREF:TODO:T:System.Collections.ObjectModel.ObservableCollection`1) type (using a [KeyValuePair](XREF:TODO:T:System.Collections.Generic.KeyValuePair`2) as *T*) as a base class, or implement a **Dictionary** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use [IObservableMap&lt;K,V&gt;](iobservablemap_2.md) for .NET code, the base interfaces (and their members) project as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) and [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) (with [KeyValuePair](XREF:TODO:T:System.Collections.Generic.KeyValuePair`2)).

## -examples

## -see-also
[IObservableVector&lt;T&gt;](iobservablevector_1.md), [Collections ()](XREF:TODO:914da30b-aac5-4cd7-9da3-a5ac08cdd72c), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)