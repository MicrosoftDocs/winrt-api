---
-api-id: T:Windows.Foundation.Collections.IKeyValuePair`2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IKeyValuePair<K, V> : 
-->

# Windows.Foundation.Collections.IKeyValuePair<K, V>

## -description

Represents a key-value pair. This is typically used as a constraint type when you need to encapsulate two type parameters into one to satisfy the constraints of another generic interface.

> [!NOTE]
> In .NET, this interface appears as [System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) (a structure, not an interface). In any case where a Windows Runtime type has implemented IKeyValuePair&lt;K,V&gt;, .NET code can use the APIs of [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) instead.

## -remarks

When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true) structure. In any case where a Windows Runtime type has implemented IKeyValuePair&lt;K,V&gt;, including when interfaces have inherited IKeyValuePair&lt;K,V&gt; or used it as an inner constraint, .NET code can treat it as a .NET [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true).

Key-value pairs are used in the [IMap&lt;K,V&gt;](imap_2.md) interface, when it inherits [IIterable&lt;T&gt;](iiterable_1.md). Practical implementations of [IMap&lt;K,V&gt;](imap_2.md) are iterable, and iterating or calling [First](iiterable_1_first_1920739956.md)/[Current](iiterator_1_current.md) explicitly will return instances of IKeyValuePair&lt;K,V&gt; using the same constraints as does the [IMap&lt;K,V&gt;](imap_2.md) implementation.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
operator==
```

Comparing two **KeyValuePair** objects, compare the keys and values rather than comparing the interfaces.

### Structured binding (C++/WinRT)

**IKeyValuePair\<K, V\>** supports structured binding. For example,

```cppwinrt
auto&& [key, value] = kvp;
```

is equivalent to,

```cppwinrt
auto key = kvp.Key();
auto value = kvp.Value();
```

Structured binding is particularly convenient in range-based `for` loops, letting you iterate through the key/value pairs of a map.

```cppwinrt
winrt::Windows::Foundation::Collections::IMap<K, V> map;
for (auto&& [key, value] : map) { ... }
```

## -examples

## -see-also

[IMap&lt;K,V&gt;](imap_2.md), [KeyValuePair&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.keyvaluepair-2?view=dotnet-uwp-10.0&preserve-view=true)
