---
-api-id: P:Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport.RemovalReason
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Geolocation.Geofencing.GeofenceRemovalReason RemovalReason { get; }
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport.RemovalReason

## -description
Indicates the reason a [Geofence](geofence.md) was removed.

## -property-value
Indicates the reason a geofence was removed.

## -remarks
This property defaults to a value of **Used**. You should ignore this property unless the Geofence has changed state to being **Removed**.

Removal event notifications can happen when the app is in the foreground or the background. However, removal events themselves do not fire the trigger when the app is in the background. This means that background apps cannot use the removal event to wake up the app. When an app comes back from being in the background, it can see the removal event that occurred waiting in the [GeofenceStateChangeReports.](geofencestatechangereport.md)

## -examples

## -see-also
[GeofenceMonitor](geofencemonitor.md), [Geofence](geofence.md)
## -capabilities
location
