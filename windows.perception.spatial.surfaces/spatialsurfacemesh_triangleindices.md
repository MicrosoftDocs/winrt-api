---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.TriangleIndices
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshBuffer TriangleIndices { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.TriangleIndices

## -description
Gets the buffer object representing the mesh's index buffer.

## -property-value
The mesh buffer.

## -remarks
If [SpatialSurfaceMeshOptions.TriangleIndexFormat](spatialsurfacemeshoptions_triangleindexformat.md) is set as an option in the call to [SpatialSurfaceInfo.TryComputeLatestMeshAsync](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md), this buffer will be generated in the format indicated.

## -examples

## -see-also
