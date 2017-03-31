---
-api-id: M:Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryComputeLatestMeshAsync(System.Double)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh> TryComputeLatestMeshAsync(System.Double maxTrianglesPerCubicMeter)
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo.TryComputeLatestMeshAsync

## -description
Generates a mesh object and its vertex and index buffers for this surface. This chooses the most detailed mesh that does not exceed the specified triangle density, in triangles per cubic meter.

## -parameters
### -param maxTrianglesPerCubicMeter
The maximum triangle density that the app can accept, in triangles per cubic meter.

## -returns
The operation that triggers once the mesh is ready.

## -remarks
Note that this method does not retrieve the specific mesh that was most current as of the UpdateTime property. Instead, the system's latest mesh data for this surface Id is always returned.

This method may return null if the mesh now contains no triangles or if the surface has since been removed.

## -examples

## -see-also
[TryComputeLatestMeshAsync(Double, SpatialSurfaceMeshOptions)](spatialsurfaceinfo_trycomputelatestmeshasync_899136591.md)