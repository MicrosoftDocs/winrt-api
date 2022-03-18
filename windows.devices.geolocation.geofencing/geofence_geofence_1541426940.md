---
-api-id: M:Windows.Devices.Geolocation.Geofencing.Geofence.#ctor(System.String,Windows.Devices.Geolocation.IGeoshape,Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Geofence(System.String id, Windows.Devices.Geolocation.IGeoshape geoshape, Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates monitoredStates, System.Boolean singleUse)
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.Geofence

## -description
Initializes a new [Geofence](geofence.md) object given the *id*, the shape of the geofence, the states to monitor the geofence for, and the *singleUse* flag.

## -parameters
### -param id
The Id of the geofence.

### -param geoshape
The area that defines the geofence to monitor.

### -param monitoredStates
The states to monitor the geofence for.

### -param singleUse
True indicates the geofence should be monitored only for one use. False indicates the geofence should be monitored for multiple uses.

## -remarks

## -examples

## -see-also
[Geofencing, start to finish](/previous-versions/windows/apps/dn263199(v=win.10)), [Geofence(String, IGeoshape)](geofence_geofence_161909132.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan)](geofence_geofence_247731772.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan, DateTime, TimeSpan)](geofence_geofence_1118020828.md)
## -capabilities
location
