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



> **.NET**
> This interface appears as [System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2) (a structure, not an interface). In any case where a Windows Runtime type has implemented [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md), .NET code can use the APIs of [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2) structure. In any case where a Windows Runtime type has implemented [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md), including when interfaces have inherited [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md) or used it as an inner constraint, .NET code can treat it as a .NET [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2).

Key-value pairs are used in the [IMap&lt;K,V&gt;](imap_2.md) interface, when it inherits [IIterable&lt;T&gt;](iiterable_1.md). Practical implementations of [IMap&lt;K,V&gt;](imap_2.md) are iterable, and iterating or calling [First](iiterable_1_first_1920739956.md)/[Current](iiterator_1_current.md) explicitly will return instances of [IKeyValuePair&lt;K,V&gt;](ikeyvaluepair_2.md) using the same constraints as does the [IMap&lt;K,V&gt;](imap_2.md) implementation.

## -examples

## -see-also
[IMap&lt;K,V&gt;](imap_2.md), [KeyValuePair&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2)