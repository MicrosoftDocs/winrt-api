---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsPressed
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsPressed { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsPressed

## -description
Gets whether a hand or spatial controller is experiencing any press.

## -property-value
Whether the source is experiencing any press.

## -remarks
This can be because a hand has a finger pressed or a spatial controller has any button pressed.

To determine which specific presses are occurring, inspect the state's more specific properties such as [IsSelectPressed](spatialinteractionsourcestate_isselectpressed.md), [IsMenuPressed](spatialinteractionsourcestate_ismenupressed.md) or [IsGrasped](spatialinteractionsourcestate_isgrasped.md).  If this source is a spatial controller, there are further controller-specific properties to inspect within the state's [ControllerProperties](spatialinteractionsourcestate_controllerproperties.md).

Note that a voice "Select" causes an instant press and release, and so you cannot poll for a voice press using IsPressed, IsSelectPressed or SelectPressedValue.  Instead, use a [SpatialGestureRecognizer](spatialgesturerecognizer.md) and handle the [Tapped](spatialgesturerecognizer_tapped.md) event, or handle the [SourcePressed](spatialinteractionmanager_sourcepressed.md) event.

## -examples

## -see-also
