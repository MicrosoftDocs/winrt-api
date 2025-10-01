---
-api-id: N:Windows.Devices.Geolocation
-api-type: winrt namespace
---

# Windows.Devices.Geolocation

## -description

Provides APIs for [getting the current location](/windows/uwp/maps-and-location/get-location) or tracking the device's
location over time. Location information comes from GNSS, Wi-Fi, cellular networks, IP address, or user-configured
default location.

## -remarks

The Windows.Devices.Geolocation namespace provides comprehensive location services for Windows applications. This
namespace contains classes and interfaces for obtaining location data with various levels of accuracy and tracking
location changes over time.

### Accuracy expectations

The accuracy of the location information depends on the source. The latitude and longitude may vary within the following
ranges:

- GNSS: within approximately 10 meters
- Wi-Fi: between approximately 30 meters and 500 meters
- Cell towers: between approximately 300 meters and 3,000 meters
- IP address: between approximately 300 meters and 10,000 meters

In addition to latitude and longitude, GNSS also provides information about heading, speed, and altitude. This additional
information is optional when the location information comes from other sources.

> [!NOTE]
> The system automatically selects the most appropriate location source based on availability, accuracy requirements,
> and power consumption considerations.

### Permission requirements

> [!IMPORTANT]
> Location access requires explicit user permission. Always call
> [Geolocator.RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before attempting to access location data.

### Key classes

- [Geolocator](geolocator.md): Provides the primary APIs for accessing location services.
- [Geoposition](geoposition.md): Represents a geographic position with coordinate and venue data.
- [Geocoordinate](geocoordinate.md): Contains precise geographic coordinates and accuracy information.
- [GeovisitMonitor](geovisitmonitor.md): Monitors user visits to significant locations.

### Privacy and accuracy

Location services balance accuracy with battery consumption and user privacy. Consider your app's actual needs when
choosing accuracy settings:

- Use [PositionAccuracy.Default](positionaccuracy.md) for most scenarios.
- Use [PositionAccuracy.High](positionaccuracy.md) only when precise location is required.
- Respect user privacy preferences and handle denied permissions gracefully.

## -examples

Sample applications that use classes from this namespace include the
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation) and the
[Geotag sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geotag).

## -see-also

[Get current location](/windows/uwp/maps-and-location/get-location),
[Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence)

## -capabilities

location
