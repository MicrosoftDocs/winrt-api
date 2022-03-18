---
-api-id: M:Windows.Foundation.Collections.IMapView`2.Split(Windows.Foundation.Collections.IMapView{`0,`1}@,Windows.Foundation.Collections.IMapView{`0,`1}@)
-api-type: winrt method
---

<!-- Method syntax
public void Split(Windows.Foundation.Collections.IMapView<K, V> first, Windows.Foundation.Collections.IMapView<K, V> second)
-->

# Windows.Foundation.Collections.IMapView<K, V>.Split

## -description
Splits the map view into two views.

## -parameters
### -param first
One half of the original map.

### -param second
The second half of the original map.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IReadOnlyDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) interface.

The two views that result from the split operation may not contain the same number of items. The two views do not overlap.

If the [IMapView<K, V>](imapview_2.md) instance cannot be split, then both the first and second parameters are **null** when the method returns.

<!--How does this work? divide by two? what if 1 or 0 or any odd number?-->

## -examples

## -see-also
[IMapView&lt;K, V&gt;](imapview_2.md)