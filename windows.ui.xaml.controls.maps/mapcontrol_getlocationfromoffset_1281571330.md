---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.GetLocationFromOffset(Windows.Foundation.Point,Windows.Devices.Geolocation.AltitudeReferenceSystem,Windows.Devices.Geolocation.Geopoint@)
-api-type: winrt method
---

<!-- Method syntax.
public void MapControl.GetLocationFromOffset(Point offset, AltitudeReferenceSystem desiredReferenceSystem, Geopoint location)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.GetLocationFromOffset

## -description
Converts a point on the map to a geographic location by using the specified altitude reference system.

__Note__: Map controls do not support the Geoid altitude reference system.

## -params

## -param offset
A point on the map to convert to a geographic location.

## -param desiredReferenceSystem
The altitude reference system of the geographic point. Map controls do not support the Geoid altitude reference system. A value of **Unspecified** for the altitude reference system has the same effect as using the default [GetLocationFromOffset(Windows.Foundation.Point offset, Windows.Devices.Geolocation.Geopoint location)](mapcontrol_getlocationfromoffset_1345615754.md) overload.

## -param location
When this method returns, contains the corresponding geographic location.

## -remarks
This method provides an instance of a [Geopoint](../windows.devices.geolocation/geopoint.md). That [Geopoint](../windows.devices.geolocation/geopoint.md) contains a [BasicGeoPosition](../windows.devices.geolocation/geoposition.md). object.  The *desiredReferenceSystem* parameter sets the [Altitude](https://docs.microsoft.com/uwp/api/windows.devices.geolocation.basicgeoposition#Windows_Devices_Geolocation_BasicGeoposition_Altitude) field of that object.  

This method will throw an exception if the point is invalid.
> [!NOTE]
> An [AltitudeReferenceSystem](../windows.devices.geolocation/altitudereferencesystem.md) of **Geoid** and **Ellipsoid** might not be supported.

## -see-also
[Display maps with 2D, 3D, and Streetside views](http://msdn.microsoft.com/library/3839e00b-2c1e-4627-a45f-6dda98d7077f).
## -examples
