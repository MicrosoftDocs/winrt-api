---
-api-id: P:Windows.Devices.Geolocation.Geocoordinate.Accuracy
-api-type: winrt property
---

<!-- Property syntax
public double Accuracy { get; }
-->

# Windows.Devices.Geolocation.Geocoordinate.Accuracy

## -description
The accuracy of the location in meters.

## -property-value
The accuracy in meters.

## -remarks
Location services accuracy depends on the location data available. For example, if Wi-Fi is available, data is accurate to within 50 meters. If Wi-Fi is not available, the data could be accurate to within 10 miles or larger.

A GNSS device can provide data accurate to within a few meters. However, its accuracy can vary if the GNSS sensor is obscured by buildings, trees, or cloud cover. GNSS data may not be available at all within a building.

## -examples

## -see-also


## -capabilities
location, ID_CAP_LOCATION [Windows Phone]