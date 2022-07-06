---
-api-id: T:Windows.Foundation.Collections.IVector`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVector<T> : Windows.Foundation.Collections.IIterable<T>
-->

# Windows.Foundation.Collections.IVector<T>

## -description

Represents a random-access collection of elements.

> **.NET**
> This interface appears to .NET code as [System.Collections.Generic.IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) due to .NET language projection. In any case where a Windows Runtime type has implemented IVector&lt;T&gt;, .NET code can use the APIs of [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -remarks

When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) interface if they want to implement a vector/list type. In any case where a Windows Runtime type has implemented IVector&lt;T&gt;, .NET code can use the APIs of [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The IVector&lt;T&gt; interface represents a collection of objects of a specified type that can be individually accessed by index. Properties and methods of IVector&lt;T&gt; support list-type functionality, such as getting the size of the collection, and adding and removing items at specified locations in the collection. Additionally, the [GetView](ivector_1_getview_37498667.md) method provides a snapshot of the vector whose observable state does not change. The snapshot is useful when you need a view of the collection to refer to in subsequent operations that involve IVector&lt;T&gt;.

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

IVector inherits [IIterable](iiterable_1.md). Types that implement IVector also implement the interface members of [IIterable](iiterable_1.md). Similarly, if you're using .NET, there is support for [IEnumerable\<T\>](/dotnet/api/system.collections.generic.ienumerable-1).

## -examples

## -see-also

[Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [System.Collections.Generic.IList\<T\>](/dotnet/api/system.collections.generic.ilist-1)
