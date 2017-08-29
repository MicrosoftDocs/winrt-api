---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.Id
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint Id { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.Id

## -description
Gets the identifier for the hand, motion controller, or user's voice.

## -property-value
The ID.

## -remarks
For hands and motion controllers, each detected hand or controller will get its own ID. For as long as the system can track that a hand is the same hand that was previously detected, it will share an ID.

For the user's voice, a single ID will be used for all voice input.

## -examples

## -see-also
