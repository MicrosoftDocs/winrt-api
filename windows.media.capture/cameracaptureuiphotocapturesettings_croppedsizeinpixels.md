---
-api-id: P:Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedSizeInPixels
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Size CroppedSizeInPixels { get;  set; }
-->

# Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedSizeInPixels

## -description
The exact size in pixels of the captured photo.

## -property-value
The size of the captured photo.

## -remarks
Imaging cropping in the [CameraCaptureUI](cameracaptureui.md) is not supported for devices in the Mobile device family. The value of the **CroppedSizeInPixels** property is ignored when your app is running on these devices.

If size is provided, the user interface for cropping photos will force the user to crop the photo to the specified size.

If a size is specified that is larger than any available resolution, then the captured photo will be scaled to a large enough size first.

Setting this property requires that the [MaxResolution](cameracaptureuiphotocapturesettings_maxresolution.md) property is set to **HighestAvailable** and the [AllowCropping](cameracaptureuiphotocapturesettings_allowcropping.md) property is set to True.

## -examples

## -see-also


## -capabilities
microphone, webcam
