---
-api-id: E:Windows.UI.Input.Spatial.SpatialInteractionManager.InteractionDetected
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler InteractionDetected<Windows.UI.Input.Spatial.SpatialInteractionManager,  Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialInteractionManager.InteractionDetected

## -description

Occurs when a new interaction is available for routing to a [SpatialGestureRecognizer](spatialgesturerecognizer.md).

## -remarks

Pass the [SpatialInteraction](spatialinteraction.md) object in the event arguments to the [CaptureInteraction](spatialgesturerecognizer_captureinteraction_1961957315.md) method of the [SpatialGestureRecognizer](spatialgesturerecognizer.md) to route this interaction to that gesture recognizer.

## -examples

## -see-also
