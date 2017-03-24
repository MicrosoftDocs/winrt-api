---
-api-id: M:Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs.TryGetPointerPose(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Spatial.SpatialPointerPose TryGetPointerPose(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs.TryGetPointerPose

## -description
Gets the available pointing poses, such as the user's head gaze and each spatial controller's pointing pose, for use in targeting this gesture.

## -remarks
This pose is from the timestamp of the initial SpatialInteraction routed to this recognizer to begin the active gesture.

When targeting a spatial interaction, such as a hand gesture, spatial controller press or voice interaction, apps should choose a pointing ray available from the interaction's SpatialPointerPose, based on the nature of the interaction's [SpatialInteractionSource](spatialinteractionsource.md):
* If the interaction source does not support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is false), the app should target based on the user's gaze, available through the [Head](spatialpointerpose_head.md) property.
* If the interaction source does support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is true), the app may instead target based on the source's pointing pose, available through the [TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md) method.

The app should then intersect the chosen pointing ray with its own holograms or with the spatial mapping mesh to render cursors and determine what the user is intending to interact with.

Once an interaction has started, relative motions of the hand or controller may be used to control the gesture, as with the [Manipulation](spatialgesturerecognizer_gesturesettings.md) or [Navigation](spatialgesturerecognizer_gesturesettings.md) gesture.

This method will return null if the specified coordinate system cannot be located at the moment.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the pointing poses.

## -returns
The pointing poses.

## -examples

## -see-also
