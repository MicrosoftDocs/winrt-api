---
-api-id: P:Windows.Foundation.Collections.IIterator`1.HasCurrent
-api-type: winrt property
---

<!-- Property syntax
public bool HasCurrent { get; }
-->

# Windows.Foundation.Collections.IIterator<T>.HasCurrent

## -description
Gets a value that indicates whether the iterator refers to a current item or is at the end of the collection.

## -property-value
True if the iterator refers to a valid item in the collection; otherwise, false.

## -remarks

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