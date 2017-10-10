---
-api-id: P:Windows.Devices.Geolocation.Geofencing.Geofence.StartTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime StartTime { get; }
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.StartTime

## -description
The time to start monitoring the [Geofence](geofence.md).

## -property-value
The time to start monitoring the geofence. The default value is 0, which is the beginning of time, epoch.

## -remarks
A geofence is made active when the [StartTime](geofence_starttime.md) is in the past. If the device is within the geofence's area when it becomes active and the geofence is being monitored for the **Entered** state, then the geofence will trigger as soon as the [DwellTime](geofence_dwelltime.md) requirement has been met. However, if the device is outside of the geofence when it becomes active, the geofence does not instantly switch to the **Exited** state. The device must enter a geofence, remain inside for the specified [DwellTime](geofence_dwelltime.md), and then exit in order to switch to the **Exited** state.

## -examples

## -see-also

## -capabilities
location
