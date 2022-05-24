---
-api-id: M:Windows.Graphics.Holographic.HolographicSpace.CreateFrameScanoutMonitor(System.UInt32)
-api-type: winrt method
---

## -description

Creates a [HolographicFrameScanoutMonitor](holographicframescanoutmonitor.md) that allows Windows Mixed Reality applications to monitor detailed performance and timing information about the platform in real time.

## -parameters

### -param maxQueuedReports

The maximum number of [HolographicFrameScanoutReport](holographicframescanoutreport.md) objects that will be buffered by the system at any one time.

## -returns

The created [HolographicFrameScanoutMonitor](holographicframescanoutmonitor.md).

## -remarks

The caller is responsible for calling [ReadReports](holographicframescanoutmonitor_readreports_231406138.md) method at a high enough frequency to dequeue the reports before this maximum limit is reached.  If the limit is reached, the platform will discard reports until the queue is no longer full.  It is recommended that **ReadReports** be called once every frame.

## -see-also

[HolographicFrameScanoutReport](holographicframescanoutreport.md), [ReadReports](holographicframescanoutmonitor_readreports_231406138.md)

## -examples
