---
-api-id: T:Windows.Graphics.Holographic.HolographicCamera
-api-type: winrt class
-api-device-family-note: xbox
ms.custom: RS5, 19H1
---

<!-- Class syntax.
public class HolographicCamera : Windows.Graphics.Holographic.IHolographicCamera, Windows.Graphics.Holographic.Preview.IHolographicCamera2
-->

# Windows.Graphics.Holographic.HolographicCamera

## -description

Provides per-frame rendering functionality for a [HolographicViewConfiguration](holographicviewconfiguration.md) on a [HolographicDisplay](holographicdisplay.md).

## -remarks

An app renders to the back buffer for at least one HolographicCamera before presenting each HolographicFrame.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Display |
| 1703 | 15063 | LeftViewportParameters |
| 1703 | 15063 | RightViewportParameters |
| 1709 | 16299 | IsPrimaryLayerEnabled |
| 1709 | 16299 | MaxQuadLayerCount |
| 1709 | 16299 | QuadLayers |
| 1803 | 17134 | CanOverrideViewport |
| 1809 | 17763 | IsHardwareContentProtectionEnabled |
| 1809 | 17763 | IsHardwareContentProtectionSupported |
| 1903 | 18362 | ViewConfiguration |

## -examples

## -see-also

[Depth-based focus plane](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicDepthBasedImageStabilization), [Tag-along hologram sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicTagAlong)
