---
-api-id: E:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.GeofenceStateChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler GeofenceStateChanged<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,  object>
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.GeofenceStateChanged

## -description
Raised when the state of one or more [Geofence](geofence.md) objects in the [Geofences](geofencemonitor_geofences.md) collection of the [GeofenceMonitor](geofencemonitor.md) has changed

## -remarks
This event is raised when your app is running and the state of a geofence registered by your app changes. This event is also raised when your app activates if there are unread reports in the collection obtained by calling [ReadReports](geofencemonitor_readreports.md). This allows an app that is coming back from being suspended to be notified that there are unread reports in the queue and update the UI accordingly. This also allows your app to read reports that occurred in the background in cases where your background task was not launched to due to conditions set with [SystemCondition](../windows.applicationmodel.background/systemcondition.md), such as waiting for an internet connection or waiting for the user to be present.

## -examples

## -see-also
[Geofence](geofence.md)
## -capabilities
location
