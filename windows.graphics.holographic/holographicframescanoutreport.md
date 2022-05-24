---
-api-id: T:Windows.Graphics.Holographic.HolographicFrameScanoutReport
-api-type: winrt class
---

## -description

Provides performance and timing information about a single scanout to a holographic display.

## -remarks

"Scanout" in this context roughly corresponds to sending a new image to the display hardware. A single [HolographicFrame](holographicframe.md) may be scanned out multiple times if there is not a new frame available with its GPU work finished at the next scanout opportunity. There will be an individual **HolographicFrameScanoutReport** produced for each of these repetitions in this case.

Each **HolographicFrameScanoutReport** also contains a reference to a corresponding [HolographicFrameRenderingReport](holographicframerenderingreport.md), accessed with the [RenderingReport](holographicframescanoutreport_renderingreport.md) property, which contains information about the work the application did leading up to the frame being scanned out by the system for the first time. This work only happens once when the frame is first presented, and the result is re-used on each subsequent scanout of the same frame.

## -see-also

[HolographicFrameRenderingReport](holographicframerenderingreport.md), [HolographicFrame](holographicframe.md)

## -examples
