---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteraction
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialInteraction : Windows.UI.Input.Spatial.ISpatialInteraction
-->

# Windows.UI.Input.Spatial.SpatialInteraction

## -description
Represents an interaction caused by a hand, motion controller, or the user's voice.

## -remarks
SpatialInteraction objects are not generally meant to be interpreted directly. Instead, you should target the interaction to a particular hologram based on the SpatialPointerPose from the InteractionDetected event arguments. You can then route recognition of this interaction to that hologram's SpatialGestureRecognizer by calling its CaptureInteraction method.

## -examples

## -see-also
