---
-api-id: M:Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference.GetStationaryCoordinateSystemAtTimestamp(Windows.Perception.PerceptionTimestamp)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialCoordinateSystem GetStationaryCoordinateSystemAtTimestamp(Windows.Perception.PerceptionTimestamp timestamp)
-->

# Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference.GetStationaryCoordinateSystemAtTimestamp

## -description
Gets a coordinate system whose origin is the position of the device at the specified timestamp, oriented at this frame of reference's fixed heading. This coordinate system stays stationary and does not track any further movement of the device.

## -parameters
### -param timestamp
The timestamp to compute the coordinate system for.

## -returns
The coordinate system that corresponds with the timestamp.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

## -examples

## -see-also
