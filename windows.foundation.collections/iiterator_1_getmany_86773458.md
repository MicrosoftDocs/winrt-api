---
-api-id: M:Windows.Foundation.Collections.IIterator`1.GetMany(`0[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(T[] items)
-->

# Windows.Foundation.Collections.IIterator<T>.GetMany

## -description

Retrieves multiple items from the iterator.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> The correct syntax for the C++/WinRT language projection is `uint32_t GetMany(winrt::array_view<T> items);`.

## -parameters

### -param items

An array that receives the items retrieved from the iterator.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> A [winrt::array_view](/uwp/cpp-ref-for-winrt/array-view) that receives the items retrieved from the iterator.

## -returns

The number of items that were retrieved.
This value can be less than the size of *items*
if the end of the iterator is reached.

## -remarks

The iterator is advanced past the items that were retrieved.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> In addition to passing a **winrt::array_view\<T\>**, you can pass any object that's convertible to a **winrt::array_view\<T\>**, such as these examples.
> - C++ **std::array\<T, N\>**
> - C-style array of **T**
> - C++ **std::vector\<T\>**
> - { pointer, length }, where *pointer* is a pointer to a buffer of **T** objects, and *length* is the number of entries in the buffer
> - { first, last }, where *first* and *last* represent a range of **T** objects [first, last)

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

[IIterator\<T\> interface](iiterator_1.md)
