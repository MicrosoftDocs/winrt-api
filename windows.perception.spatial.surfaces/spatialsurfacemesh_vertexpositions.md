---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexPositions
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshBuffer VertexPositions { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexPositions

## -description
Gets the buffer object representing the mesh's vertex buffer.

## -property-value
The mesh buffer.

## -remarks
Note that to get correct vertex positions, coordinates must be scaled according to the VertexPositionScale property. If you are otherwise transforming these coordinates to another coordinate system before using them anyway, you can make a scale matrix from the VertexPositionScale vector and include that as the first matrix in your transform chain.

If [SpatialSurfaceMeshOptions.VertexPositionFormat](spatialsurfacemeshoptions_vertexpositionformat.md) is set as an option in the call to [SpatialSurfaceInfo.TryComputeLatestMeshAsync](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md), this buffer will be generated in the format indicated.

## -examples

## -see-also
