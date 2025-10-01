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
Location data can be retrieved.

### -field Initializing:1
Attempting to obtain an initial location fix. Reported when a [Geolocator](geolocator.md) object is first created or when
its desired accuracy is changed.

### -field NoData:2
No location data is available from any source.
> Call [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before accessing the user's location. At that
> time, your app must be in the foreground and `RequestAccessAsync` must be called from the UI thread. Until the user
> grants your app permission to their location, your app can't access location data.

### -field Disabled:3
Location settings are turned off. This status indicates that the user has not granted the application permission to
access location.

### -field NotInitialized:4
An operation to retrieve location has not yet been initialized. [LocationStatus](geolocator_locationstatus.md) will have
this value if the application has not yet called [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md) or
registered an event handler for the [PositionChanged](geolocator_positionchanged.md) event.

### -field NotAvailable:5
Location is not supported on this version of Windows.

## -remarks
PositionStatus values indicate whether location can be retrieved and whether the app has permission. Monitor changes
using the [StatusChanged](geolocator_statuschanged.md) event.

## -examples

## -see-also
[Geolocator](geolocator.md), [StatusChangedEventArgs](statuschangedeventargs.md)

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1507 | 10240 | NotInitialized |

## -capabilities
location
