---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexNormals
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshBuffer VertexNormals { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexNormals

## -description
Gets the buffer object representing the mesh's normal buffer, if IncludeVertexNormals was set as a mesh option in the call to [SpatialSurfaceInfo.TryComputeLatestMeshAsync](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md). Otherwise, this property is null.

## -property-value
The mesh buffer if available; otherwise null.

## -remarks
If the [SpatialSurfaceMeshOptions.VertexNormalFormat](spatialsurfacemeshoptions_vertexnormalformat.md) option is also set, this buffer will be generated in the format indicated.

## -examples

## -see-also
