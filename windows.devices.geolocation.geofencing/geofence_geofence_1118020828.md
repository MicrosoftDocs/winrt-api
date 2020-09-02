---
-api-id: M:Windows.Devices.Geolocation.Geofencing.Geofence.#ctor(System.String,Windows.Devices.Geolocation.IGeoshape,Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates,System.Boolean,Windows.Foundation.TimeSpan,Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Geofence(System.String id, Windows.Devices.Geolocation.IGeoshape geoshape, Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates monitoredStates, System.Boolean singleUse, Windows.Foundation.TimeSpan dwellTime, Windows.Foundation.DateTime startTime, Windows.Foundation.TimeSpan duration)
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.Geofence

## -description
Initializes a new [Geofence](geofence.md) object given the *id*, the shape of the geofence, the states to monitor the geofence for, the *singleUse* flag, the *dwellTime* for the geofence, the time to start monitoring the geofence, and the *duration* of the geofence.

## -parameters
### -param id
The Id of the geofence.

### -param geoshape
The area that defines the geofence to monitor.

### -param monitoredStates
The states to monitor the geofence for.

### -param singleUse
True indicates the geofence should be monitored only for one use. False indicates the geofence should be monitored for multiple uses.

### -param dwellTime
The time that a position has to be in or out of the geofence in order for the notification to be triggered.This object must represent a positive value.

### -param startTime
The time to start monitoring the geofence.

### -param duration
The duration of time to monitor the geofence for. The duration begins at the *startTime*. This object must represent a positive value.

## -remarks
You must specify the **Entered** or **Exited** states, or both, for a geofence to be monitored. It is not possible to create a geofence that only monitors the **Removed** state.

The *id* value must be non-null and less than 64 characters.

The *geoshape* parameter must be a non-null [Geocircle](../windows.devices.geolocation/geocircle.md) with a [SpatialReferenceId](../windows.devices.geolocation/igeoshape_spatialreferenceid.md) that matches the platform or an exception will be thrown.

If the expiration date for the geofence - which is the start time plus the duration time span - occurs sooner than the creation time plus the dwell time value, an exception will be thrown.

## -examples

## -see-also
[Geofencing, start to finish](/previous-versions/windows/apps/dn263199(v=win.10)), [Geofence(String, IGeoshape)](geofence_geofence_161909132.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean)](geofence_geofence_1541426940.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan)](geofence_geofence_247731772.md)
## -capabilities
location
