---
-api-id: M:Windows.Foundation.Collections.IVectorView`1.GetAt(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public T GetAt(System.UInt32 index)
-->

# Windows.Foundation.Collections.IVectorView<T>.GetAt

## -description
Returns the item at the specified index in the vector view.

## -parameters
### -param index
The zero-based index of the item.

## -returns
The item at the specified index.

## -remarks
When programming with .NET, this interface is hidden and developers should use the IReadOnlyList&lt;T&gt; interface.

If the index is out of range,
the view will throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the index is out of range,
> the view will throw a `hresult_out_of_bounds` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the index is out of range,
> the view will throw a `OutOfBoundsException` exception.

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