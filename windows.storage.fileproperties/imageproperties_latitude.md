---
-api-id: P:Windows.Storage.FileProperties.ImageProperties.Latitude
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> Latitude { get; }
-->

# Windows.Storage.FileProperties.ImageProperties.Latitude

## -description
Gets the latitude coordinate where the photo was taken.

## -property-value
The latitude coordinate where the photo was taken.


The system computes this coordinate using the following file properties:

+ [System.GPS.Latitude](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitude)
+ [System.GPS.LatitudeDenominator](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitudedenominator)
+ [System.GPS.LatitudeNumerator](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latitudenumerator)
+ [System.GPS.LatitudeRef](https://docs.microsoft.com/windows/desktop/properties/props-system-gps-latituderef)


## -remarks
To set the latitude or longitude of the photo, you must set all four of the file properties that are used to compute the latitude coordinate.

For code examples that demonstrate working with Latitude, [Longitude](imageproperties_longitude.md) and their underlying file properties, see the [Simple imaging sample](https://github.com/microsoft/Windows-universal-samples/blob/master/Samples/SimpleImaging/README.md).

## -examples

## -see-also
