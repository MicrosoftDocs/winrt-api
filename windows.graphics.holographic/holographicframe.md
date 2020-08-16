---
-api-id: T:Windows.Graphics.Holographic.HolographicFrame
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class HolographicFrame : Windows.Graphics.Holographic.IHolographicFrame
-->

# Windows.Graphics.Holographic.HolographicFrame

## -description
Represents a frame of holographic content that an app must render to all cameras.

## -remarks
Each HolographicFrame tracks end-to-end latency from the CreateNextFrame call until the frame is presented. This determines the number of frames the system will look forward for the next frame's prediction.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | GetQuadLayerUpdateParameters |
| 2004 | 19041 | Id |

## -examples

## -see-also
