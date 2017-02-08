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

+ [System.GPS.Latitude](XREF:TODO:properties.props_System_GPS_Latitude)
+ [System.GPS.LatitudeDenominator](XREF:TODO:properties.props_System_GPS_LatitudeDenominator)
+ [System.GPS.LatitudeNumerator](XREF:TODO:properties.props_System_GPS_LatitudeNumerator)
+ [System.GPS.LatitudeRef](XREF:TODO:properties.props_System_GPS_LatitudeRef)


## -remarks
To set the latitude or longitude of the photo, you must set all four of the file properties that are used to compute the latitude coordinate.

For code examples that demonstrate working with [Latitude](imageproperties_latitude.md), [Longitude](imageproperties_longitude.md) and their underlying file properties, see the [Simple imaging sample](http://go.microsoft.com/fwlink/p/?linkid=231549).

## -examples

## -see-also
