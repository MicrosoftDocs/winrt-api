---
-api-id: T:Windows.Devices.Geolocation.Geoposition
-api-type: winrt class
---

<!-- Class syntax.
public class Geoposition : Windows.Devices.Geolocation.IGeoposition, Windows.Devices.Geolocation.IGeoposition2
-->

# Windows.Devices.Geolocation.Geoposition

## -description
Represents a location that may contain latitude and longitude data or venue data.

## -remarks
The [Geoposition](geoposition.md) class is the primary container for location information returned by the location service.
It wraps coordinate data and optional civic address information.

### Key properties

- [Coordinate](geoposition_coordinate.md): Contains geographic coordinates, accuracy, and positioning metadata
- [CivicAddress](geoposition_civicaddress.md): Contains human-readable address information when available
- [VenueData](geoposition_venuedata.md): Contains venue-specific metadata when provided by the location source

### Data interpretation

The [Coordinate](geoposition_coordinate.md) property always contains location data, while
[CivicAddress](geoposition_civicaddress.md) and [VenueData](geoposition_venuedata.md) may be null depending on the
location source and available data.

> [!NOTE]
> Civic address information is not available for all locations and depends on the positioning method and available
> mapping data. Always check for null before accessing civic address properties.

> [!NOTE]
> Venue data is returned only when the positioning infrastructure supplies surveyed venue metadata.

Retrieve a [Geoposition](geoposition.md) object by using the
[GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md) method or handling the
[PositionChanged](geolocator_positionchanged.md) event.

## -examples

## -see-also
[CivicAddress](geoposition_civicaddress.md),
[Geocoordinate](geocoordinate.md),
[Geolocator](geolocator.md),
[VenueData](geoposition_venuedata.md)

## -capabilities
location
