---
-api-id: M:Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs.TryOpenFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Perception.PerceptionDepthFrame TryOpenFrame()
-->

# Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs.TryOpenFrame

## -description
Attempts to open the depth frame that has arrived. Existing frames should be closed before opening new frames. If an app has three or more frames still open when this method is called, TryOpenFrame will fail.

## -returns
If the attempt is successful, this method returns the newly-arrived depth frame. If the attempt is unsuccessful, this value is unchanged.

## -remarks

## -examples

## -see-also
