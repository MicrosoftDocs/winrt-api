---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TryGetLocationFromOffset(Windows.Foundation.Point,Windows.Devices.Geolocation.AltitudeReferenceSystem,Windows.Devices.Geolocation.Geopoint@)
-api-type: winrt method
---

<!-- Method syntax.
public bool MapControl.TryGetLocationFromOffset(Point offset, AltitudeReferenceSystem desiredReferenceSystem, Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TryGetLocationFromOffset


## -description

Converts a point on the map to a geographic location by using the specified altitude reference system.

## -parameters

### -param offset

A point on the map to convert to a geographic location.

### -param desiredReferenceSystem

The altitude reference system of the geographic point. A value of **Unspecified** for the altitude reference system has the same effect as using the default [TryGetLocationFromOffset(Windows.Foundation.Point offset, Windows.Devices.Geolocation.Geopoint location)](mapcontrol_trygetlocationfromoffset_77980665.md) overload.

### -param location

When this method returns, contains the corresponding geographic location.

## -returns

Returns **true** if the location is invalid; otherwise, **false**.

## -remarks

Use this method instead of the [GetLocationFromOffset](mapcontrol_getlocationfromoffset_1281571330.md) method. The [GetLocationFromOffset](mapcontrol_getlocationfromoffset_1281571330.md) method has been deprecated.

## -see-also

## -examples

