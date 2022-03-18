---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapElement
-api-type: winrt class
---

<!-- Class syntax.
public class MapElement : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Maps.IMapElement, Windows.UI.Xaml.Controls.Maps.IMapElement2
-->

# Windows.UI.Xaml.Controls.Maps.MapElement

## -description
Represents an element displayed on a [MapControl](mapcontrol.md).

## -remarks
Display pushpins, images, and shapes on the [MapControl](mapcontrol.md) by adding them to its [MapElements](mapcontrol_mapelements.md) collection.

+ Display an **image** such as a pushpin with optional text by using the [MapIcon](mapicon.md) class. Keep the default image or provide a custom image.
+ Define and display a [MapPolygon](mappolygon.md) or a [MapPolyline](mappolyline.md).
+ Display a **3D model** using the [MapElement3D](mapelement3d.md) class.

Alternately, to display XAML elements on the [MapControl](mapcontrol.md), add them to its [Children](mapcontrol_children.md) collection.

For more info, see [Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | MapStyleSheetEntry |
| 1709 | 16299 | MapStyleSheetEntryState |
| 1709 | 16299 | Tag |
| 1803 | 17134 | IsEnabled |

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps), [DependencyObject](../windows.ui.xaml/dependencyobject.md)
