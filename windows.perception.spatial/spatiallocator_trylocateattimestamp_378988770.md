---
-api-id: M:Windows.Perception.Spatial.SpatialLocator.TryLocateAtTimestamp(Windows.Perception.PerceptionTimestamp,Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialLocation TryLocateAtTimestamp(Windows.Perception.PerceptionTimestamp timestamp, Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Perception.Spatial.SpatialLocator.TryLocateAtTimestamp

## -description
Returns a SpatialLocation representing the device's location at the specified timestamp. The coordinates within are expressed relative to the supplied coordinate system. If the device cannot be located in that coordinate system at the specified timestamp, the return value will be null. This can happen when the device has lost tracking, for example.

## -parameters
### -param timestamp
The timestamp at which to locate the device.

### -param coordinateSystem
The coordinate system in which to express the location's coordinates.

## -returns
The location.

## -remarks

## -examples

## -see-also
