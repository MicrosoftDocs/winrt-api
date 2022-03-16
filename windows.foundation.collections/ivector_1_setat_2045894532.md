---
-api-id: M:Windows.Foundation.Collections.IVector`1.SetAt(System.UInt32,`0)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, T value)
-->

# Windows.Foundation.Collections.IVector<T>.SetAt

## -description
Sets the value at the specified index in the vector.

## -parameters
### -param index
The zero-based index at which to set the value.

### -param value
The item to set.

## -remarks
When programming with .NET, this interface is hidden, and you should use the [System.Collections.Generic.IList\<T\>](/dotnet/api/system.collections.generic.ilist-1) interface.

If the index is out of range,
the view will throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the index is out of range,
> the vector will throw a `hresult_out_of_bounds` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the index is out of range,
> the vector will throw a `OutOfBoundsException` exception.

## -examples

## -see-also
[IVector&lt;T&gt;](ivector_1.md)