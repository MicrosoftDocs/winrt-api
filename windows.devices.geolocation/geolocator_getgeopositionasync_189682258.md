---
-api-id: M:Windows.Devices.Geolocation.Geolocator.GetGeopositionAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Geolocation.Geoposition> GetGeopositionAsync()
-->

# Windows.Devices.Geolocation.Geolocator.GetGeopositionAsync

## -description
Starts an asynchronous operation to retrieve the current location of the device.

## -returns
An asynchronous operation that, upon completion, returns a [Geoposition](geoposition.md) marking the found location.

## -remarks
This method throws an exception if the app doesn't have location permissions or if it times out with no location data retrieved. Therefore, the method should be called within a try/catch statement so that these common exception cases can be handled.

This method times out after 60 seconds, except when in Connected Standby. During Connected Standby, [Geolocator](geolocator.md) objects can be instantiated but the [Geolocator](geolocator.md) object will not find any sensors to aggregate and calls to [GetGeopositionAsync](geolocator_getgeopositionasync_189682258.md) will time out after 7 seconds. Upon time out, the [StatusChanged](geolocator_statuschanged.md) event listeners will be called once with the **NoData** status, and the [PositionChanged](geolocator_positionchanged.md) event listeners will never be called.

The user sets the privacy of their location data with the **location privacy settings** in the **Settings** app. Your app can access the user's location only when:
+ **Location for this device...** is turned **on** (not applicable to Windows 10 Mobile)
+ The location services setting, **Location**, is turned **on**
+ Under **Choose apps that can use your location**, your app is set to **on**


> [!IMPORTANT]
> Starting in Windows 10, call the [RequestAccessAsync](geolocator_requestaccessasync_380675631.md) method before accessing the user’s location. At that time, your app must be in the foreground and **RequestAccessAsync** must be called from the UI thread. Your app can then handle the no-permissions case without throwing an exception.

## -examples

## -see-also
[Get current location](https://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Geoposition](geoposition.md), [Geocoordinate](geocoordinate.md), [GetGeopositionAsync(TimeSpan, TimeSpan)](geolocator_getgeopositionasync_726098746.md), [geolocation sample](https://go.microsoft.com/fwlink/p/?linkid=533278)

## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
