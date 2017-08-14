---
-api-id: P:Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedAspectRatio
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Size CroppedAspectRatio { get;  set; }
-->

# Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedAspectRatio

## -description
The aspect ratio of the captured photo.

## -property-value
The aspect ratio of the captured photo. If zero, the aspect ratio is not enforced.

## -remarks
Imaging cropping in the [CameraCaptureUI](cameracaptureui.md) is not supported for devices in the Mobile device family. The value of the **CroppedAspectRatio** property is ignored when your app is running on these devices.

If a non-zero value is provided, the user interface will force the user to crop the photo to the specified aspect ratio.

## -examples

## -see-also


## -capabilities
microphone, webcam
