---
-api-id: T:Windows.Foundation.Collections.IIterator`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IIterator<T> : 
-->

# Windows.Foundation.Collections.IIterator<T>

## -description
Supports simple iteration over a collection.

## -remarks
The [IIterator&lt;T&gt;](iiterator_1.md) interface isn't explicitly hidden by the language projection for .NET, but the [IIterable&lt;T&gt;](iiterable_1.md) interface is hidden. For most .NET scenarios that specifically require an API for the iterator object, you'll probably use [IEnumerator<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1) (perhaps with a specific type constraint) as obtained from calling [IEnumerable<T>.GetEnumerator](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator).

## -examples

## -see-also
[IIterable&lt;T&gt;](iiterable_1.md)