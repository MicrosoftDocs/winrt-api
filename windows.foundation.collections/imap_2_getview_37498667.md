---
-api-id: M:Windows.Foundation.Collections.IMap`2.GetView
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IMapView<K, V> GetView()
-->

# Windows.Foundation.Collections.IMap<K, V>.GetView

## -description
Returns an immutable view of the map.

## -returns
The view of the map.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) interface.

If changes are made to the map, such as adding, modifying, or deleting elements,
the map view is permitted to raise an exception for all future operations.

## -examples

## -see-also
[IMap&lt;K, V&gt;](imap_2.md)