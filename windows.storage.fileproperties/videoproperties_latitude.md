---
-api-id: P:Windows.Storage.FileProperties.VideoProperties.Latitude
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> Latitude { get; }
-->

# Windows.Storage.FileProperties.VideoProperties.Latitude

## -description
Gets the latitude coordinate where the video was shot.

## -property-value
The latitude coordinate where the video was shot.


The system computes this coordinate using the following file properties:

+ [System.GPS.Latitude](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitude)
+ [System.GPS.LatitudeDenominator](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitudedenominator)
+ [System.GPS.LatitudeNumerator](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitudenumerator)
+ [System.GPS.LatitudeRef](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latituderef)


## -remarks
To set the latitude or longitude of the video, you must set all four of the file properties that are used to compute the latitude or longitude coordinates.

For code examples that demonstrate working with Latitude, [Longitude](videoproperties_longitude.md) and their underlying file properties, see the [Simple imaging sample](https://go.microsoft.com/fwlink/p/?linkid=231549).

## -examples

## -see-also
