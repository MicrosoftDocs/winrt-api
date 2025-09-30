---
-api-id: T:Windows.Devices.Geolocation.Geocoordinate
-api-type: winrt class
---

<!-- Class syntax.
public class Geocoordinate : Windows.Devices.Geolocation.IGeocoordinate, Windows.Devices.Geolocation.IGeocoordinateWithPoint, Windows.Devices.Geolocation.IGeocoordinateWithPositionData, Windows.Devices.Geolocation.IGeocoordinateWithPositionSourceTimestamp
-->

# Windows.Devices.Geolocation.Geocoordinate

## -description
Contains the information for identifying a geographic location.

## -remarks
The [Geocoordinate](geocoordinate.md) class represents a geographic location with associated metadata about accuracy,
positioning method, and optional movement data.

### Key properties

#### Always available
- [Latitude](geocoordinate_latitude.md): Represents the latitude coordinate in degrees.
- [Longitude](geocoordinate_longitude.md): Represents the longitude coordinate in degrees.
- [Accuracy](geocoordinate_accuracy.md): Indicates the accuracy of the position in meters.
- [Timestamp](geocoordinate_timestamp.md): Indicates when the position was determined.

#### Conditionally available
- [Altitude](geocoordinate_altitude.md): Provides the height above sea level when available from GNSS or other
  altitude-capable sources.
- [AltitudeAccuracy](geocoordinate_altitudeaccuracy.md): Reports the accuracy of altitude measurements.
- [Heading](geocoordinate_heading.md): Indicates the direction of travel in degrees from true north.
- [Speed](geocoordinate_speed.md): Reports the speed of movement in meters per second.

#### Additional information
- [PositionSource](geocoordinate_positionsource.md): Identifies whether the location came from GNSS, cellular, Wi-Fi,
  or other sources.
- [SatelliteData](geocoordinate_satellitedata.md): Provides additional GNSS satellite information when available.

### Data availability and null handling

> [!IMPORTANT]
> Always check for null values before using [Altitude](geocoordinate_altitude.md),
> [AltitudeAccuracy](geocoordinate_altitudeaccuracy.md), [Heading](geocoordinate_heading.md), and
> [Speed](geocoordinate_speed.md) properties. These are only provided when the positioning system can determine them.

> [!NOTE]
> The [PositionSource](geocoordinate_positionsource.md) property indicates the primary method used to determine the
> location. This can help you assess the relative reliability and characteristics of the position data.

Retrieve an instance of this class using the [Geoposition.Coordinate](geoposition_coordinate.md) property from a
[Geolocator](geolocator.md) operation.

## -examples

## -see-also
[Geolocator](geolocator.md),
[Geoposition](geoposition.md),
[PositionSource](positionsource.md)

## -capabilities
location
