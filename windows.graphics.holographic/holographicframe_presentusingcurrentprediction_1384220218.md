---
-api-id: M:Windows.Graphics.Holographic.HolographicFrame.PresentUsingCurrentPrediction
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Graphics.Holographic.HolographicFramePresentResult PresentUsingCurrentPrediction()
-->

# Windows.Graphics.Holographic.HolographicFrame.PresentUsingCurrentPrediction

## -description
Present the current frame for all cameras and then wait until the next frame.

## -returns
The result of the Present call.

## -remarks
This method will make use of the Direct3D device you provided to the HolographicSpace.  If you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

## -examples

## -see-also
[PresentUsingCurrentPrediction(HolographicFramePresentWaitBehavior)](holographicframe_presentusingcurrentprediction_19613915.md)