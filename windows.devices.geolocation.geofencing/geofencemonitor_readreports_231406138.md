---
-api-id: M:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.ReadReports
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport> ReadReports()
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.ReadReports

## -description
Gets a collection of status changes to the [Geofence](geofence.md) objects in the [Geofences](geofencemonitor_geofences.md) collection of the [GeofenceMonitor](geofencemonitor.md).

## -returns
collection of status changes to the [Geofence](geofence.md) object(s) in [GeofenceMonitor](geofencemonitor.md).

## -remarks
Each report in the collection contains the most recent state for the geofences that changed state since the last time **ReadReports** was called. Older state changes may be present in the collection if **ReadReports** hasn't been called over a period of time when many geofence state changes have occurred, but the system may purge these older state changes.

The collection returned from this method may be empty and contain no [GeofenceStateChangeReport](geofencestatechangereport.md) objects. This can happen if no status changes have occurred since the last time the method was called, either by the app or the background task.

## -examples

## -see-also
[Geofence](geofence.md)
## -capabilities
location
