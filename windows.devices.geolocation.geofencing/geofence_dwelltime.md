---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.DwellTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DwellTime { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.DwellTime

## -description
The minimum time that a position has to be inside or outside of the [Geofence](geofence.md) in order for the notification to be triggered.

## -property-value
The minimum time that a position has to be inside or outside of the geofence in order for the notification to be triggered.

## -remarks
When creating geofences that use a dwell time, the time span must be greater than 0.

The `DwellTime` value is used for monitoring both the `MonitoredGeofenceStates.Entered` and `MonitoredGeofenceStates.Exited` flags of a single geofence. If you want to provide different dwell time values for entering and exiting, create two [Geofence](geofence.md) objects—one to track the `MonitoredGeofenceStates.Entered` state and another to track the `MonitoredGeofenceStates.Exited` state. Then you can specify a different dwell time for each object.

## -examples

## -see-also

## -capabilities
location
