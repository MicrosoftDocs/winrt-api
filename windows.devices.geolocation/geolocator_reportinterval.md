---
-api-id: P:Windows.Devices.Geolocation.Geolocator.ReportInterval
-api-type: winrt property
---

<!-- Property syntax
public uint ReportInterval { get;  set; }
-->

# Windows.Devices.Geolocation.Geolocator.ReportInterval

## -description
The requested minimum time interval between location updates, in milliseconds. If your application requires updates infrequently, set this value so that location services can conserve power by calculating location only when needed.

## -property-value
The requested minimum time interval between location updates.

## -remarks
The default report interval is 1 second or as frequent as the hardware can support – whichever is shorter. Location updates can be set to a different frequency if you specify a [MovementThreshold](geolocator_movementthreshold.md) or set [ReportInterval](geolocator_reportinterval.md) to a different value. If your app sets both [MovementThreshold](geolocator_movementthreshold.md) and [ReportInterval](geolocator_reportinterval.md), location will be updated according to [MovementThreshold](geolocator_movementthreshold.md).

If another application has requested more frequent updates, by specifying a smaller value for [ReportInterval](geolocator_reportinterval.md), your application may receive updates at a higher frequency than requested.

## -examples

## -see-also
[Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Set up a geofence](http://msdn.microsoft.com/library/a3a46e03-0751-4dbd-a2a1-2323db09bdba)

## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
