---
-api-id: T:Windows.Devices.Geolocation.GeocoordinateSatelliteData
-api-type: winrt class
---

<!-- Class syntax.
public class GeocoordinateSatelliteData : Windows.Devices.Geolocation.IGeocoordinateSatelliteData
-->

# Windows.Devices.Geolocation.GeocoordinateSatelliteData

## -description

Provides additional information about a [Geocoordinate](geocoordinate.md). This information is only applicable to position estimates obtained using satellite signals.

## -remarks

You can use the [Geocoordinate.PositionSource](geocoordinate_positionsource.md) property to receive the GeocoordinateSatelliteData information.

The properties of this class convey information about the satellite geometry with which the position was obtained. Their values indicate the level of confidence that the position provided is precise. Lower values for dilution of precision (DOP) indicate high confidence on the precision of the position obtained. Positions with a DOP of 5 or less are considered reliable. Positions with a DOP higher than 10 are low confidence and should generally be discarded other than for a rough position estimation. Positions with a DOP higher than 20 should always be discarded.

> [!NOTE]
> If the GPS sensor returns a zero for any of the dilution of precision (DOP) values, the corresponding properties will return **NULL**.

## -examples

## -see-also

[Geolocation sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
