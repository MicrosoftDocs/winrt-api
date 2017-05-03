---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions.SupportedTriangleIndexFormats
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Graphics.DirectX.DirectXPixelFormat> SupportedTriangleIndexFormats { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions.SupportedTriangleIndexFormats

## -description
Gets a list of the triangle index formats that the system can generate an index buffer in.

## -property-value
The supported index buffer formats.

## -remarks
Supply a value from this list to the [TriangleIndexFormat](spatialsurfacemeshoptions_triangleindexformat.md) property when calling [SpatialSurfaceInfo.TryComputeLatestMeshAsync](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md) to request index buffers in that format.

## -examples

## -see-also
