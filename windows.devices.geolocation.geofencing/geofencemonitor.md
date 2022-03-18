---
-api-id: T:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class GeofenceMonitor : Windows.Devices.Geolocation.Geofencing.IGeofenceMonitor
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor

## -description
Contains the information about the monitored [Geofence](geofence.md) objects.

## -remarks
Use the static [Current](geofencemonitor_current.md) property to get the GeofenceMonitor object which contains all of an app’s geofence information.

You will receive an **IDS_GEOFENCEMONITOR_OUT_OF_SYNC** exception if the Location Framework Service event state is out of synchronization with the GeofenceMonitor. You can attempt to recover by removing all event handlers on the GeofenceMonitor or restarting the application. Once all event handlers have been removed, you may add back any event handlers and retry the operation.

## -examples

## -see-also
[Geofencing, start to finish](/previous-versions/windows/apps/dn263199(v=win.10)), [Windows.Devices.Geolocation](windows_devices_geolocation_geofencing.md), [Geofence](geofence.md)
## -capabilities
location
