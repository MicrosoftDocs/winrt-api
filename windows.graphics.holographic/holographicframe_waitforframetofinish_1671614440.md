---
-api-id: M:Windows.Graphics.Holographic.HolographicFrame.WaitForFrameToFinish
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void WaitForFrameToFinish()
-->

# Windows.Graphics.Holographic.HolographicFrame.WaitForFrameToFinish

## -description
Blocks the current thread until this frame has finished and is showing on the displays.

## -remarks
Note that the default wait behavior of PresentUsingCurrentPrediction already waits for the frame to finish.

Except for very simple apps, you should generally use [HolographicSpace.WaitForNextFrameReady](holographicspace_waitfornextframeready_2104087308.md) or [HolographicSpace.WaitForNextFrameReadyWithHeadStart](holographicspace_waitfornextframereadywithheadstart_1475386923.md) instead, which allows your app's CPU and GPU work to overlap across consecutive frames.

## -examples

## -see-also
