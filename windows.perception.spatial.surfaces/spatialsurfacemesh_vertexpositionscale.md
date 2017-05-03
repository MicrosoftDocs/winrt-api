---
-api-id: P:Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexPositionScale
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 VertexPositionScale { get; }
-->

# Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh.VertexPositionScale

## -description
Gets the scale vector that you must use to scale the elements of [VertexPositions](spatialsurfacemesh_vertexpositions.md).

## -property-value
The mesh buffer.

## -remarks
This gets you mesh coordinates in meters in the mesh's specified coordinate system.

If you are otherwise transforming these coordinates to another coordinate system before using them anyway, you can make a scale matrix from the VertexPositionScale vector and include that as the first matrix in your transform chain.

## -examples

## -see-also
