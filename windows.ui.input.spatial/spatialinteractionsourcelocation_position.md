---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.Position
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Vector3> Position { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.Position

## -description
Gets the grip pose position, representing the position of the user's hand, either directly or where it holds a motion controller.

## -property-value
The position.

## -remarks
This position is distinct from the motion controller's pointing ray, which has its origin at the tip of the controller.  The pointing ray for a controller is available through the SourcePointerPose property.

Note that position is only available for an interaction source if it can be correlated with the specified coordinate system.

Interactions from interaction sources that do not support pointing should be targeted using gaze, not using the controller as an "air mouse".

## -examples

## -see-also
