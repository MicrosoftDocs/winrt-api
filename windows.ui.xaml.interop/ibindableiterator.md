---
-api-id: T:Windows.UI.Xaml.Interop.IBindableIterator
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBindableIterator : 
-->

# Windows.UI.Xaml.Interop.IBindableIterator

## -description

Supports bindable iteration over a collection.



## -remarks

This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true). For more info, see [Binding to collections](/windows/uwp/data-binding/data-binding-quickstart).

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
auto begin() const;
```

Returns an iterator to the first element of the collection, for use in C++ algorithms such as range-based `for` loops.

```cppwinrt
auto end() const;
```

Returns an iterator to one past the last element of the collection, for use in C++ algorithms such as range-based `for` loops.

```cppwinrt
operator++();
operator++(int);
```

These operators permit ranged-for loops over Windows Runtime iterable objects. The prefix and postfix `++` operator advances the iterator, and sets it to `nullptr` if the iterator has completed.

```cppwinrt
T operator*() const;
```

Dereferencing the iterator is equivalent to calling [Current](/uwp/api/windows.ui.xaml.interop.ibindableiterator.current).

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

[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
