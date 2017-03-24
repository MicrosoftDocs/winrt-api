---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.Orientation
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Quaternion> Orientation { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceLocation.Orientation

## -description
Gets the holding orientation of a spatial controller.

## -property-value
The orientation.

## -remarks
This property represents the orientation of the user's hand, either directly or as it holds a spatial controller.  This orientation is distinct from a spatial controller's pointing ray, which points forward from the tip of the controller.  The pointing ray for a controller is available through the [SpatialPointingPose.TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md) method.

Note that orientation is only available for an interaction source if it can correlated with the specified coordinate system.  Spatial controllers that do not expose pointing poses do not expose orientation either.

Interactions from interaction sources that do not support pointing should be targeted using gaze, not using the controller as an "air mouse".

## -examples

## -see-also
