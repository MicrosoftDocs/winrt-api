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
The altitude reference system is based on the distance above the tallest surface structures, such as buildings, trees, roads, etc., above terrain or ground level.


## -remarks
The **Terrain**, **Geoid**, and **Surface** are implementation dependent and not mathematically precise.

> [!NOTE]
> The altitude reference system that is returned for location fixes from the geolocation API may depend on the GPS/GNSS radio hardware. Most modern hardware will provide values using the **Geoid** reference system, but Map Control APIs will return values in the **Elipsoid** system. To find out which one is being used by a [Geopoint](geopoint.md) object, see the [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md) property. You should not copy a [BasicGeoposition](basicgeoposition.md) without also copying the associated [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md), otherwise the Altitude value will not be valid and could produce unexpected results.

## -examples

## -see-also
## -capabilities
location
