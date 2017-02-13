---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.SetBoundingVolume(Windows.Perception.Spatial.SpatialBoundingVolume)
-api-type: winrt method
---

<!-- Method syntax
public void SetBoundingVolume(Windows.Perception.Spatial.SpatialBoundingVolume bounds)
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.SetBoundingVolume

## -description
Sets the single bounding volume that this observer will track for new, updated or removed surfaces.

## -parameters
### -param bounds
The new bounding volume for this observer to track for surface updates.

## -remarks
When the set of surface metadata within this bounding volume changes, the ObservedSurfacesChanged event will fire.

## -examples

## -see-also
