---
-api-id: M:Windows.Devices.Perception.PerceptionInfraredFrameArrivedEventArgs.TryOpenFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Perception.PerceptionInfraredFrame TryOpenFrame()
-->

# Windows.Devices.Perception.PerceptionInfraredFrameArrivedEventArgs.TryOpenFrame

## -description
Attempts to open the infrared frame that has arrived.

## -returns
If the attempt is successful, this method returns the newly-arrived infrared frame. If the attempt is unsuccessful, this value is unchanged.

## -remarks
Existing frames should be closed before opening new frames. If an app has three or more frames still open when this method is called, TryOpenFrame will fail.

## -examples

## -see-also
