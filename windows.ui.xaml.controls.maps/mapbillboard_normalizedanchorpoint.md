---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapBillboard.NormalizedAnchorPoint
-api-type: winrt property
---

<!-- Property syntax.
public Point NormalizedAnchorPoint { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapBillboard.NormalizedAnchorPoint

## -description
Gets or sets the anchor point of the [MapBillboard](mapbillboard.md). The anchor point is the point on the [MapBillboard](mapbillboard.md) that is positioned at the point on the [MapControl](mapcontrol.md) specified by the Location property.

## -property-value
The anchor point of the [MapBillboard](mapbillboard.md).

## -remarks
When you display a [MapBillboard](mapbillboard.md) image that points to a specific location on the map - for example, a pushpin or an arrow - consider setting the value of the [NormalizedAnchorPoint](mapbillboard_normalizedanchorpoint.md) property to the approximate location of the pointer on the image. If you leave the value of [NormalizedAnchorPoint](mapbillboard_normalizedanchorpoint.md) at its default value of (0.5, 1), which represents the bottom center of the image, changes in the [ZoomLevel](mapcontrol_zoomlevel.md) of the map may leave the image pointing to a different location.

## -see-also

## -examples
