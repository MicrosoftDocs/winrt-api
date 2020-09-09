---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.TransformOrigin
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point TransformOrigin { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TransformOrigin

## -description
Gets or sets a point to which the logical center of the map is transformed.

## -property-value
A point to which the logical center of the map is transformed. Use a value between 0 and 1 (but not 0 or 1) for the X and Y properties of the [Point](../windows.foundation/point.md).

## -remarks
The TransformOrigin represents a point around which the map rotates – for example, when the user manipulates the map, or when you change the value of the [Heading](mapcontrol_heading.md) property. Consider setting the Y value of the TransformOrigin to a value greater than 0.5 when the map is tilted - that is, when the [Pitch](mapcontrol_pitch.md) is greater than 0. This moves the logical center closer to the user - that is, closer to the bottom of the screen - and shows the user more of what’s in the distance when the map is rotated.

After you set the value of the TransformOrigin property for the [MapControl](mapcontrol.md), the [Center](mapcontrol_center.md) property continues to return the previous center until you set the [Center](mapcontrol_center.md) to the same value as the TransformOrigin.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
