---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.SourcePointerPose
-api-type: winrt property
---

<!-- Property syntax.
public SpatialPointerInteractionSourcePose SourcePointerPose { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.SourcePointerPose

## -description
Gets the pointer pose for a particular spatial interaction source, such as a motion controller, at a given timestamp.

## -property-value
The interaction source pointer pose.

## -remarks
The pointer pose represents the tip of a motion controller pointing forward.  This pose is best used to raycast when pointing at UI when you are rendering the controller model itself.

To examine the grip pose of a motion controller, examine the Position and Orientation properties directly on the SpatialInteractionSourceLocation instance.

This property will return null if the specified spatial interaction source does not support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is false).

This property can return null, for example, when the spatial interaction source lost position or orientation tracking, in which case SpatialInteractionSourceLocation.Position or Orientation can also be null at the same time.

## -see-also
[SpatialPointerPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md)

## -examples

