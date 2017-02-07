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
Retrieve an instance of this class using the [Geoposition.Coordinate](geoposition_coordinate.md) property.

Values for the [Latitude](geocoordinate_latitude.md), [Longitude](geocoordinate_longitude.md), and [Accuracy](geocoordinate_accuracy.md) properties are always provided. Values for the [Altitude](geocoordinate_altitude.md), [AltitudeAccuracy](geocoordinate_altitudeaccuracy.md), [Heading](geocoordinate_heading.md), and [Speed](geocoordinate_speed.md) properties are provided if available. If they are not available, they will be **null** in JavaScript code.

## -examples

## -see-also

## -capabilities
location, ID_CAP_LOCATION [Windows Phone]