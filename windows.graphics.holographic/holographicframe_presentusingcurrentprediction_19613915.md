---
-api-id: M:Windows.Graphics.Holographic.HolographicFrame.PresentUsingCurrentPrediction(Windows.Graphics.Holographic.HolographicFramePresentWaitBehavior)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Graphics.Holographic.HolographicFramePresentResult PresentUsingCurrentPrediction(Windows.Graphics.Holographic.HolographicFramePresentWaitBehavior waitBehavior)
-->

# Windows.Graphics.Holographic.HolographicFrame.PresentUsingCurrentPrediction

## -description
Presents the current frame for all cameras with the specified waiting behavior.

## -parameters
### -param waitBehavior
The wait behavior.

## -returns
The result of the Present call.

## -remarks
This method will make use of the Direct3D device you provided to the HolographicSpace.  If you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

## -examples

## -see-also
[PresentUsingCurrentPrediction](holographicframe_presentusingcurrentprediction_1384220218.md)