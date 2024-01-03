---
-api-id: T:Windows.Devices.Geolocation.PositionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.PositionStatus : int
-->

# PositionStatus

## -description
Indicates the ability of the [Geolocator](geolocator.md) object to provide location data.

## -enum-fields
### -field Ready:0
Location data is available.

### -field Initializing:1
Location services is initializing. This is the status if a GPS is the source of location data and the GPS receiver does not yet have the required number of satellites in view to obtain an accurate position.

### -field NoData:2
No location data is available from any source. [LocationStatus](geolocator_locationstatus.md) will have this value if the application calls [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md) or registers an event handler for the [PositionChanged](geolocator_positionchanged.md) event, before data is available from a location sensor. Once data is available [LocationStatus](geolocator_locationstatus.md) transitions to the **Ready** state.

### -field Disabled:3
Location settings are turned off. This status indicates that the user has not granted the application permission to access location.
<!--Is it the case that on Windows 8, this is the case when Location has been disabled in Control Panel.? Does sensor service need to be disabled through group policy?-->

### -field NotInitialized:4
An operation to retrieve location has not yet been initialized. [LocationStatus](geolocator_locationstatus.md) will have this value if the application has not yet called [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md) or registered an event handler for the [PositionChanged](geolocator_positionchanged.md) event. [LocationStatus](geolocator_locationstatus.md) may also have this value if your app doesn’t have permission to access location.

> [!IMPORTANT]
> Starting in Windows 10, call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before accessing the user's location. At that time, your app must be in the foreground and RequestAccessAsync must be called from the UI thread. Until the user grants your app permission to their location, your app can't access location data.

### -field NotAvailable:5
Location services is not available on this version of Windows.


## -remarks

## -examples

## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
