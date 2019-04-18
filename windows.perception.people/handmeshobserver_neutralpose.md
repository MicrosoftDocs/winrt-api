---
-api-id: P:Windows.Perception.People.HandMeshObserver.NeutralPose
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public HandPose NeutralPose { get; }
-->

# Windows.Perception.People.HandMeshObserver.NeutralPose

## -description
Gets the current neutral [HandPose](handpose.md) for this hand.

## -property-value
The neutral hand pose.

## -remarks
Some hand mesh visualizations may require an initial analysis or processing of the hand mesh relative to the joints of the hand.  For example, a visualization may pre-generate a UV mapping for the hand mesh vertices by raycasting outward from key joints against the mesh to find key vertices.

To avoid biasing such static analysis with the arbitrary hand pose detected in the first frame, you can request the hand's neutral hand pose (a relaxed open hand pose), and then call [GetVertexStateForPose](handmeshobserver_getvertexstateforpose_1608128188.md) with that neutral pose instead.  This will get you a neutral vertex buffer that is better suited for static analysis.

This neutral pose is fairly stable, but will evolve over time as the system's estimate of the user's hand shape is updated.  You can detect when the neutral pose updates by observing a change in the [NeutralPoseVersion](handmeshobserver_neutralposeversion.md).  When there is a neutral pose update, you may wish to repeat some or all of your analysis.

## -see-also

## -examples

