---
-api-id: M:Windows.UI.Input.Spatial.SpatialGestureRecognizer.TrySetGestureSettings(Windows.UI.Input.Spatial.SpatialGestureSettings)
-api-type: winrt method
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Method syntax
public bool TrySetGestureSettings(Windows.UI.Input.Spatial.SpatialGestureSettings settings)
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.TrySetGestureSettings

## -description

Attempts to change the gesture settings for this recognizer.

## -parameters

### -param settings

The new [SpatialGestureSettings](spatialgesturesettings.md) to switch to.

## -returns

True if the switch was successful; otherwise, false.

## -remarks

This method can only succeed if there are no gestures currently in progress.

## -examples

## -see-also
