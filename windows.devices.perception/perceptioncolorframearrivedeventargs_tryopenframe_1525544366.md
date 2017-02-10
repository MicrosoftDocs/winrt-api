---
-api-id: M:Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs.TryOpenFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Perception.PerceptionColorFrame TryOpenFrame()
-->

# Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs.TryOpenFrame

## -description
Attempts to open the color frame that has arrived.

## -returns
If the attempt is successful, this method returns the newly-arrived color frame. If the attempt is unsuccessful, this value is unchanged.

## -remarks
Existing frames should be closed before opening new frames. If an app has three or more frames still open when this method is called, TryOpenFrame will fail.

## -examples

## -see-also
