---
-api-id: M:Windows.Devices.Geolocation.Geolocator.RequestAccessAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Geolocation.GeolocationAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.Geolocation.Geolocator.RequestAccessAsync

## -description
Requests permission to access location data.

## -returns
A [GeolocationAccessStatus](geolocationaccessstatus.md) that indicates if permission to location data has been granted.

## -remarks
The RequestAccessAsync method prompts the user for permission to access their location. The user is only prompted once (per app). After the first time they grant or deny permission, this method no longer prompts for permission. To help the user change location permissions after they've been prompted, we recommend providing a link to the location settings on their device. When the user has given the app some kind of location permissions, your app can work as intended; to determine which type of location tracking is being used, query the **[PositionSource](geocoordinate_positionsource.md)** property of a retrieved **[Geocoordinate](Geocoordinate.md)** object. 

> [!TIP]
> To link to location settings from your app, call the [LaunchUriAsync](../windows.system/launcher_launchuriasync_53691900.md) method with the URI `ms-settings:privacy-location`. For more info, see [Launch the Windows Settings app](https://docs.microsoft.com/windows/uwp/launch-resume/launch-settings-app).



## -examples

## -see-also
[Get current location](https://docs.microsoft.com/windows/uwp/maps-and-location/get-location), [Get current location](https://docs.microsoft.com/windows/uwp/maps-and-location/get-location), [Set up a geofence](https://docs.microsoft.com/windows/uwp/maps-and-location/set-up-a-geofence), [geolocation sample](https://go.microsoft.com/fwlink/p/?linkid=533278)
## -capabilities
location
