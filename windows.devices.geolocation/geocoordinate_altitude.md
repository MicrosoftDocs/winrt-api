---
-api-id: P:Windows.Devices.Geolocation.Geocoordinate.Altitude
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> Altitude { get; }
-->

# Windows.Devices.Geolocation.Geocoordinate.Altitude

## -description
> [!NOTE]
> Altitude may be altered or unavailable after Windows 8.1 and Windows Phone 8.1. Instead, use [Geocoordinate.Point](geocoordinate_point.md).

The altitude of the location, in meters.

## -property-value
The altitude in meters.

## -remarks
This optional property will be set if it is available. If the property is not available, the value will be **NULL** or **NaN** (depending on the operating system version). We recommend that your app checks for both of these possibilities.

## -examples

## -see-also


## -capabilities
location, ID_CAP_LOCATION [Windows Phone]