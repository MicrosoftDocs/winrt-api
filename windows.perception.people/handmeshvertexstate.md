---
-api-id: T:Windows.Perception.People.HandMeshVertexState
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HandMeshVertexState 
-->

# Windows.Perception.People.HandMeshVertexState

## -description
Represents the vertex buffer and other state needed to render the hand mesh.

## -remarks
This state update's vertex positions and normals filled by [GetVertices](handmeshvertexstate_getvertices_574524283.md) are expressed relative to the [CoordinateSystem](handmeshvertexstate_coordinatesystem.md) property.  Each frame, you must always get the new vertices and then locate their new coordinate system to accurately position the vertices in the world.

## -see-also

## -examples

