---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryGetBounds(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Perception.Spatial.SpatialBoundingOrientedBox> TryGetBounds(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryGetBounds

## -description
Gets the bounds of this surface, expressed in the specified coordinate system.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the bounds.

## -returns
The bounds.

## -remarks
Because this is a snapshot, the bounds returned will not change over time.

This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
