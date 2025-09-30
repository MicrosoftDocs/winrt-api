---
-api-id: T:Windows.Devices.Geolocation.AltitudeReferenceSystem
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.AltitudeReferenceSystem : int
-->

# AltitudeReferenceSystem

## -description
Indicates the altitude reference system to be used in defining a geographic shape.

## -enum-fields
### -field Unspecified:0
The altitude reference system was not specified.

### -field Terrain:1
The altitude reference system is based on distance above terrain or ground level.

### -field Ellipsoid:2
The altitude reference system is based on an ellipsoid which is a mathematical approximation of the shape of the Earth.

### -field Geoid:3
The altitude reference system is based on the distance above sea level.

### -field Surface:4
The altitude reference system is based on the distance above the tallest surface structures, such as buildings,
trees, roads, etc., above terrain or ground level.


## -remarks
The `Terrain`, `Geoid`, and `Surface` values are implementation dependent and not mathematically precise.

> [!NOTE]
> The altitude reference system returned for a location fix may depend on the GNSS hardware. Most modern hardware
> reports values using the `Geoid` reference system, but Map Control APIs return values in the `Ellipsoid` system.
> To find the active reference system for a [Geopoint](geopoint.md), check the
> [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md) property. When copying a
> [BasicGeoposition](basicgeoposition.md), also copy the associated
> [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md); otherwise the `Altitude` value may be invalid.

## -examples

## -see-also
[BasicGeoposition](basicgeoposition.md),
[Geopoint](geopoint.md)

## -capabilities
location
