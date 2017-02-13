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
The [RequestAccessAsync](geolocator_requestaccessasync.md) method prompts the user for permission to access their location. The user is only prompted once (per app). After the first time they grant or deny permission, this method no longer prompts for permission. To help the user change location permissions after they've been prompted, we recommend providing a link to the location settings on their device.

> [!TIP]
> To link to location settings from your app, call the [LaunchUriAsync](../windows.system/launcher_launchuriasync.md) method with the URI "`ms-settings:privacy-location` ". For more info, see [Launch the Windows Settings app](http://msdn.microsoft.com/library/c84d4bee-1fee-4648-ad7d-8321eac70290).



## -examples

## -see-also
[Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Set up a geofence](http://msdn.microsoft.com/library/a3a46e03-0751-4dbd-a2a1-2323db09bdba), [geolocation sample](http://go.microsoft.com/fwlink/p/?linkid=533278)