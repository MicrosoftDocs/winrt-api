---
-api-id: P:Windows.Devices.Geolocation.Geolocator.ReportInterval
-api-type: winrt property
---

<!-- Property syntax
public System.UInt32 ReportInterval { get;  set; }
-->

# Windows.Devices.Geolocation.Geolocator.ReportInterval

## -description
The requested minimum time interval between location updates, in milliseconds. If your application requires updates
infrequently, set this value so that location services can conserve power by calculating location only when needed.

## -property-value
The requested minimum time interval between location updates, in milliseconds.

## -remarks
> [!IMPORTANT]
> The value of `ReportInterval` must be greater than or equal to 1. Passing 0 is not supported, and is treated as
> not set. While any value ≥ 1 is accepted, the system enforces a practical minimum of 1000 milliseconds (1 second)
> for location updates.

> [!NOTE]
> The default report interval is 1 second or as frequent as the hardware can support, whichever is shorter. Location
> updates can be set to a different frequency if you specify a [MovementThreshold](geolocator_movementthreshold.md) or
> set `ReportInterval` to a different value. If your app sets both [MovementThreshold](geolocator_movementthreshold.md)
> and `ReportInterval`, location will be updated according to [MovementThreshold](geolocator_movementthreshold.md).

If another application has requested more frequent updates, by specifying a smaller value for `ReportInterval`, your
application may receive updates at a higher frequency than requested.

## -examples

## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence)

## -capabilities
location
