---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.Tapped
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Tapped<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialTappedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.Tapped

## -description

Occurs when a Tap or DoubleTap gesture is recognized.

## -remarks

For hand interactions, the [SpatialTappedEventArgs](spatialtappedeventargs.md) event fires on finger release after a finger press.

For speech interactions, this event fires after the system voice command "Select" has been processed.

For motion controller interactions, this event fires when the Select trigger or button is released after being pressed.

## -examples

## -see-also
