---
-api-id: M:Windows.Graphics.Holographic.HolographicFrameScanoutMonitor.ReadReports
-api-type: winrt method
---

## -description

Returns a list of [HolographicFrameScanoutReport](holographicframescanoutreport.md) objects where each report corresponds to a single scanout to the holographic display which has occurred since the last time the method was called. Note that each [HolographicFrame](holographicframe.md) may be scanned out multiple times.


## -returns

A list of [HolographicFrameScanoutReport](holographicframescanoutreport.md) objects.

## -remarks

The maximum number of [HolographicFrameScanoutReport](holographicframescanoutreport.md) objects that will be buffered by the system at any one time is set when the [HolographicFrameScanoutMonitor](holographicframescanoutmonitor.md) is created with a call to [HolographicSpace.CreateFrameScanoutMonitor](holographicspace_createframescanoutmonitor_928342556.md). The caller is responsible for calling **ReadReports** method at a high enough frequency to dequeue the reports before this maximum limit is reached.  If the limit is reached, the platform will discard reports until the queue is no longer full.  It is recommended that **ReadReports** be called once every frame.



## -see-also

[HolographicFrameScanoutReport](holographicframescanoutreport.md), [HolographicFrame](holographicframe.md)

## -examples
