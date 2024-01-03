---
-api-id: M:Windows.Devices.Geolocation.Geolocator.RequestAccessAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Geolocation.GeolocationAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.Geolocation.Geolocator.RequestAccessAsync

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Requests permission to access location data.

## -returns
A [GeolocationAccessStatus](geolocationaccessstatus.md) that indicates if permission to location data has been granted.

## -remarks
The RequestAccessAsync method prompts the user for permission to access their location. The user is only prompted once (per app). After the first time they grant or deny permission, this method no longer prompts for permission. To help the user change location permissions after they've been prompted, we recommend providing a link to the location settings on their device. When the user has given the app some kind of location permissions, your app can work as intended; to determine which type of location tracking is being used, query the **[PositionSource](geocoordinate_positionsource.md)** property of a retrieved **[Geocoordinate](Geocoordinate.md)** object. 

> [!TIP]
> To link to location settings from your app, call the [LaunchUriAsync](../windows.system/launcher_launchuriasync_53691900.md) method with the URI `ms-settings:privacy-location`. For more info, see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app).



## -examples

## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)
## -capabilities
location
