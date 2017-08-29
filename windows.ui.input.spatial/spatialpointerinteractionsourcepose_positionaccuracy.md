---
-api-id: P:Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose.PositionAccuracy
-api-type: winrt property
---

<!-- Property syntax.
public SpatialInteractionSourcePositionAccuracy PositionAccuracy { get; }
-->

# Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose.PositionAccuracy

## -description
Gets the accuracy of an interaction source's positional tracking.

## -property-value
The position accuracy.

## -remarks
When a visually-tracked motion controller loses tracking, the system may continue to synthesize a position, with the precise mechanism of synthesis varying based on the tracking technology.  Apps may check this property to determine when the position does not represent the nominal positional accuracy for that controller.

For example, an app may choose to accept all positions when pointing at menus or interacting with world objects.  Then, when the user starts painting in the world around them, the app may choose to accept only positions with a High accuracy, to ensure the quality of the painting remains high.

## -see-also

## -examples

