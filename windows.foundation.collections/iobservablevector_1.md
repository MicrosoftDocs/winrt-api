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
The IObservableVector&lt;T&gt; interface enables clients to register for notification events for [IVector<T>](ivector_1.md) objects. For example, use notification events when you need to keep two data structures synchronized. In this scenario, you can use the IObservableVector&lt;T&gt; interface to receive notification of changes, so that the associated data structure can be updated.

Observable collections are mainly useful for XAML data binding scenarios. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

### Interface inheritance

IObservableVector&lt;T&gt; inherits [IVector<T>](ivector_1.md) and [IIterable<T>](iiterable_1.md). Types that implement [IObservableMap<T>](iobservablemap_2.md) also implement the interface members of [IVector<T>](ivector_1.md) and [IIterable<T>](iiterable_1.md).

### .NET usage

IObservableVector&lt;T&gt; isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection\<T\>](/dotnet/api/system.collections.objectmodel.observablecollection-1) type as a base class, or implement a **List** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use IObservableVector&lt;T&gt; for .NET code, the base interfaces (and their members) project as [IList\<T\>](/dotnet/api/system.collections.generic.ilist-1) and [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1).

## -examples

## -see-also
[IObservableMap&lt;K,V&gt;](iobservablemap_2.md), [Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
