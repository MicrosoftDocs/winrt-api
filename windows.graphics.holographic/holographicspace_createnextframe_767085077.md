---
-api-id: M:Windows.Graphics.Holographic.HolographicSpace.CreateNextFrame
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Graphics.Holographic.HolographicFrame CreateNextFrame()
-->

# Windows.Graphics.Holographic.HolographicSpace.CreateNextFrame

## -description
Creates a HolographicFrame for the next frame to display.

## -returns
The next frame.

## -remarks
Apps use the HolographicFrame returned here to find out the predicted positions of each HolographicCamera at the time of frame display, render their views based on that prediction, and then call the PresentUsingCurrentPrediction method to send them to the displays.

The system tracks end-to-end latency from the CreateNextFrame call until the frame is presented. This determines the number of frames the system will look forward for the next frame's prediction.

## -examples

## -see-also
