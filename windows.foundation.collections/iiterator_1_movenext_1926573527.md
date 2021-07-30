---
-api-id: M:Windows.Foundation.Collections.IIterator`1.MoveNext
-api-type: winrt method
---

<!-- Method syntax
public bool MoveNext()
-->

# Windows.Foundation.Collections.IIterator<T>.MoveNext

## -description
Advances the iterator to the next item in the collection.

## -returns
True if the iterator refers to a valid item in the collection; false if the iterator passes the end of the collection.

## -remarks

If the iterator is already past the end of the collection,
the iterator may throw an exception.

> **.NET Framework**
> If the iterator is already past the end of the collection,
> the iterator may throw a `COMException` exception
> with an HResult of `0x8000000B` (`E_BOUNDS`).

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the iterator is already past the end of the collection,
> the iterator may throw a `hresult_out_of_bounds` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the iterator is already past the end of the collection,
> the iterator may throw a `OutOfBoundsException` exception.

If the underlying collection has changed,
the iterator may throw an exception.

> **.NET Framework**
> If the underlying collection has changed,
> the iterator may throw a `COMException` exception
> with an HResult of `0x8000000C` (`E_CHANGED_STATE`).

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the underlying collection has changed,
> the iterator may throw a `hresult_changed_state` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the underlying collection has changed,
> the iterator may throw a `ChangedStateException` exception.

## -examples

## -see-also
[IIterator&lt;T&gt;](iiterator_1.md)