---
-api-id: P:Windows.Devices.Geolocation.Geopoint.AltitudeReferenceSystem
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.AltitudeReferenceSystem AltitudeReferenceSystem { get; }
-->

# Windows.Devices.Geolocation.Geopoint.AltitudeReferenceSystem

## -description
The altitude reference system of the geographic point.

## -property-value
The altitude reference system of the geographic point.

## -remarks
> [!NOTE]
> The default [altitude reference system](altitudereferencesystem.md) that’s used to provide location data depends on the GPS/GNSS radio hardware. Hardware typically found on older desktop PCs will continue using an **Ellipsoid** reference system. Everything else will default to using the **Geoid** reference system. To find out which one is being used by a [Geopoint](geopoint.md) object, see the [AltitudeReferenceSystem](geopoint_altitudereferencesystem.md) property.

## -examples

## -see-also
