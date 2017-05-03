---
-api-id: T:Windows.Perception.Spatial.SpatialLocatability
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Perception.Spatial.SpatialLocatability : int
-->

# SpatialLocatability

## -description
Indicates the lifecycle state of the device's spatial location system. This lets an app know whether it can reason about the device's orientation or its position in the user's surroundings.

## -enum-fields
### -field Unavailable:0
The device's spatial location system is not available.

### -field OrientationOnly:1
The device is reporting its orientation, and has not been asked to report its position in the user's surroundings.

### -field PositionalTrackingActivating:2
The device is reporting its orientation, and is preparing to locate its position in the user's surroundings.

### -field PositionalTrackingActive:3
The device is reporting its orientation and position in the user's surroundings.

### -field PositionalTrackingInhibited:4
The device is reporting its orientation, but cannot locate its position in the user's surroundings due to external factors, like lighting conditions.


## -remarks

## -examples

## -see-also