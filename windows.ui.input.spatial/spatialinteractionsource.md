---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteractionSource
-api-type: winrt class
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Class syntax.
public class SpatialInteractionSource : Windows.UI.Input.Spatial.ISpatialInteractionSource, Windows.UI.Input.Spatial.ISpatialInteractionSource2
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource

## -description

Represents one detected instance of a hand, motion controller, or speech source that can cause interactions and gestures.

## -remarks

For hands and controllers, each detected hand or motion controller will get its own ID. For as long as the system can track that a hand is the same hand that was previously detected, it will share an ID.

For speech, a single ID will be used for all speech input.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Controller |
| 1703 | 15063 | IsGraspSupported |
| 1703 | 15063 | IsMenuSupported |
| 1703 | 15063 | IsPointingSupported |
| 1703 | 15063 | TryGetStateAtTimestamp |
| 1709 | 16299 | Handedness |
| 1903 | 18362 | TryCreateHandMeshObserver |
| 1903 | 18362 | TryCreateHandMeshObserverAsync |

## -examples

## -see-also

[Spatial interaction source sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpatialInteractionSource)
