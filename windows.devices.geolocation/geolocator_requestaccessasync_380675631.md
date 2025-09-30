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

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

## -returns
A [GeolocationAccessStatus](geolocationaccessstatus.md) that indicates if permission to location data has been granted.

## -remarks
Call RequestAccessAsync before accessing the user's location. At that time, your app must be in the foreground and
RequestAccessAsync must be called from the UI thread. Until the user grants your app permission to their location, your
app can't access location data.

You must call this method on the UI thread, otherwise an exception will occur.

When you first call this method, it prompts the user to give permission. The prompt is displayed for each app (per app).
After the first time they grant or deny permission, this method no longer prompts for permission. Provide an in-app link
to the device's location privacy settings so users can revisit their choice later. When the user has given the app any
level of location permission, your app can work as intended.

## -examples

## -see-also
[GeolocationAccessStatus](geolocationaccessstatus.md)

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1507 | 10240 | RequestAccessAsync |
| 24H2 | 26100 | Location consent required for Wi-Fi BSSIDs |

## -capabilities
location
