---
-api-id: M:Windows.Perception.People.HandMeshObserver.GetTriangleIndices(System.UInt16[])
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void HandMeshObserver.GetTriangleIndices(UInt16[] indices)
-->

# Windows.Perception.People.HandMeshObserver.GetTriangleIndices

## -description
Fills an index buffer for this hand mesh model.

## -parameters
### -param indices
The index buffer to fill.

## -remarks
Get [TriangleIndexCount](handmeshobserver_triangleindexcount.md) first to know how many elements to allocate in the index buffer you pass in here.

The hand mesh's index buffer will not change for the lifetime of the [HandMeshObserver](handmeshobserver.md).

## -see-also

## -examples

