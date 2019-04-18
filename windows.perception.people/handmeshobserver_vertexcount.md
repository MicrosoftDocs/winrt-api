---
-api-id: P:Windows.Perception.People.HandMeshObserver.VertexCount
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public uint VertexCount { get; }
-->

# Windows.Perception.People.HandMeshObserver.VertexCount

## -description
Gets the count of vertices for this hand.

## -property-value
The count of vertices for this hand.

## -remarks
This count tells your app how many elements to allocate in the vertex buffer you'll fill using [GetVertices](handmeshvertexstate_getvertices_574524283.md) each frame after you call [GetVertexStateForPose](handmeshobserver_getvertexstateforpose_1608128188.md).

The hand mesh's vertex buffer data will change each frame, while the vertex count will not.  You can therefore refill the same vertex buffer every frame.

## -see-also

## -examples

