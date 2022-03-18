---
-api-id: M:Windows.Foundation.Collections.IIterator`1.GetMany(`0[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(T[] items)
-->

# Windows.Foundation.Collections.IIterator<T>.GetMany

## -description

Retrieves all items in the collection.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> Retrieves multiple items from the iterator.
> 
> The correct syntax for the C++/WinRT language projection is `uint32_t GetMany(winrt::array_view<T> items);`.

## -parameters

### -param items

The items in the collection.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> A [winrt::array_view](/uwp/cpp-ref-for-winrt/array-view) that receives the items retrieved from the iterator.

## -returns

The number of items in the collection.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> The number of items that were retrieved. This value can be less than the size of *items* if the end of the iterator is reached.

## -remarks

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> In addition to passing a **winrt::array_view\<T\>**, you can pass any object that's convertible to a **winrt::array_view\<T\>**, such as these examples.
> - C++ **std::array\<T, N\>**
> - C-style array of **T**
> - C++ **std::vector\<T\>**
> - { pointer, length }, where *pointer* is a pointer to a buffer of **T** objects, and *length* is the number of entries in the buffer
> - { first, last }, where *first* and *last* represent a range of **T** objects [first, last)
> 
> The iterator is advanced past the items that were retrieved.

## -examples

## -see-also

[IIterator\<T\> interface](iiterator_1.md)
