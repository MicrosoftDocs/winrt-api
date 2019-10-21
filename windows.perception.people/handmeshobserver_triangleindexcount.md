---
-api-id: P:Windows.Perception.People.HandMeshObserver.TriangleIndexCount
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public uint TriangleIndexCount { get; }
-->

# Windows.Perception.People.HandMeshObserver.TriangleIndexCount

## -description
Gets the number of elements in the index buffer for this hand mesh model.

## -property-value
The index buffer size.

## -remarks
This count tells you how many elements to allocate in the index buffer you'll fill using [GetTriangleIndices](handmeshobserver_gettriangleindices_2079708971.md).

The hand mesh's index buffer will not change for the lifetime of the [HandMeshObserver](handmeshobserver.md).

## -see-also

## -examples

