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
**True** indicates the geofence should be monitored only for one use. **False** indicates the geofence should be monitored for multiple uses.

## -remarks
A geofence is considered used when all [MonitoredStates](geofence_monitoredstates.md) have been triggered. If a geofence is only being monitored for the **Entered** event and [SingleUse](geofence_singleuse.md) is set to **true**, then entering the geofence will mark it as used and it will be removed. If a geofence is being monitored for both **Entered** and **Exited** events and [SingleUse](geofence_singleuse.md) is set to **true**, then the geofence will be removed after the user has both entered and exited the geofence.

## -examples

## -see-also
