---
-api-id: T:Windows.Foundation.Collections.IIterable`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IIterable&lt;T&gt; : 
-->

# Windows.Foundation.Collections.IIterable&lt;T&gt;

## -description

Exposes an iterator that supports simple iteration over a collection of a specified type.

> **.NET**
> This interface appears as [System.Collections.Generic.IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true). In any case where a Windows Runtime type has implemented IIterable&lt;T&gt;, .NET code can use the APIs of [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) instead. C# code can use **foreach**, Visual Basic code can use **For Each...Next**. All the .NET extension methods that are based on [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) and included in .NET for UWP apps are accessible (including the **System.Linq** extensions, so long as you've included the namespace).

## -remarks

When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) interface. Because of how the projections were done, the [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true) method isn't always available as a direct callable method on the types that project [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) as implemented, but enumerating the collection with the standard enumeration syntax (**foreach**) is still supported. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true) from a class, cast to [IEnumerab&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), using a constraint in the cast that matches the item type of the collection.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for **IAsyncAction**. The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

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

[IIterator&lt;T&gt;](iiterator_1.md)
