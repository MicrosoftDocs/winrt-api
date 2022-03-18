---
-api-id: P:Windows.Devices.Geolocation.Geopoint.AltitudeReferenceSystem
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.AltitudeReferenceSystem AltitudeReferenceSystem { get; }
-->

# Windows.Devices.Geolocation.Geopoint.AltitudeReferenceSystem

## -description
The altitude reference system of the geographic point. GeoPoint will default to a value of unspecified when constructed without an altitude reference system. The behavior of an unspecified altitude reference system will depend on the API. A [MapIcon](/uwp/api/Windows.UI.Xaml.Controls.Maps.MapIcon) will treat an unspecified reference system as Surface with an altitude value of 0 and the supplied value for altitude will be ignored.

## -property-value
The altitude reference system of the geographic point.

## -remarks
> [!NOTE]
> The default [altitude reference system](altitudereferencesystem.md) that’s used to provide location data depends on the GPS/GNSS radio hardware. Most hardware will return coordinates using the **Geoid** reference system. To find out which one is being used by a [Geopoint](geopoint.md) object, see the AltitudeReferenceSystem property. The **Geoid** reference system may not be what you want depending on your application. For example if passing the coordinates to a map control, you may instead want to snap the coordinate to the terrain.

## -examples

## -see-also

## -capabilities
location
