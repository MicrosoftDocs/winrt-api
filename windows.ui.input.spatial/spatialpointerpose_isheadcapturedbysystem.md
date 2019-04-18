---
-api-id: P:Windows.UI.Input.Spatial.SpatialPointerPose.IsHeadCapturedBySystem
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsHeadCapturedBySystem { get; }
-->

# Windows.UI.Input.Spatial.SpatialPointerPose.IsHeadCapturedBySystem

## -description

Gets whether the user's head gaze is being captured by system UI at the moment (preventing gaze-driven presses from being delivered to the view associated with this [SpatialPointerPose](spatialpointerpose.md)).

## -property-value

Whether head gaze is being captured by the system.

## -remarks

While the user's head gaze is targeting non-modal interactive system UI, gaze-driven presses such as taps and speech "select" keywords are delivered to that system UI rather than to the visible immersive view.  

If an app continues to show its gaze cursor while head gaze is captured, users may believe such presses will activate the app's UI. Instead, they'll activate the system UI, which can cause confusion.

While this property is true, an app can hide its gaze cursor, letting users know that gaze-driven presses are not currently active within the app.

## -see-also

## -examples
