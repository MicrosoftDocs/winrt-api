---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.Location
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.Maps.MapControl.Location

<!--
see GetLocation, and SetLocation
-->

## -description

Gets or sets the location of a child element of the MapControl.

## -remarks

The location is the geographic location on the [MapControl](mapcontrol.md) at which the [MapControl.NormalizedAnchorPoint](mapcontrol_normalizedanchorpoint.md) of the child element is positioned.

Since a string can't be converted to a [Geopoint](../windows.devices.geolocation/geopoint.md), you can't specify a value for the `MapControl.Location` attached property in XAML markup unless you use data binding.

A `MapControl.Location` value is interpreted by the parent `MapControl` element. The value is used along with `MapControl.NormalizedAnchorPoint` to specify the layout characteristics of each child element of a `MapControl`.

If you provide an `Altitude` and `AltitudeReferenceSystem` in 3D views, then elements added to the `MapControl` end up being placed underground or floating in space.

- Type: [Geopoint](../windows.devices.geolocation/geopoint.md)
- Identifier field: [LocationProperty](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.locationproperty)
- Accessor methods: [GetLocation](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.getlocation), [SetLocation](/uwp/api/windows.ui.xaml.controls.maps.mapcontrol.setlocation)

## -see-also

[MapControl.NormalizedAnchorPoint](mapcontrol_normalizedanchorpoint.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
