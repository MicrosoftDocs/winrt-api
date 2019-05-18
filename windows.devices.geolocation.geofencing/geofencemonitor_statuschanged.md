---
-api-id: E:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.StatusChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StatusChanged<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,  object>
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.StatusChanged

## -description
Raised when the status of the [GeofenceMonitor](geofencemonitor.md) has changed.

## -remarks
When using a geofence, use the [GeofenceMonitor](geofencemonitor.md) 's StatusChanged event to monitor changes in location permissions instead of the [StatusChanged](../windows.devices.geolocation/geolocator_statuschanged.md) event from the [Geolocator](../windows.devices.geolocation/geolocator.md) class. A [GeofenceMonitorStatus](geofencemonitorstatus.md) of **Disabled** is equivalent to a **Disabled **[PositionStatus](../windows.devices.geolocation/positionstatus.md) - both indicate that the app does not have permission to access the location.

## -examples

## -see-also
[Geofence](geofence.md)
## -capabilities
location
