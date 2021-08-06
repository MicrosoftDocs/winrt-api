---
-api-id: M:Windows.Foundation.Collections.IVector`1.GetView
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<T> GetView()
-->

# Windows.Foundation.Collections.IVector<T>.GetView

## -description
Returns an immutable view of the vector.

## -returns
The view of the vector.

## -remarks
When programming with .NET, this interface is hidden, and you should use the [System.Collections.Generic.IList\<T\>](/dotnet/api/system.collections.generic.ilist-1) interface.

If changes are made to the vector, such as adding, modifying, or deleting elements, then the vector view is permitted to raise an exception for all future operations.

## -examples

## -see-also
[IVector&lt;T&gt;](ivector_1.md)