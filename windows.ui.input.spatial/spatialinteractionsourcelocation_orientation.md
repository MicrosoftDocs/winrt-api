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
Gets the grip pose orientation, representing the orientation of the user's hand as it holds a motion controller.

## -property-value
The orientation.

## -remarks
This orientation is distinct from a motion controller's pointing ray, which points forward from the tip of the controller.  The pointing ray for a controller is available through the SourcePointerPose property.

Note that orientation is only available for an interaction source if it can correlated with the specified coordinate system.  Motion controllers that do not expose pointer poses do not expose orientation either.

Interactions from interaction sources that do not support pointing should be targeted using gaze, not using the controller as an "air mouse".

## -examples

## -see-also
