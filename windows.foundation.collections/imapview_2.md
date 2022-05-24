---
-api-id: T:Windows.Foundation.Collections.IMapView`2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMapView<K, V> : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<K, V>>
-->

# Windows.Foundation.Collections.IMapView<K, V>

## -description
Represents an immutable view into a map.

> **.NET**
> This interface appears as [System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) due to .NET language projection. In any case where a Windows Runtime type has implemented IMapView&lt;K,V&gt;, .NET code can use the APIs of [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) interface if they want to implement a read-only map/dictionary type. In any case where a Windows Runtime type has implemented IMapView&lt;K,V&gt;, .NET code can use the APIs of [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in C++ from a C# or Visual Basic app.

The IMapView&lt;K,V&gt; interface represents a collection of key-value pairs where a value can be accessed by its associated key. Properties and methods of IMapView&lt;K,V&gt; support dictionary-type functionality, such as getting the size of the collection, or lookups, but don't support adding or removing items because the map is read-only.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
auto begin() const;
```

Returns an iterator to the first key-value pair of the collection, for use in C++ algorithms such as range-based `for` loops.

```cppwinrt
auto end() const;
```

Returns an iterator to one past the last key-value pair of the collection, for use in C++ algorithms such as range-based `for` loops.

```cppwinrt
auto TryLookup(param_type<K> const& key) const;
```

Tries to look up an element in the map with the key *key*. For reference types, returns the value if found, or `nullptr` if not found. For value types, returns a **std::optional\<V\>**, which holds the value if found, or has no value if not found.

### Interface inheritance

IMapView inherits [IIterable](iiterable_1.md), using an [IKeyValuePair](ikeyvaluepair_2.md) constraint. Types that implement IMapView also implement the interface members of [IKeyValuePair](ikeyvaluepair_2.md), with an [IKeyValuePair](ikeyvaluepair_2.md) type constraint. Similarly, if you're using .NET, there is support for [IEnumerable;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), with its constraint type as a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) that uses the same key and value types as does the [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) implementation.

## -examples

## -see-also
[IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true), [Collections (C++/CX)](/cpp/cppcx/collections-c-cx)
