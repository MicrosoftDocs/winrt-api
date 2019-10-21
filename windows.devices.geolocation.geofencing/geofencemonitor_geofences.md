---
-api-id: P:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.Geofences
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Devices.Geolocation.Geofencing.Geofence> Geofences { get; }
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.Geofences

## -description
Returns a vector of the app's [Geofence](geofence.md) objects currently registered with the system-wide [GeofenceMonitor](geofencemonitor.md).

## -property-value
A collection of the [Geofence](geofence.md) objects to monitor.

## -remarks
Register a [Geofence](geofence.md) to be monitored by the system by adding it to this collection.

Geofences are persisted to disk, so they only need to be added to the system once. Attempting to add a [Geofence](geofence.md) with an [Id](geofence_id.md) that is already registered will throw an exception.

Attempting to remove a [Geofence](geofence.md) from the Geofences property will fail with an exception if the specified [Geofence](geofence.md) is registered with the system but does not belong to the calling application's collection.

This vector reflects only updates made by the app. To view changes made by the system, as in after a single-use [Geofence](geofence.md) is triggered and removed, the app can call this property again or safely remove the removed [Geofence](geofence.md) from a previously returned vector.

## -examples

## -see-also
[Geofence](geofence.md)
## -capabilities
location
