---
-api-id: P:Windows.Graphics.Holographic.HolographicFrameRenderingReport.SystemRelativeActualGpuFinishTime
-api-type: winrt property
---

## -description

Gets the time at which all GPU work needed for reprojection is known to be finished. This includes any overlay work or other hologram compositor post-processing needed to prepare the final image. 


## -property-value

The time at which all GPU work needed for reprojection is known to be finished.

## -remarks

Note that this value is an upper bound because computing precise GPU timestamps may not be possible on all platforms. Therefore this value cannot be used to infer if this frame scanned out on schedule. Use [MissedLatchCount](holographicframerenderingreport_missedlatchcount.md) to determine this instead.


## -see-also

[MissedLatchCount](holographicframerenderingreport_missedlatchcount.md)

## -examples

