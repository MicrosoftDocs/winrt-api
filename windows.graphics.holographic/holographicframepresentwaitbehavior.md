---
-api-id: T:Windows.Graphics.Holographic.HolographicFramePresentWaitBehavior
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Graphics.Holographic.HolographicFramePresentWaitBehavior : int
-->

# HolographicFramePresentWaitBehavior

## -description
Specifies whether a Present call should wait for the frame to finish or returns control to the thread immediately.

## -enum-fields
### -field WaitForFrameToFinish:0
Wait for the time to start head pose dependent rendering for the next frame.  This method must only be called after [PresentUsingCurrentPrediction](holographicframe_presentusingcurrentprediction_1384220218.md) has already been called on this frame.

### -field DoNotWaitForFrameToFinish:1
Return control to the thread immediately.


## -remarks

## -examples

## -see-also