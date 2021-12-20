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
The IObservableMap&lt;K,V&gt; interface enables clients to register for notification events to [IMap<K,V>](imap_2.md) collections. For example, you might use IObservableMap&lt;K,V&gt; when you need to keep two map structures synchronized. In this case, use the IObservableMap&lt;K,V&gt; interface to receive notification of changes, so that the associated data structure can be updated.

Observable collections are mainly useful for XAML data binding scenarios. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

### Interface inheritance

IObservableMap&lt;K,V&gt; inherits [IMap<K,V>](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md). Types that implement IObservableMap&lt;K,V&gt; also implement the interface members of [IMap<K,V>](imap_2.md) and [IIterable&lt;T&gt;](iiterable_1.md), with an [IKeyValuePair<K,V>](ikeyvaluepair_2.md) type constraint.

### .NET usage

IObservableMap&lt;K,V&gt; isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection&lt;T&gt;](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) type (using a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) as *T*) as a base class, or implement a **Dictionary** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use IObservableMap&lt;K,V&gt; for .NET code, the base interfaces (and their members) project as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) and [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) (with [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true)).

## -examples

## -see-also
[IObservableVector&lt;T&gt;](iobservablevector_1.md), [Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
