---
-api-id: P:Windows.Graphics.Holographic.HolographicFrameRenderingReport.SystemRelativeTargetLatchTime
-api-type: winrt property
---

## -description

Gets an estimate of the time that the [HolographicFrame](holographicframe.md) needed to have all its GPU work, both application and compositor, finished in order to begin reprojection on schedule.


## -property-value

An estimate of the time that the [HolographicFrame](holographicframe.md) needed to have all its GPU work finished in order to begin reprojection on schedule.

## -remarks

If the [SystemRelativeActualGpuFinishTime](holographicframerenderingreport_systemrelativeactualgpufinishtime.md) exceeds this value, it is highly likely the **HolographicFrame** will fail to present on schedule, typically resulting in a previously submitted **HolographicFrame** being re-projected multiple times. Note that this value is an estimate, since the precision of reprojection scheduling may be variable, and therefore this value cannot be used to determine if if this frame scanned out on schedule. Use [MissedLatchCount](holographicframerenderingreport_missedlatchcount.md) to determine this instead.


## -see-also

[HolographicFrame](holographicframe.md
[SystemRelativeActualGpuFinishTime](holographicframerenderingreport_systemrelativeactualgpufinishtime.md)
[MissedLatchCount](holographicframerenderingreport_missedlatchcount.md)

## -examples

