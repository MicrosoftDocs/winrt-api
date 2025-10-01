---
-api-id: N:Windows.Devices.Geolocation.Geofencing
-api-type: winrt namespace
---

# Windows.Devices.Geolocation.Geofencing

## -description

A geofence is a virtual area around a geographical point. The geofencing APIs enable applications to deliver
contextual experiences without keeping the app running continuously or consuming unnecessary device resources.
Typical scenarios include reminding a user when they leave work, or surfacing offers when they approach a store.

Apps define areas of interest (geofences) and the trigger conditions, such as entering or exiting a boundary, then
register to receive notifications when those conditions are satisfied. Windows supports hundreds of geofences per app
and manages tracking efficiently for every process. When geofence triggers are met, the system notifies the owning app
even if it is not active. This adaptive, power-aware pipeline lets you add location-triggered functionality quickly.

For a complete guide on using geofencing, see [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence).

The geofencing APIs enable your app to:

### Monitoring and notification scenarios
- Request notifications when the device enters a geofence.
- Request notifications when the device leaves a geofence.
- Specify a time window during which the geofence is active.
- Define a dwell time that must elapse before a notification fires.

### Management and testing capabilities
- Create, add, and remove geofences from the monitored collection.
- Receive geofence events while the app is active and process them in the foreground.
- Launch a background task when geofence states change (call [RequestAccessAsync](../windows.applicationmodel.background/backgroundexecutionmanager_requestaccessasync_1328635663.md) before registering the task).
- Simulate device movement by using the simulator to validate geofencing features.

If you want your app to be launched in the background when the trigger condition for one of its geofences is met,
set up a background task and configure a [LocationTrigger](../windows.applicationmodel.background/locationtrigger.md)
to launch it.

> [!IMPORTANT]
> Starting in Windows 10, call the [Geolocator](../windows.devices.geolocation/geolocator.md) object's [RequestAccessAsync](../windows.devices.geolocation/geolocator_requestaccessasync_380675631.md) method before accessing the user's location. At that time, your app must be in the foreground and [RequestAccessAsync](../windows.devices.geolocation/geolocator_requestaccessasync_380675631.md) must be called from the UI thread. Until the user grants your app permission to access their location, your app can't access location data.

## -remarks

Location services must be running for geofencing to work. If this service is disabled, geofencing calls fail and throw
an exception.

Your app must declare the location capability in the app manifest in order to use geofencing.

## -examples

## -see-also

[Geofence](geofence.md),
[GeofenceMonitor](geofencemonitor.md),
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Get current location](/windows/uwp/maps-and-location/get-location),
[Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence),
[Windows.Devices.Geolocation](../windows.devices.geolocation/windows_devices_geolocation.md)

## -capabilities

location
