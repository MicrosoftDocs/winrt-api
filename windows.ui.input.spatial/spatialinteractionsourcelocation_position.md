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
Gets the position of a hand or the holding position of a spatial controller.

## -property-value
The position.

## -remarks
This property represents the position of the user's hand, either directly or where it holds the spatial controller.  This position is distinct from the spatial controller's pointing ray, which has its origin at the tip of the controller.  The pointing ray for a controller is available through the [SpatialPointingPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md) method.

Note that position is only available for an interaction source if it can be correlated with the specified coordinate system.

Interactions from interaction sources that do not support pointing should be targeted using gaze, not using the controller as an "air mouse".

## -examples

## -see-also
