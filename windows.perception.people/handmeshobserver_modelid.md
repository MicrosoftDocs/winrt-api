---
-api-id: P:Windows.Perception.People.HandMeshObserver.ModelId
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public int ModelId { get; }
-->

# Windows.Perception.People.HandMeshObserver.ModelId

## -description
Gets a hand mesh model ID to identify the same index buffer across multiple source detection and loss events.

## -property-value
The hand mesh model ID.

## -remarks
If your app observes the same hand mesh model ID again for a new interaction source, it can render using the previous source's already-loaded index buffer without transferring it to the GPU again.

## -see-also

## -examples

