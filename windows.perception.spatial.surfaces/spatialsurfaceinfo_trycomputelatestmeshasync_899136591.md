---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryComputeLatestMeshAsync(System.Double,Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh> TryComputeLatestMeshAsync(System.Double maxTrianglesPerCubicMeter, Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions options)
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryComputeLatestMeshAsync

## -description
Generates a mesh object and its vertex and index buffers for this surface, with the specified mesh generation options. This chooses the most detailed mesh that does not exceed the specified triangle density, in triangles per cubic meter.

## -parameters
### -param maxTrianglesPerCubicMeter
The maximum triangle density that the app can accept, in triangles per cubic meter.

### -param options
The mesh generation options.

## -returns
The operation that triggers once the mesh is ready.

## -remarks

## -examples

## -see-also
[TryComputeLatestMeshAsync(Double)](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md)