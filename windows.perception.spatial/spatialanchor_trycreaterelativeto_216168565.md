---
-api-id: M:Windows.Perception.Spatial.SpatialAnchor.TryCreateRelativeTo(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialAnchor TryCreateRelativeTo(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Perception.Spatial.SpatialAnchor.TryCreateRelativeTo

## -description
Creates an anchor at the origin of the specified coordinate system.

## -parameters
### -param coordinateSystem
The reference SpatialCoordinateSystem object.

## -returns
The new anchor, if the creation attempt is successful; otherwise, null.

## -remarks
This can return null if the system has reached its limit on spatial anchors. It may also return null if the specified coordinate system cannot be located this frame.

## -examples

## -see-also
[TryCreateRelativeTo(SpatialCoordinateSystem, Vector3)](spatialanchor_trycreaterelativeto_798844823.md), [TryCreateRelativeTo(SpatialCoordinateSystem, Vector3, Quaternion)](spatialanchor_trycreaterelativeto_1410942277.md)