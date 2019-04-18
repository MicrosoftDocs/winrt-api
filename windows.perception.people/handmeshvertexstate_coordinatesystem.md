---
-api-id: P:Windows.Perception.People.HandMeshVertexState.CoordinateSystem
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public SpatialCoordinateSystem CoordinateSystem { get; }
-->

# Windows.Perception.People.HandMeshVertexState.CoordinateSystem

## -description
Gets the coordinate system within which this frame's vertex positions and normals are expressed.

## -property-value
The coordinate system.

## -remarks
The vertex positions and normals filled by [GetVertices](handmeshvertexstate_getvertices_574524283.md) are expressed relative to the coordinate system returned by this state object's **CoordinateSystem** property.  Each frame, you must always get the new vertices and then locate their new coordinate system to accurately position the hand mesh in the world.

## -see-also

## -examples

