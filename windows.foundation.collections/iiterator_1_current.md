---
-api-id: P:Windows.Foundation.Collections.IIterator`1.Current
-api-type: winrt property
---

<!-- Property syntax
public T Current { get; }
-->

# Windows.Foundation.Collections.IIterator<T>.Current

## -description
Gets the current item in the collection.

## -property-value
The current item in the collection.

## -remarks

It is an error to access this property if the iterator has no current item.

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