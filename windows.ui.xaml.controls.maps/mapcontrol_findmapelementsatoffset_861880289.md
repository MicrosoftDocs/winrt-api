---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.FindMapElementsAtOffset(Windows.Foundation.Point,System.Double)
-api-type: winrt method
---

<!-- Method syntax.
public IVectorView<MapElement> MapControl.FindMapElementsAtOffset(Point offset, Double radius)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.FindMapElementsAtOffset


## -description

Retrieves the collection of [MapElement](mapcontrol_mapelements.md) objects within the specified radius.

## -parameters

### -param offset

The point on the map that marks the center of a radius from which to retrieve the collection of [MapElement](mapelement.md) objects.

### -param radius

A number that's added to the offset to mark the edge of the radius.

## -returns

The collection of [MapElement](mapcontrol_mapelements.md) objects within the specified radius.

## -remarks

Use this overload to retrieve a collection of map objects by using a hit test area that your app captures from touch interactions.

## -see-also

[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)

## -examples

