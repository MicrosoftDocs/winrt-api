---
-api-id: M:Windows.Foundation.Collections.IMap`2.Lookup(`0)
-api-type: winrt method
---

<!-- Method syntax
public V Lookup(K key)
-->

# Windows.Foundation.Collections.IMap<K, V>.Lookup

## -description
Returns the item at the specified key in the map.

## -parameters
### -param key
The key associated with the item to locate.

## -returns
The value, if an item with the specified key exists. Use the **HasKey** method to determine whether the key exists.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) interface.

Use the [HasKey](imap_2_haskey.md) method to determine whether the key exists in the map.

## -examples

## -see-also
[IMap&lt;K, V&gt;](imap_2.md)