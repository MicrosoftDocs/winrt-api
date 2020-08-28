---
-api-id: T:Windows.UI.Input.Spatial.SpatialGestureRecognizer
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialGestureRecognizer : Windows.UI.Input.Spatial.ISpatialGestureRecognizer
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer

## -description

Interprets user interactions from hands, motion controllers, and system voice commands to surface spatial gesture events, which users target using their gaze or a motion controller's pointing ray.

## -remarks

Spatial gestures are a key form of input for Mixed Reality headsets such as HoloLens. By routing interactions from the [SpatialInteractionManager](spatialinteractionmanager.md) to a hologram's SpatialGestureRecognizer, apps can detect Tap, Hold, Manipulation, and Navigation events uniformly across hands, voice, and motion controllers.

Note that spatial gestures are not detected for input from gamepads, keyboards or mice.

SpatialGestureRecognizer performs only the minimal disambiguation between the set of gestures that you request. For example, if you request just Tap, the user may hold their finger down as long as they like and a Tap will still occur. If you request both Tap and Hold, after about a second of holding down their finger, the gesture will promote to a Hold and a Tap will no longer occur.

To use SpatialGestureRecognizer, handle the SpatialInteractionManager's [InteractionDetected](spatialinteractionmanager_interactiondetected.md) event and grab the [SpatialPointerPose](spatialpointerpose.md) exposed there. Use the user's gaze ray from this pose to intersect with the holograms and surface meshes in the user's surroundings, in order to determine what the user is intending to interact with. Then, route the [SpatialInteraction](spatialinteraction.md) in the event arguments to the target hologram's SpatialGestureRecognizer, using its [CaptureInteraction](spatialgesturerecognizer_captureinteraction_1961957315.md) method. This starts interpreting that interaction according to the [SpatialGestureSettings](spatialgesturesettings.md) set on that recognizer at creation time or by [TrySetGestureSettings](spatialgesturerecognizer_trysetgesturesettings_136776216.md).

When targeting a spatial interaction, such as a hand gesture, motion controller press or voice interaction, apps should choose a pointing ray available from the interaction's SpatialPointerPose, based on the nature of the interaction's [SpatialInteractionSource](spatialinteractionsource.md):

* If the interaction source does not support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is false), the app should target based on the user's gaze, available through the [Head](spatialpointerpose_head.md) property.
* If the interaction source does support pointing ([IsPointingSupported](spatialinteractionsource_ispointingsupported.md) is true), the app may instead target based on the source's pointer pose, available through the [TryGetInteractionSourcePose](spatialpointerpose_trygetinteractionsourcepose_1162732260.md) method.

The app should then intersect the chosen pointing ray with its own holograms or with the spatial mapping mesh to render cursors and determine what the user is intending to interact with.

For applications using the gaze-and-commit input model, particularly on HoloLens (first gen), SpatialGestureRecognizer can be used to to enable composite gestures built on top of the 'select' event. By routing interactions from the SpatialInteractionManager to a hologram's SpatialGestureRecognizer, apps can detect Tap, Hold, Manipulation, and Navigation events uniformly across hands, voice, and spatial input devices, without having to handle presses and releases manually.

## -examples

## -see-also

[Spatial interaction source sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpatialInteractionSource)
