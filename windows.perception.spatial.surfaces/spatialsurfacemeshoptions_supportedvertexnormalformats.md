---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions.SupportedVertexNormalFormats
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Graphics.DirectX.DirectXPixelFormat> SupportedVertexNormalFormats { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions.SupportedVertexNormalFormats

## -description
Gets a list of the vertex normal formats that the system can generate a normal buffer in.

## -property-value
The supported normal buffer formats.

## -remarks
Supply a value from this list to the [VertexNormalFormat](spatialsurfacemeshoptions_vertexnormalformat.md) property when calling [SpatialSurfaceInfo.TryComputeLatestMeshAsync](spatialsurfaceinfo_trycomputelatestmeshasync_1431485667.md) to request normal buffers in that format.

## -examples

## -see-also
