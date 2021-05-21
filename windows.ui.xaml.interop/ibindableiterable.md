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

Equivalent WinUI interface: [Microsoft.UI.Xaml.Interop.IBindableIterable](/windows/winui/api/microsoft.ui.xaml.interop.ibindableiterable).

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) interface.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
begin() const;
end() const;
```

Return iterators to the beginning or end of an iterable object. These methods are provided to permit ranged-for loops over Windows Runtime iterable objects.

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
