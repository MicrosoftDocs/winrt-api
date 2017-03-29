---
-api-id: T:Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialSurfaceObserver : Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserver
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver

## -description
Provides methods for observing surfaces in the user's surroundings.

## -remarks
Spatial mapping lets your app understand the shape and location of the surfaces in the user's surroundings.

Through the sensors on a device like HoloLens, Windows generates 3D triangle meshes of surfaces in large cube-shaped volumes. Over time, as Windows improves its understanding of your surroundings, new surface volumes are generated and existing volumes are updated with new mesh. Sometimes, surface volumes can be destroyed as well, when the system is running low on storage.

You access these surfaces by expressing interest in a volume of space, either a bounding box, bounding frustum, or bounding sphere. Windows updates you to let you know when the set of surfaces in that observed volume has changed, with each surface volume identified by an id and the time of its last update. By reasoning about changes to this set of observed surface metadata, you can detect new mesh, updated mesh, and removed mesh over time.

## -examples

## -see-also
