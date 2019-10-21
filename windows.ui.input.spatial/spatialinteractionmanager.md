---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteractionManager
-api-type: winrt class
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Class syntax.
public class SpatialInteractionManager : Windows.UI.Input.Spatial.ISpatialInteractionManager
-->

# Windows.UI.Input.Spatial.SpatialInteractionManager

## -description

Provides access to user input from hands, motion controllers, and system voice commands.

## -remarks

Spatial gestures are a key form of input for HoloLens. By routing the interactions from the SpatialInteractionManager to a hologram's [SpatialGestureRecognizer](spatialgesturerecognizer.md), apps can detect [Tap](spatialgesturesettings.md), [Hold](spatialgesturesettings.md), [Manipulation](spatialgesturesettings.md), and [Navigation](spatialgesturesettings.md) events uniformly across hand, speech and controller interactions.

> [!NOTE]
> Spatial interactions are not detected from gamepad, keyboard, or mouse input devices.

Interactions are mostly opaque, with an event triggering only at the beginning, so the gesture recognizer you route it to can capture the interaction in its entirety. Apps can instead choose to use the low-level Source events or poll using [GetDetectedSourcesAtTimestamp](spatialinteractionmanager_getdetectedsourcesattimestamp_338728324.md) to manually process the Presses, Updates, and Releases surfaced by a given hand or controller.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | IsSourceKindSupported |

## -examples

## -see-also

[Spatial interaction source sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpatialInteractionSource)
