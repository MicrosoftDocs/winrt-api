---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapIcon.NormalizedAnchorPoint
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point NormalizedAnchorPoint { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapIcon.NormalizedAnchorPoint

## -description
Gets or sets the anchor point of the [MapIcon](mapicon.md). The anchor point is the point on the [MapIcon](mapicon.md) that is positioned at the point on the [MapControl](mapcontrol.md) specified by the [Location](mapicon_location.md) property.

## -property-value
The anchor point of the [MapIcon](mapicon.md).

## -remarks
When you display a [MapIcon](mapicon.md) image that points to a specific location on the map - for example, a pushpin or an arrow - consider setting the value of the NormalizedAnchorPoint property to the approximate location of the pointer on the image. If you leave the value of NormalizedAnchorPoint at its default value of (0, 0), which represents the upper left corner of the image, changes in the [ZoomLevel](mapcontrol_zoomlevel.md) of the map may leave the image pointing to a different location.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
