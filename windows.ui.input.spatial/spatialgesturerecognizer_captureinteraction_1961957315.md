---
-api-id: M:Windows.UI.Input.Spatial.SpatialGestureRecognizer.CaptureInteraction(Windows.UI.Input.Spatial.SpatialInteraction)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void CaptureInteraction(Windows.UI.Input.Spatial.SpatialInteraction interaction)
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.CaptureInteraction

## -description
Subscribe this SpatialGestureRecognizer to track all input events that occur as part of this interaction.

## -parameters
### -param interaction
The SpatialInteraction to capture from the SpatialInteractionManager's InteractionDetected event.

## -remarks
To use SpatialGestureRecognizer, handle the SpatialInteractionManager's InteractionDetected event and get the SpatialPointerPose for that point in time by calling TryGetPointerPose on the event arguments. Grab the user's gaze ray from this SpatialPointerPose and intersect it with the holograms and surfaces in the user's surroundings, in order to determine what the user is intending to interact with. Then, route the SpatialInteraction in the event arguments to the target hologram's SpatialGestureRecognizer, using its CaptureInteraction method. This starts interpreting that interaction according to the SpatialGestureSettings set at creation time on that recognizer.

Note that you may choose to have more than one SpatialGestureRecognizer capture the same interaction. In this case, events will surface from both recognizers according to the SpatialGestureSettings of each. This can be useful if, for example, you have one hologram that supports Tap that is logically contained within a hologram that supports NavigationRailsY for scrolling, and you want to allow either gesture when gazing at the inner hologram.

## -examples

## -see-also
