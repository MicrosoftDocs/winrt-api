---
-api-id: E:Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.ObservedSurfacesChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ObservedSurfacesChanged<Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver,  object>
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver.ObservedSurfacesChanged

## -description
Occurs when the set of surface metadata observed within the bounding volume has changed.

## -remarks
When this event fires, call [GetObservedSurfaces](spatialsurfaceobserver_getobservedsurfaces_672856049.md) to get the latest set of surface metadata. Note that if no bounding volume has been set, the metadata set will be empty.

## -examples

## -see-also

## -capabilities
spatialPerception
