---
-api-id: N:Windows.Devices.Geolocation.Geofencing
-api-type: winrt namespace
---

# Windows.Devices.Geolocation.Geofencing

## -description

A geofence is a virtual area around a geographical point. The geofencing APIs enable applications to provide geographically contextual experiences in a timely manner without the need for the app to be continuously running and consuming device resources. Geofencing enables scenarios like popping up a reminder for a user when they are leaving work or home or displaying coupons when the user gets within range of a store.

Apps define areas of interest (geofences) and corresponding trigger conditions, such as triggering when the user enters or exits the geofence. Finally, the app registers to be notified when the trigger conditions are met. Windows and Windows Phone support hundreds of geofences per app. The operating system efficiently manages geofence tracking for all apps. When the trigger conditions for one or more geofences are met, the associated app is alerted even when it is not actively running. This high capacity, power-aware, adaptive geofence tracking system allows you to quickly and easily add location-triggered functionality to your app.

For a complete guide on using geofencing, see [Geofencing, start to finish](/previous-versions/windows/apps/dn263199(v=win.10)).

The geofencing APIs enable your app to do the following:

+ Create one or more geofences, or areas of interest.
+ Request to be notified when the device enters a geofence.
+ Request to be notified when the device leaves a geofence.
+ Specify a time window during which the geofence is active.
+ Specify a dwell time for each geofence - the amount of time that the device should be in or out of the geofence before the notification is triggered.
+ Dynamically add and remove a geofences from your app's collection of monitored geofences.
+ Receive geofence events while the app is active.
+ Register with the system to have a background task launch when the state of one of your app's geofences changes. Apps must call [RequestAccessAsync](../windows.applicationmodel.background/backgroundexecutionmanager_requestaccessasync_1328635663.md) before any background tasks will run.
+ Use simulator to simulate device movement and test your app's geofencing features.

If you want your app to be launched in the background when the trigger condition for one of its geofences is met, you need to use a background task and set up a [LocationTrigger](../windows.applicationmodel.background/locationtrigger.md) to launch it.

> [!IMPORTANT]
> Starting in Windows 10, call the [Geolocator](../windows.devices.geolocation/geolocator.md) object's [RequestAccessAsync](../windows.devices.geolocation/geolocator_requestaccessasync_380675631.md) method before accessing the user’s location. At that time, your app must be in the foreground and [RequestAccessAsync](../windows.devices.geolocation/geolocator_requestaccessasync_380675631.md) must be called from the UI thread. Until the user grants your app permission to access their location, your app can't access location data.

## -remarks

Location services must be running in order for geofencing to work. If this service is disabled, geofencing calls will fail and throw an exception.

Your app must declare the location capability in the app manifest in order to use geofencing.

## -examples

## -see-also

[Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [Geofence](geofence.md), [GeofenceMonitor](geofencemonitor.md), Windows.Devices.Geolocation, [Geolocation sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities

location
