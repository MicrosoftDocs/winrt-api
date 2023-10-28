---
-api-id: M:Windows.Foundation.Collections.IVectorView`1.GetMany(System.UInt32,`0[])
-api-type: winrt method
---

<!-- Method syntax.
public uint IVectorView<T>.GetMany(UInt32 startIndex, T[] items)
-->

# Windows.Foundation.Collections.IVectorView<T>.GetMany

## -description

Retrieves multiple items from the vector view beginning at the given index.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> The correct syntax for the C++/WinRT language projection is `uint32_t GetMany(uint32_t startIndex, winrt::array_view<T> items);`.

## -parameters

### -param startIndex

The zero-based index to start at.

### -param items

An array that receives the items copied from the vector view.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> A [winrt::array_view](/uwp/cpp-ref-for-winrt/array-view) that receives the items copied from the vector view.

## -returns

The number of items that were retrieved.
This value can be less than the size of *items*
if the end of the vector is reached.

## -remarks

When programming with .NET, this interface is hidden. Use the IList interface instead. 

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> In addition to passing a **winrt::array_view\<T\>**, you can pass any object that's convertible to a **winrt::array_view\<T\>**, such as these examples.
> - C++ **std::array\<T, N\>**
> - C-style array of **T**
> - C++ **std::vector\<T\>**
> - { pointer, length }, where *pointer* is a pointer to a buffer of **T** objects, and *length* is the number of entries in the buffer
> - { first, last }, where *first* and *last* represent a range of **T** objects [first, last)

If the start index is greater than the size of the collection,
the view will throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the start index is greater than or equal to the size of the collection,
> the view will throw a `hresult_out_of_bounds` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the start index is greater than or equal to the size of the collection,
> the view will throw a `OutOfBoundsException` exception.

If the underlying collection has changed,
the view may throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the underlying collection has changed,
> the view may throw a `hresult_changed_state` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the underlying collection has changed,
> the view may throw a `ChangedStateException` exception.


## -see-also

## -examples

