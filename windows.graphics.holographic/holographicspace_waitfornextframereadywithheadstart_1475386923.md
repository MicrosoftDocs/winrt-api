---
-api-id: M:Windows.Graphics.Holographic.HolographicSpace.WaitForNextFrameReadyWithHeadStart(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicSpace.WaitForNextFrameReadyWithHeadStart(TimeSpan requestedHeadStartDuration)
-->

# Windows.Graphics.Holographic.HolographicSpace.WaitForNextFrameReadyWithHeadStart

## -description
Blocks the current thread until the right time to begin rendering the next frame, with the specified head start.

## -parameters
### -param requestedHeadStartDuration
The amount of extra head start time to wake up early.

## -remarks
This will be approximately the head start plus one frame duration before the next frame is expected to be received by the compositor to reproject and scan out.

## -see-also

## -examples

