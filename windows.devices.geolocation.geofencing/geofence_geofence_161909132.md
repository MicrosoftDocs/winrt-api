---
-api-id: M:Windows.Devices.Geolocation.Geofencing.Geofence.#ctor(System.String,Windows.Devices.Geolocation.IGeoshape)
-api-type: winrt method
---

<!-- Method syntax
public Geofence(System.String id, Windows.Devices.Geolocation.IGeoshape geoshape)
-->

# Windows.Devices.Geolocation.Geofencing.Geofence.Geofence

## -description
Initializes a new [Geofence](geofence.md) object given the *id* and the shape of the geofence.

## -parameters
### -param id
The Id of the geofence.

### -param geoshape
The area that defines the geofence to monitor.

## -remarks
When this constructor is used, the [MonitoredStates](geofence_monitoredstates.md) will default to monitor for both the **Entered** and **Exited** states, [SingleUse](geofence_singleuse.md) will default to false, the [DwellTime](geofence_dwelltime.md) will default to 10 seconds, the [StartTime](geofence_starttime.md) will default to 0 meaning start immediately, and the [Duration](geofence_duration.md) will default to 0, meaning forever.

The *id* value must be non-null and less than 64 characters.

The *geoshape* parameter must be a non-null [Geocircle](../windows.devices.geolocation/geocircle.md) with a [SpatialReferenceId](../windows.devices.geolocation/igeoshape_spatialreferenceid.md) that matches the platform or an exception will be thrown.

## -examples

## -see-also
[Geofencing, start to finish](/previous-versions/windows/apps/dn263199(v=win.10)), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean)](geofence_geofence_1541426940.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan)](geofence_geofence_247731772.md), [Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan, DateTime, TimeSpan)](geofence_geofence_1118020828.md)
## -capabilities
location
