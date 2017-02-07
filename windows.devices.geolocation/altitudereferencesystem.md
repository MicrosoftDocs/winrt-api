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
> The default altitude reference system that is used to provide location data depends on the GPS/GNSS radio hardware. Hardware typically found on older desktop PCs will continue using an **Ellipsoid** reference system. Everything else will default to using the **Geoid** reference system. To find out which one is being used by a [Geopoint](geopoint.md) object, see the [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md) property.

## -examples

## -see-also