---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceState.SelectPressedValue
-api-type: winrt property
---

<!-- Property syntax.
public double SelectPressedValue { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceState.SelectPressedValue

## -description
Gets the amount to which a hand or spatial controller is experiencing a primary Select press, as a value between 0.0 and 1.0.

## -property-value
The amount to which the source is experiencing a Select press.

## -remarks
SelectPressedValue ranges from 0.0 to 1.0, with 0.0 representing no Select press and 1.0 representing a full Select press.  [IsPressed](spatialinteractionsourcestate_ispressed.md) will only return true once the SelectPressedValue reaches 1.0.  If a given source can only detect an on/off state for Select presses, the value will always be 0.0 or 1.0.

Select represents the primary press for a spatial interaction source:
* For hands, a Select press represents the user's index finger in the down position.
* For spatial controllers, a Select press represents the controller's index-finger trigger (or primary face button, if no trigger) being fully pressed.
* For voice, a Select press represents the user saying the system keyword "Select".

Note that a voice "Select" causes an instant press and release, and so you cannot poll for a voice press using IsPressed, IsSelectPressed or SelectPressedValue.  Instead, use a [SpatialGestureRecognizer](spatialgesturerecognizer.md) and handle the [Tapped](spatialgesturerecognizer_tapped.md) event, or handle the [SourcePressed](spatialinteractionmanager_sourcepressed.md) event.

## -see-also

## -examples

