---
-api-id: P:Windows.Foundation.Collections.IVectorView`1.Size
-api-type: winrt property
---

<!-- Property syntax
public uint Size { get; }
-->

# Windows.Foundation.Collections.IVectorView<T>.Size

## -description
Gets the number of items in the vector view.

## -property-value
The number of items in the vector view.

## -remarks
When programming with .NET, this interface is hidden and developers should use the IReadOnlyList&lt;T&gt; interface.

If the underlying collection has changed,
the view may throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the underlying collection has changed,
> the view may throw a `hresult_changed_state` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the underlying collection has changed,
> the view may throw a `ChangedStateException` exception.

## -examples

## -see-also
[IVectorView&lt;T&gt;](ivectorview_1.md)