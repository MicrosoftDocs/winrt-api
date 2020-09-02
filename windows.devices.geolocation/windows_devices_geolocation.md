---
-api-id: N:Windows.Devices.Geolocation
-api-type: winrt namespace
---

# Windows.Devices.Geolocation

## -description

Provides APIs for [getting the current location](/windows/uwp/maps-and-location/get-location) or tracking the device's location over time. Location information may come from estimating a position from beacons like Wi-Fi access points and cell towers, from the device's IP address, or it may come from other sources such as a GNSS or GPS device. The Windows.Devices.Geolocation API provides the most appropriate geolocation data from all available sources.

The accuracy of the location information depends on the source. The latitude and longitude may vary within the following ranges:

+ **GPS :** within approximately 10 meters
+ **Wi-Fi :** between approximately 30 meters and 500 meters
+ **Cell towers :** between approximately 300 meters and 3,000 meters
+ **IP address :** between approximately 1,000 meters and 5,000 meters

In addition to latitude and longitude, GPS also provides information about heading, speed, and altitude. This additional information is optional when the location information comes from other sources.

The user sets the privacy of their location data with the **location privacy settings** in the **Settings** app. Your app can access the user's location only when:

+ **Location for this device...** is turned **on** (not applicable to Windows 10 Mobile)
+ The location services setting, **Location**, is turned **on**
+ Under **Choose apps that can use your location**, your app is set to **on**

For more information about location privacy, see the [Windows Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement).

> [!IMPORTANT]
> Starting in Windows 10, call the [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) before accessing the user’s location. At that time, your app must be in the foreground and RequestAccessAsync must be called from the UI thread. Until the user grants your app permission to their location, your app can't access location data.

**Location services architecture**

The first layer of the location services architecture consists of hardware in the device. This includes the GPS receiver, Wi-Fi, and the cellular radio. These can all function as providers of location data with varying levels of accuracy and power consumption. On top of the hardware sits the native code layer. This layer communicates directly with the available sources of location data and decides which sources to use to determine the location of the device based on the availability of data and on the performance requirements specified by the application. The native code layer also communicates over the Internet with a Microsoft-hosted web service to look up location-related information from a database. The top layer of the location service is the managed interface, exposed through a DLL that is included with Windows SDK. An app uses this interface to start and stop location requests, to set the level of accuracy required by the app, and to receive location data from the native code layer as it becomes available.

## -remarks

## -examples

Sample applications that use classes from this namespace include the [Geolocation sample](/samples/microsoft/windows-universal-samples/geolocation/) and the [Geotag sample](/samples/microsoft/windows-universal-samples/geotag/).

## -see-also

[Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [Geolocation sample](/samples/microsoft/windows-universal-samples/geolocation/), [Geotag sample](/samples/microsoft/windows-universal-samples/geotag/)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
