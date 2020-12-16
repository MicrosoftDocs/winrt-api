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
The IIterator&lt;T&gt; interface isn't explicitly hidden by the language projection for .NET, but the [IIterable<T>](iiterable_1.md) interface is hidden. For most .NET scenarios that specifically require an API for the iterator object, you'll probably use [IEnumerator<T>](/dotnet/api/system.collections.generic.ienumerator-1?view=dotnet-uwp-10.0&preserve-view=true) (perhaps with a specific type constraint) as obtained from calling [IEnumerable<T>.GetEnumerator](/dotnet/api/system.collections.generic.ienumerable-1.getenumerator?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[IIterable&lt;T&gt;](iiterable_1.md)
