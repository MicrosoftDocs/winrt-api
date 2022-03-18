---
-api-id: M:Windows.Devices.Geolocation.Geolocator.GetGeopositionAsync(Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Geolocation.Geoposition> GetGeopositionAsync(Windows.Foundation.TimeSpan maximumAge, Windows.Foundation.TimeSpan timeout)
-->

# Windows.Devices.Geolocation.Geolocator.GetGeopositionAsync

## -description
Starts an asynchronous operation to retrieve the current location of the device.

## -parameters
### -param maximumAge
The maximum acceptable age of cached location data. A [TimeSpan](../windows.foundation/timespan.md) is a time period expressed in 100-nanosecond units.

### -param timeout
The timeout. A [TimeSpan](../windows.foundation/timespan.md) is a time period expressed in 100-nanosecond units.

## -returns
An asynchronous operation that, upon completion, returns a [Geoposition](geoposition.md) marking the found location.

## -remarks
A location will be returned immediately if the latest location is within an acceptable age. Otherwise, a location will not be returned until the next change. In some cases, your app may receive location data that is older than the specified *maximumAge* value. This is because an additional age value will be calculated based on the desired accuracy setting, and your app will use whichever of the two ages is larger. For example, say a default accuracy of 500 meters corresponds to a maximum age of 30 seconds. In that case, your app could receive 20 second old data even if you set *maximumAge* to 10 seconds.

## -examples

## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [Geoposition](geoposition.md), [Geocoordinate](geocoordinate.md), [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
