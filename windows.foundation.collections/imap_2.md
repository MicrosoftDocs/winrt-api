---
-api-id: T:Windows.Foundation.Collections.IMap`2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMap<K, V> : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<K, V>>
-->

# Windows.Foundation.Collections.IMap<K, V>

## -description

Represents an associative collection, also known as a map or a dictionary.

> **.NET**
> This interface appears to .NET code as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) due to .NET language projection. In any case where a Windows Runtime type has implemented IMap&lt;K,V&gt;, .NET code can use the APIs of [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -remarks

When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) interface if they want to implement a map/dictionary type. In any case where a Windows Runtime type has implemented IMap&lt;K,V&gt;, .NET code can use the APIs of [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The IMap&lt;K,V&gt; interface represents a collection of key-value pairs where a value can be accessed by its associated key. Properties and methods of IMap&lt;K,V&gt; support dictionary-type functionality, such as getting the size of the collection, and adding and removing items at specified locations in the collection. Additionally, the [GetView](imap_2_getview_37498667.md) method provides a snapshot of the map whose observable state does not change. The snapshot is useful when you need a view of the collection to refer to in subsequent operations that involve IMap&lt;K,V&gt;.

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

```cppwinrt
bool TryRemove(param_type<K> const& key) const;
```
 
Removes the element in the map with the key *key*, if present. Returns `true` if the element was found and removed. Returns `false` if the element was not found.

### Interface inheritance

IMap&lt;K,V&gt; inherits [IIterable&lt;T&gt;](iiterable_1.md), using an [IKeyValuePair](ikeyvaluepair_2.md) constraint that uses the same key and value types. Types that implement IMap&lt;K,V&gt; also implement the interface members of [IIterable&lt;T&gt;](iiterable_1.md), with [IKeyValuePair](ikeyvaluepair_2.md) type constraint sharing the same key and value. Similarly, if you're using .NET, there is support for [IEnumerabe&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), with its constraint type as a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) that uses the same key and value types as does the [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) implementation.


## -examples

## -see-also

[Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true)
