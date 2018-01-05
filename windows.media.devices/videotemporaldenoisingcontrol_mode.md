---
-api-id: P:Windows.Media.Devices.VideoTemporalDenoisingControl.Mode
-api-type: winrt property
---

<!-- Property syntax.
public VideoTemporalDenoisingMode Mode { get;  set; }
-->

# Windows.Media.Devices.VideoTemporalDenoisingControl.Mode

## -description
Gets or sets a value indicating the current video temporal denoising mode of the capture device.

## -property-value
The current video temporal denoising mode of the capture device.

## -remarks
The **Mode** property can be safely changed while capturing is in progress.

Temporal denoising can improve the visual quality of video to the human eye, but it also can reduce image consistency and details which can negatively impact the performance of registration, optical character recognition, and other computer vision tasks. You may want to enable and disable the feature depending on your app's current video capture scenario.
 
## -see-also

## -examples

