---
-api-id: T:Windows.Devices.Geolocation.GeolocationAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.GeolocationAccessStatus : int
-->

# GeolocationAccessStatus

## -description
Indicates if your app has permission to access location data.

## -enum-fields
### -field Unspecified:0
Permission to access location was not specified.

### -field Allowed:1
Permission to access location was granted.

### -field Denied:2
Permission to access location was denied.

## -remarks
The [GeolocationAccessStatus](geolocationaccessstatus.md) enum is returned by
[RequestAccessAsync](geolocator_requestaccessasync_380675631.md) to indicate whether your application has permission to
access location data.

### Permission handling

> [!IMPORTANT]
> Always call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before attempting to use location services.
> The request must be made from the UI thread while your app is in the foreground.

### Status meanings and responses

- `Allowed`: Your app has permission to access location data. You can proceed with location operations.
- `Denied`: The user has denied location access or location is disabled by system policy. Guide users to **Settings > Privacy & Security > Location** to enable access if appropriate for your app's functionality.
- `Unspecified`: Permission request failed due to an error condition. This may occur if the request wasn't made from the UI thread or if the app wasn't in the foreground.

> [!NOTE]
> Permission status can change after your app has started. Monitor [StatusChanged](geolocator_statuschanged.md) events
> to detect when location access is revoked or restored.

## -examples

## -see-also
[Geolocator](geolocator.md)

## -capabilities
location
