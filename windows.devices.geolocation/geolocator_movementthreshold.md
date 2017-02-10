---
-api-id: P:Windows.Devices.Geolocation.Geolocator.MovementThreshold
-api-type: winrt property
---

<!-- Property syntax
public double MovementThreshold { get;  set; }
-->

# Windows.Devices.Geolocation.Geolocator.MovementThreshold

## -description
The distance of movement, in meters, relative to the coordinate from the last [PositionChanged](geolocator_positionchanged.md) event, that is required for the [Geolocator](geolocator.md) to raise a [PositionChanged](geolocator_positionchanged.md) event.

## -property-value
The distance of required movement, in meters, for location services to raise a [PositionChanged](geolocator_positionchanged.md) event. The default value is 0.

## -remarks
The default report interval is 1 second or as frequent as the hardware can support – whichever is shorter. Location updates can be set to a different frequency if you specify a [MovementThreshold](geolocator_movementthreshold.md) or set [ReportInterval](geolocator_reportinterval.md) to a different value. If your app sets both [MovementThreshold](geolocator_movementthreshold.md) and [ReportInterval](geolocator_reportinterval.md), location will be updated according to [MovementThreshold](geolocator_movementthreshold.md).

## -examples

## -see-also
[Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [Set up a geofence](http://msdn.microsoft.com/library/a3a46e03-0751-4dbd-a2a1-2323db09bdba)

## -capabilities
location, ID_CAP_LOCATION [Windows Phone]