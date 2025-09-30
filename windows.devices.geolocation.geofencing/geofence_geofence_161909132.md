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
When this constructor is used, the [MonitoredStates](geofence_monitoredstates.md) property defaults to monitor both the `MonitoredGeofenceStates.Entered` and `MonitoredGeofenceStates.Exited` flags, [SingleUse](geofence_singleuse.md) defaults to false, [DwellTime](geofence_dwelltime.md) defaults to 10 seconds, [StartTime](geofence_starttime.md) defaults to 0 (meaning start immediately), and [Duration](geofence_duration.md) defaults to 0, meaning forever.

The *id* value must be non-null and less than 64 characters.

The *geoshape* parameter must be a non-null [Geocircle](../windows.devices.geolocation/geocircle.md) with a [SpatialReferenceId](../windows.devices.geolocation/igeoshape_spatialreferenceid.md) that matches the platform or an exception will be thrown.

## -examples

## -see-also
[Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean)](geofence_geofence_1541426940.md),
[Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan)](geofence_geofence_247731772.md),
[Geofence(String, IGeoshape, MonitoredGeofenceStates, Boolean, TimeSpan, DateTime, TimeSpan)](geofence_geofence_1118020828.md)
## -capabilities
location
