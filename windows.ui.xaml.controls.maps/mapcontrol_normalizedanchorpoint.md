---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.NormalizedAnchorPoint
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.Maps.MapControl.NormalizedAnchorPoint

<!--
see GetNormalizedAnchorPoint, and SetNormalizedAnchorPoint
-->

## -description

Gets or sets the anchor point of a child element of the MapControl.

## -remarks

Specify a value from 0 to 1. The anchor point is the point on the child element that is positioned at the geographic location on the [MapControl](mapcontrol.md) specified by the [MapControl.Location](mapcontrol_location.md) attached property.

The default value of `MapControl.NormalizedAnchorPoint` is (0, 0), which represents the upper left corner of the child element.

A `MapControl.NormalizedAnchorPoint` value is interpreted by the parent `MapControl` element. The value is used along with `MapControl.Location` to specify the layout characteristics of each child element of a `MapControl`.

- Type: [Point](../windows.foundation/point.md)
- Identifier field: [NormalizedAnchorPointProperty](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.normalizedanchorpointproperty)
- Accessor methods: [GetNormalizedAnchorPoint](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.getnormalizedanchorpoint), [SetNormalizedAnchorPoint](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.setnormalizedanchorpoint)

## -see-also

[MapControl.Location](mapcontrol_location.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
