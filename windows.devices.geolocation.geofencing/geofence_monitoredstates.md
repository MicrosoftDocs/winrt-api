---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.MonitoredStates
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates MonitoredStates { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.MonitoredStates

## -description
Indicates the states that the [Geofence](geofence.md) is being monitored for.

## -property-value
The states that the geofence is being monitored for.

## -remarks
You must specify the `MonitoredGeofenceStates.Entered` or `MonitoredGeofenceStates.Exited` flags, or both, for a geofence to be monitored. It is not possible to create a geofence that only monitors the `MonitoredGeofenceStates.Removed` flag.

## -examples

## -see-also

## -capabilities
location
