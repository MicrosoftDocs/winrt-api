---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsSelectPressed
-api-type: winrt property
---

<!-- Property syntax.
public bool IsSelectPressed { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsSelectPressed

## -description
Gets whether a hand or spatial controller is experiencing a primary Select press.

## -property-value
Whether the source is experiencing a Select press.

## -remarks
Select represents the primary press for a spatial interaction source:
* For hands, a Select press represents the user's index finger in the down position.
* For spatial controllers, a Select press represents the controller's index-finger trigger (or primary face button, if no trigger) being fully pressed.
* For voice, a Select press represents the user saying the system keyword "Select".

Note that a voice "Select" causes an instant press and release, and so you cannot poll for a voice press using IsPressed, IsSelectPressed or SelectPressedValue.  Instead, use a [SpatialGestureRecognizer](spatialgesturerecognizer.md) and handle the [Tapped](spatialgesturerecognizer_tapped.md) event, or handle the [SourcePressed](spatialinteractionmanager_sourcepressed.md) event.

## -see-also

## -examples

