---
-api-id: P:Windows.Perception.People.HandMeshObserver.NeutralPoseVersion
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public int NeutralPoseVersion { get; }
-->

# Windows.Perception.People.HandMeshObserver.NeutralPoseVersion

## -description
Gets the version of the [NeutralPose](handmeshobserver_neutralpose.md) for this hand.

## -property-value
The neutral hand pose version.

## -remarks
The hand mesh's [NeutralPose](handmeshobserver_neutralpose.md) is fairly stable, but will evolve over time as the system's estimate of the user's hand shape is updated.  You can detect when the neutral pose updates by observing a change in the **NeutralPoseVersion**.  When there is a neutral pose update, you may wish to repeat some or all of the static analysis you performed on the mesh.

## -see-also

## -examples

