---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.SingleUse
-api-type: winrt property
---

<!-- Property syntax
public bool SingleUse { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.SingleUse

## -description
Indicates whether the [Geofence](geofence.md) should be triggered once or multiple times.

## -property-value
`true` indicates the geofence should be monitored only for one use. `false` indicates the geofence should be monitored for multiple uses.

## -remarks
A geofence is considered used when all [MonitoredStates](geofence_monitoredstates.md) have been triggered. If a geofence is only being monitored for the `MonitoredGeofenceStates.Entered` event and `SingleUse` is set to `true`, then entering the geofence marks it as used and it is removed. If a geofence is monitored for both the `MonitoredGeofenceStates.Entered` and `MonitoredGeofenceStates.Exited` events and `SingleUse` is set to `true`, then the geofence is removed after the user has both entered and exited the geofence.

## -examples

## -see-also

## -capabilities
location
