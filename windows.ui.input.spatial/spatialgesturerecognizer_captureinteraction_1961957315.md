---
-api-id: M:Windows.UI.Input.Spatial.SpatialGestureRecognizer.CaptureInteraction(Windows.UI.Input.Spatial.SpatialInteraction)
-api-type: winrt method
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Method syntax
public void CaptureInteraction(Windows.UI.Input.Spatial.SpatialInteraction interaction)
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.CaptureInteraction

## -description

Track all input events that occur as part of the specified interaction.

## -parameters

### -param interaction

The interaction to capture from the [InteractionDetected](spatialinteractionmanager_interactiondetected.md) event.

## -remarks

To use [SpatialGestureRecognizer](spatialgesturerecognizer.md), handle the [SpatialInteractionManager](spatialinteractionmanager.md)'s [InteractionDetected](spatialinteractionmanager_interactiondetected.md) event. I that event handler, get the [SpatialPointerPose](spatialpointerpose.md) (for that point in time) by calling [TryGetPointerPose](spatialinteractiondetectedeventargs_trygetpointerpose_100002244.md). Get the user's gaze ray from the [SpatialPointerPose](spatialpointerpose.md) and intersect it with the holograms and surfaces in the user's surroundings (to determine what the user is intending to interact with). Then, pass the [SpatialInteraction](spatialinteraction.md) event argument to the target hologram's [SpatialGestureRecognizer](spatialgesturerecognizer.md), using the CaptureInteraction method. The interaction is then interpreted according to the [SpatialGestureSettings](spatialgesturesettings.md) set when the recognizer was created.

> [!NOTE]
> You can choose to have more than one [SpatialGestureRecognizer](spatialgesturerecognizer.md) capture the same interaction. In this case, events surface from both recognizers according to their [SpatialGestureSettings](spatialgesturesettings.md). For example, when you have one hologram that supports Tap, logically contained within a hologram that supports scrolling with NavigationRailsY, and you want to support both gestures when gazing at the inner hologram.

## -examples

## -see-also
