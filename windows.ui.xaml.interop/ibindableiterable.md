---
-api-id: T:Windows.UI.Xaml.Interop.IBindableIterable
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBindableIterable : 
-->

# Windows.UI.Xaml.Interop.IBindableIterable

## -description
Extends [IIterable](../windows.foundation.collections/iiterable_1.md) to enable data-binding infrastructure requirements.

> **.NET**
> This interface appears as [System.Collections.IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true).



## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) interface.

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

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
