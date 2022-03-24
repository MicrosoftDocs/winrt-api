---
-api-id: E:Windows.Foundation.Collections.IObservableVector`1.VectorChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.Collections.VectorChangedEventHandler VectorChanged<T>
-->

# Windows.Foundation.Collections.IObservableVector<T>.VectorChanged

## -description
Occurs when the vector changes.

## -remarks
The event handler receives an [IVectorChangedEventArgs](ivectorchangedeventargs.md) object that contains data that describes the event.

### .NET usage

[IObservableVector\<T\>](iobservablevector_1.md) isn't hidden for .NET usage. However, it's more common to use the .NET [ObservableCollection\<T\>](/dotnet/api/system.collections.objectmodel.observablecollection-1) type as a base class, or implement a **List** type or interface (generic or nongeneric) and **INotifyCollectionChanged** separately. If you do use [IObservableVector\<T\>](iobservablevector_1.md) for .NET code, the base interfaces (and their members) project as [IList\<T\>](/dotnet/api/system.collections.generic.ilist-1) and [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1). VectorChanged is the only API that's shared between the projections.

## -examples

## -see-also
[IObservableVector&lt;T&gt;](iobservablevector_1.md), [VectorChangedEventHandler(T)](vectorchangedeventhandler_1.md), [IVectorChangedEventArgs](ivectorchangedeventargs.md)
