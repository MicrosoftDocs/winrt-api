---
-api-id: T:Windows.Foundation.Collections.IVectorChangedEventArgs
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVectorChangedEventArgs : 
-->

# Windows.Foundation.Collections.IVectorChangedEventArgs

## -description
Provides data for the changed event of a vector.

## -remarks
IVectorChangedEventArgs is specifically used for the [VectorChanged](iobservablevector_1_vectorchanged.md) event of the [IObservableVector&lt;T&gt;](iobservablevector_1.md) interface, via the [VectorChangedEventHandler](vectorchangedeventhandler_1.md) delegate.

.NET developers can get instances of this interface via handling the [VectorChanged](iobservablevector_1_vectorchanged.md) event from an [IObservableVector](iobservablevector_1.md) instance. Even though the remainder of the collection support for [IObservableVector](iobservablevector_1.md) uses language projections that change [IVector&lt;T&gt;](ivector_1.md) APIs to [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) APIs, the [VectorChanged](iobservablevector_1_vectorchanged.md) event, its delegates and its event data aren't changed by the projection and so "Vector" (as opposed to "List") remains in the API names.

## -examples

## -see-also
[IObservableVector&lt;T&gt;](iobservablevector_1.md)
