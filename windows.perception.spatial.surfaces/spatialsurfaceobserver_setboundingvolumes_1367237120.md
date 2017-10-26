---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.SetBoundingVolumes(Windows.Foundation.Collections.IIterable{Windows.Perception.Spatial.SpatialBoundingVolume})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetBoundingVolumes(Windows.Foundation.Collections.IIterable<Windows.Perception.Spatial.SpatialBoundingVolume> bounds)
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.SetBoundingVolumes

## -description
Sets the list of bounding volumes that this observer will track for new, updated or removed surfaces.

## -parameters
### -param bounds
The bounding volumes.

## -remarks
When the set of surface metadata within these bounding volumes changes, the [ObservedSurfacesChanged](spatialsurfaceobserver_observedsurfaceschanged.md) event will fire.

## -examples

## -see-also

## -capabilities
spatialPerception
