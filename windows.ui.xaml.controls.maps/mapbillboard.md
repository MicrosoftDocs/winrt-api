---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapBillboard
-api-type: winrt class
---

<!-- Class syntax.
public class MapBillboard : MapElement, MapElement
-->

# Windows.UI.Xaml.Controls.Maps.MapBillboard

## -description
Displays an image such as a pushpin that scales and fades in relation to its distance from the [ReferenceCamera](mapbillboard_referencecamera.md) of the [MapBillboard](mapbillboard.md).

## -remarks
A [MapBillboard](mapbillboard.md) is very similar to a [MapIcon](mapicon.md). Add one onto a [MapControl](mapcontrol.md) by adding it to the map control's [MapElements](mapcontrol_mapelements.md) collection.

> > [!TIP]
> When you display a [MapBillboard](mapbillboard.md) image that points to a specific location on the map - for example, a pushpin or an arrow - consider setting the value of the [NormalizedAnchorPoint](mapbillboard_normalizedanchorpoint.md) property to the approximate location of the pointer on the image. For example, if the image is an arrow pointing down, set the [NormalizedAnchorPoint](mapbillboard_normalizedanchorpoint.md) value to (0.5, 1.0) so the center bottom of the image is exactly at the specified map location. If you leave the value of [NormalizedAnchorPoint](mapbillboard_normalizedanchorpoint.md) at its default value of (0.5, 1.0), which represents the bottom center of the image, changes in the [ZoomLevel](mapcontrol_zoomlevel.md) of the map may leave the image pointing to a different location.

## -see-also
[MapIcon](mapicon.md)

## -examples
