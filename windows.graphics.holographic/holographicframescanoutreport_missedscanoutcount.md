---
-api-id: P:Windows.Graphics.Holographic.HolographicFrameScanoutReport.MissedScanoutCount
-api-type: winrt property
---

## -description

Gets the number of scanout opportunities that were missed since the last scanout.


## -property-value

The number of scanout opportunities that were missed since the last scanout.

## -remarks

Scanout opportunities are missed if reprojection fails to complete in time for the deadline to begin scanout. This will cause a visible glitch as no new image will be presented to the display. These events should be rare as the platform will adjust scheduling to minimize the likelihood of failure.


## -see-also

## -examples

