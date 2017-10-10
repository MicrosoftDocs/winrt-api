---
-api-id: T:Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates : uint
-->

# MonitoredGeofenceStates

## -description
Indicates the state or states of the Geofences that are currently being monitored by the system.

## -enum-fields
### -field None:0
No flag is set.

### -field Entered:1
The device has entered a geofence area.

### -field Exited:2
The device has left a geofence area.

### -field Removed:4
The geofence has been removed.


## -remarks
You must specify the **Entered** or **Exited** states, or both, for a geofence to be monitored. It is not possible to create a geofence that only monitors the **Removed** state.

## -examples

## -see-also
[Geofence](geofence.md)
## -capabilities
location
