---
-api-id: T:Windows.Foundation.Collections.IVectorView`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVectorView<T> : Windows.Foundation.Collections.IIterable<T>
-->

# Windows.Foundation.Collections.IVectorView<T>

## -description

Represents an immutable view into a vector.

> **.NET**
> This interface appears to .NET code as [System.Collections.Generic.IReadOnlyList&lt;T&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) due to .NET language projection. In any case where a Windows Runtime type has implemented IVectorView&lt;T&gt;, .NET code can use the APIs of [IReadOnlyList&lt;T&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -remarks

For read-write collections, the IVectorView&lt;T&gt; interface is still relevant, because the [IVector.GetView](ivector_1_getview_37498667.md) method returns an IVectorView&lt;T&gt; instance.

If the underlying collection changes, methods and properties of the IVectorView&lt;T&gt; interface may throw an exception.

> [**C++/WinRT**](/windows/uwp/cpp-and-winrt-apis/)
> If the underlying collection has changed,
> methods and properties may throw a `hresult_changed_state` exception.

> [**C++/CX**](/cpp/cppcx/)
> If the underlying collection has changed,
> methods and properties may throw a `ChangedStateException` exception.

When programming with .NET, this interface is hidden and developers should use the IReadOnlyList&lt;T&gt; interface if they want to implement a read-only vector/list type. In any case where a Windows Runtime type has implemented IVectorView&lt;T&gt;, .NET code can use the APIs of IReadOnlyList&lt;T&gt; instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

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

### Interface inheritance

IVectorView inherits [IIterable](iiterable_1.md). Types that implement IVectorView also implement the interface members of [IIterable](iiterable_1.md). Similarly, if you're using .NET, there is support for [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also

[IIterable&lt;T&gt;](iiterable_1.md), [IVector.GetView](ivector_1_getview_37498667.md), , [Collections (C++/CX)](/cpp/cppcx/collections-c-cx)
