---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteractionSource
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialInteractionSource : Windows.UI.Input.Spatial.ISpatialInteractionSource, Windows.UI.Input.Spatial.ISpatialInteractionSource2
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource

## -description
Represents one detected instance of a hand, spatial controller, or user's voice that can cause interactions and gestures.

## -remarks
For hands and controllers, each detected hand or spatial controller will get its own ID. For as long as the system can track that a hand is the same hand that was previously detected, it will share an ID.

For the user's voice, a single ID will be used for all voice input.

## -examples

## -see-also
