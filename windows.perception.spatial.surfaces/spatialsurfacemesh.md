---
-api-id: T:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialSurfaceMesh : Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMesh
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh

## -description
Represents the mesh data for a surface observed in the user's surroundings.

## -remarks
The SpatialSurfaceMesh class contains all of the information you need to render the mesh or process it for physics, including its vertex, index and normal buffers.

Because this object keeps its buffers alive, you should be sure to delete it or release references to it when you either no longer need the mesh or have already transformed it into a different processed form that you are caching instead.

## -examples

## -see-also
