---
-api-id: T:Windows.Perception.People.HandMeshVertex
-api-type: winrt struct
ms.custom: 19H1
---

<!-- Structure syntax.
public struct HandMeshVertex  {
	public Vector3 Normal 
	public Vector3 Position 
}
-->

# Windows.Perception.People.HandMeshVertex

## -description
Represents an individual vertex in a hand mesh vertex buffer.

## -struct-fields

### -field Position
The position of the vertex.

### -field Normal
The normal of the vertex.

## -remarks
This vertex position and normal is expressed relative to the coordinate system returned by the [HandMeshVertexState](handmeshvertexstate.md) object's [CoordinateSystem](handmeshvertexstate_coordinatesystem.md) property.  Each frame, you must always get the new vertices and then locate their new coordinate system to accurately position the hand mesh in the world.

## -see-also

## -examples

