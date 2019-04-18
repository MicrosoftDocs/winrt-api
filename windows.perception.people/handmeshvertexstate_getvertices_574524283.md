---
-api-id: M:Windows.Perception.People.HandMeshVertexState.GetVertices(Windows.Perception.People.HandMeshVertex[])
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void HandMeshVertexState.GetVertices(HandMeshVertex[] vertices)
-->

# Windows.Perception.People.HandMeshVertexState.GetVertices

## -description
Fills a vertex buffer for this hand mesh model.

## -parameters
### -param vertices
The vertex buffer to fill.

## -remarks
Get [VertexCount](handmeshobserver_vertexcount.md) first to know how many elements to allocate in the vertex buffer you pass in here.

The filled vertex positions and normals are expressed relative to the coordinate system returned by this state object's [CoordinateSystem](handmeshvertexstate_coordinatesystem.md) property.  Each frame, you must always get the new vertices and then locate their new coordinate system to accurately position the hand mesh in the world.

The hand mesh's vertex buffer data will change each frame, while the vertex count will not.  You can therefore refill the same vertex buffer every frame.

## -see-also

## -examples

