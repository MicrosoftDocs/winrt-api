---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapIcon
-api-type: winrt class
---

<!-- Class syntax.
public class MapIcon : Windows.UI.Xaml.Controls.Maps.MapElement, Windows.UI.Xaml.Controls.Maps.IMapIcon, Windows.UI.Xaml.Controls.Maps.IMapIcon2
-->

# Windows.UI.Xaml.Controls.Maps.MapIcon

## -description
Displays an image such as a pushpin with optional text on a [MapControl](mapcontrol.md). Use the default image or provide a custom image.

## -remarks
Display pushpins, images, and shapes on the [MapControl](mapcontrol.md) by adding them to its [MapElements](mapcontrol_mapelements.md) collection.


+ Display an **image** such as a pushpin with optional text by using the MapIcon class. Keep the default image or provide a custom image.
+ Define and display a [MapPolygon](mappolygon.md) or a [MapPolyline](mappolyline.md).
Alternately, to display XAML elements on the [MapControl](mapcontrol.md), add them to its [Children](mapcontrol_children.md) collection.

If you don't explicitly set an [Altitude](/uwp/api/windows.devices.geolocation.basicgeoposition) and [AltitudeReferenceSystem](/uwp/api/windows.devices.geolocation.geopoint.AltitudeReferenceSystem), the [**MapIcon**](/uwp/api/Windows.UI.Xaml.Controls.Maps.MapIcon) will be placed on the surface.

> > [!TIP]
> When you display a MapIcon image that points to a specific location on the map - for example, a pushpin or an arrow - consider setting the value of the [NormalizedAnchorPoint](mapicon_normalizedanchorpoint.md) property to the approximate location of the pointer on the image. If you leave the value of [NormalizedAnchorPoint](mapicon_normalizedanchorpoint.md) at its default value of (0, 0), which represents the upper left corner of the image, changes in the [ZoomLevel](mapcontrol_zoomlevel.md) of the map may leave the image pointing to a different location.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps), [MapElement](mapelement.md)
