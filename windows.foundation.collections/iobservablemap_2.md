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
The IObservableMap&lt;K,V&gt; interface enables clients to register for notification events to [IMap&lt;K,V&gt;](imap_2.md) collections. For example, you might use IObservableMap&lt;K,V&gt; when you need to keep two map structures synchronized. In this case, use the IObservableMap&lt;K,V&gt; interface to receive notification of changes, so that the associated data structure can be updated.

Observable collections are mainly useful for XAML data binding scenarios. For more info, see [Data binding in depth](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-in-depth).

### Interface inheritance

IObservableMap&lt;K,V&gt; inherits [IMap&lt;K,V&gt;](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md). Types that implement IObservableMap&lt;K,V&gt; also implement the interface members of [IMap&lt;K,V&gt;](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md), with an [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md) type constraint.

### .NET usage

IObservableMap&lt;K,V&gt; isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) type (using a [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2) as *T*) as a base class, or implement a **Dictionary** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use IObservableMap&lt;K,V&gt; for .NET code, the base interfaces (and their members) project as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) and [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) (with [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2)).

## -examples

## -see-also
[IObservableVector&lt;T&gt;](iobservablevector_1.md), [Collections (C++/CX)](https://docs.microsoft.com/cpp/cppcx/collections-c-cx), [Data binding in depth](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-in-depth)
