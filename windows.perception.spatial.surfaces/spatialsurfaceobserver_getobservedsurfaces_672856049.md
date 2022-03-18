---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.GetObservedSurfaces
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IMapView<System.Guid, Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo> GetObservedSurfaces()
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.GetObservedSurfaces

## -description
Gets metadata for the set of surfaces observed within the bounding volume at the moment.

## -returns
The observed surfaces within the bounding volume. If no bounding volume has been set, no surfaces will be returned.

## -remarks
Each [SpatialSurfaceInfo](spatialsurfaceinfo.md) snapshot is immutable, so you can compare their values later to see if a given surface has recently experienced a mesh update.

Correlating the [Id](spatialsurfaceinfo_id.md) and [UpdateTime](spatialsurfaceinfo_updatetime.md) properties across multiple observations lets you identify new mesh, updated mesh and removed mesh:
* If you see a SpatialSurfaceInfo with an Id you haven't seen before, treat it as new mesh.
* If you see a SpatialSurfaceInfo with a known Id, but with a new UpdateTime, treat it as updated mesh.
* If you no longer see a SpatialSurfaceInfo with a known Id, treat it as removed mesh.

## -examples

## -see-also

## -capabilities
spatialPerception
