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
> This interface appears as [System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2) due to .NET language projection. In any case where a Windows Runtime type has implemented IMapView&lt;K,V&gt;, .NET code can use the APIs of [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2) interface if they want to implement a read-only map/dictionary type. In any case where a Windows Runtime type has implemented IMapView&lt;K,V&gt;, .NET code can use the APIs of [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The IMapView&lt;K,V&gt; interface represents a collection of key-value pairs where a value can be accessed by its associated key. Properties and methods of IMapView&lt;K,V&gt; support dictionary-type functionality, such as getting the size of the collection, or lookups, but don't support adding or removing items because the map is read-only.

### Interface inheritance

IMapView inherits [IIterable](iiterable_1.md), using an [IKeyValuePair](ikeyvaluepair_2.md) constraint. Types that implement IMapView also implement the interface members of [IKeyValuePair](ikeyvaluepair_2.md), with an [IKeyValuePair](ikeyvaluepair_2.md) type constraint. Similarly, if you're using .NET, there is support for [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1), with its constraint type as a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2) that uses the same key and value types as does the [IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2) implementation.

## -examples

## -see-also
[IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2), [Collections (C++/CX)](/cpp/cppcx/collections-c-cx)
