---
-api-id: M:Windows.Foundation.Collections.IVectorView`1.IndexOf(`0,System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public bool IndexOf(T value, System.UInt32 index)
-->

# Windows.Foundation.Collections.IVectorView<T>.IndexOf

## -description
Retrieves the index of a specified item in the vector view.

## -parameters
### -param value
The item to find in the vector view.

### -param index
If the item is found, this is the zero-based index of the item; otherwise, this parameter is 0.

## -returns
**true** if the item is found; otherwise, **false**.

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