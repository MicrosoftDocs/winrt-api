---
-api-id: T:Windows.Foundation.Collections.IObservableVector`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IObservableVector<T> : Windows.Foundation.Collections.IVector<T>
-->

# Windows.Foundation.Collections.IObservableVector<T>

## -description
Notifies listeners of changes to the vector.

## -remarks
The [IObservableVector&lt;T&gt;](iobservablevector_1.md) interface enables clients to register for notification events for [IVector&lt;T&gt;](ivector_1.md) objects. For example, use notification events when you need to keep two data structures synchronized. In this scenario, you can use the [IObservableVector&lt;T&gt;](iobservablevector_1.md) interface to receive notification of changes, so that the associated data structure can be updated.

Observable collections are mainly useful for XAML data binding scenarios. For more info, see [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

### Interface inheritance

[IObservableVector&lt;T&gt;](iobservablevector_1.md) inherits [IVector&lt;T&gt;](ivector_1.md) and [IIterable&lt;T&gt;](iiterable_1.md). Types that implement [IObservableMap&lt;T&gt;](iobservablemap_2.md) also implement the interface members of [IVector&lt;T&gt;](ivector_1.md) and [IIterable&lt;T&gt;](iiterable_1.md).

### .NET usage

[IObservableVector&lt;T&gt;](iobservablevector_1.md) isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) type as a base class, or implement a **List** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use [IObservableVector&lt;T&gt;](iobservablevector_1.md) for .NET code, the base interfaces (and their members) project as [IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1) and [IEnumerable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1).

## -examples

## -see-also
[IObservableMap&lt;K,V&gt;](iobservablemap_2.md), [Collections (C++/CX)](https://docs.microsoft.com/cpp/cppcx/collections-c-cx), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
