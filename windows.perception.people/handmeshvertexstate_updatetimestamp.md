---
-api-id: P:Windows.Perception.People.HandMeshVertexState.UpdateTimestamp
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public PerceptionTimestamp UpdateTimestamp { get; }
-->

# Windows.Perception.People.HandMeshVertexState.UpdateTimestamp

## -description
Gets the timestamp at which the vertex positions and normals were last updated.

## -property-value
The update timestamp.

## -remarks
The vertex positions and normals will generally be updated each frame.  However, if the **UpdateTimestamp** remains the same across two frames, you can skip ingesting the vertex buffer, as it also remains the same.  Note that you should still get the latest [CoordinateSystem](handmeshvertexstate_coordinatesystem.md) value every frame even if the vertex buffer hasn't changed, to best reposition the old mesh for the hand's new location this frame.

## -see-also

## -examples

