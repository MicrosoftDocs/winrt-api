---
-api-id: M:Windows.Foundation.Collections.IIterable`1.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<T> First()
-->

# Windows.Foundation.Collections.IIterable<T>.First

## -description
Returns an iterator for the items in the collection.

## -returns
The iterator.

## -remarks
When programming with .NET, this interface is hidden, and you should use the [System.Collections.Generic.IEnumerable\<T\>](/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) method.

If changes are made to the collection, such as adding, modifying, or deleting elements,
the iterator is permitted to raise an exception for all future operations.

## -examples

## -see-also
[IIterable&lt;T&gt;](iiterable_1.md)