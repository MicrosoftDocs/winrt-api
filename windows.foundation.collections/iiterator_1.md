---
-api-id: T:Windows.Foundation.Collections.IIterator`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IIterator<T> : 
-->

# Windows.Foundation.Collections.IIterator<T>

## -description
Supports simple iteration over a collection.

## -remarks
The IIterator&lt;T&gt; interface isn't explicitly hidden by the language projection for .NET, but the [IIterable\<T\>](iiterable_1.md) interface is hidden. For most .NET scenarios that specifically require an API for the iterator object, you'll probably use [IEnumerator\<T\>](/dotnet/api/system.collections.generic.ienumerator-1) (perhaps with a specific type constraint) as obtained from calling [IEnumerable\<T\>.GetEnumerator](/dotnet/api/system.collections.generic.ienumerable-1.getenumerator).

If changes are made to the collection, such as adding, modifying, or deleting elements, the iterator is permitted to raise an exception for all operations.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
operator++();
operator++(int);
```

These operators permit ranged-for loops over Windows Runtime iterable objects. The prefix and postfix `++` operator advances the iterator, and sets it to `nullptr` if the iterator has completed.

```cppwinrt
T operator*() const;
```

Dereferencing the iterator is equivalent to calling [Current](/uwp/api/windows.foundation.collections.iiterator-1.current).

```cppwinrt
using iterator_concept= std::input_iterator_tag;
using iterator_catetory = std::input_iterator_tag;
using value_type = T;
using difference_type = ptrdiff_t;
using pointer = void;
using reference = T;
```

Nested types that improve interoperability with C++ iterators.

## -examples

## -see-also
[IIterable&lt;T&gt;](iiterable_1.md)
