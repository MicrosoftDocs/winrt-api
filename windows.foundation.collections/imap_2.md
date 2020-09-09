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
> This interface appears to .NET code as [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2) due to .NET language projection. In any case where a Windows Runtime type has implemented IMap&lt;K,V&gt;, .NET code can use the APIs of [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2) interface if they want to implement a map/dictionary type. In any case where a Windows Runtime type has implemented IMap&lt;K,V&gt;, .NET code can use the APIs of [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The IMap&lt;K,V&gt; interface represents a collection of key-value pairs where a value can be accessed by its associated key. Properties and methods of IMap&lt;K,V&gt; support dictionary-type functionality, such as getting the size of the collection, and adding and removing items at specified locations in the collection. Additionally, the [GetView](imap_2_getview_37498667.md) method provides a snapshot of the map whose observable state does not change. The snapshot is useful when you need a view of the collection to refer to in subsequent operations that involve IMap&lt;K,V&gt;.

### Interface inheritance

IMap&lt;K,V&gt; inherits [IIterable&lt;T&gt;](iiterable_1.md), using an [IKeyValuePair](ikeyvaluepair_2.md) constraint that uses the same key and value types. Types that implement IMap&lt;K,V&gt; also implement the interface members of [IIterable&lt;T&gt;](iiterable_1.md), with [IKeyValuePair](ikeyvaluepair_2.md) type constraint sharing the same key and value. Similarly, if you're using .NET, there is support for [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1), with its constraint type as a [KeyValuePair](/dotnet/api/system.collections.generic.keyvaluepair-2) that uses the same key and value types as does the [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2) implementation.

## -examples

## -see-also
[Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2)
