---
-api-id: T:Windows.Media.Capture.CameraCaptureUIPhotoFormat
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.CameraCaptureUIPhotoFormat : int
-->

# CameraCaptureUIPhotoFormat

## -description
Determines the format for photos captured with [CameraCaptureUI](cameracaptureui.md).

## -enum-fields
### -field Jpeg:0
JPEG format.

### -field Png:1
PNG format.

### -field JpegXR:2
JPEG-XR format.


## -remarks
Set the photo capture format for [CameraCaptureUI](cameracaptureui.md) by setting the [CameraCaptureUIPhotoCaptureSettings.Format](cameracaptureuiphotocapturesettings_format.md) property to one of the values of this enumeration.

For how-to guidance for using **CameraCaptureUI** to capture photos and video, see [Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui).



> [!NOTE]
> You should not specify the **webcam** or **microphone** capabilities in your app manifest file if you are using **CameraCaptureUI**. If you do so, your app will be displayed in the device's camera privacy settings, but even if the user denies camera access to your app, it will not prevent the **CameraCaptureUI** from capturing media. This is because the Windows built-in camera app is a trusted first-party app that requires the user to initiate photo, audio, and video capture with a button press. Your app may fail Windows Application Certification Kit certification when submitted to the Store if you specify the **webcam** or **microphone** capabilities when using **CameraCaptureUI**.

You must specify the **webcam** or **microphone** capabilities in your app manifest file if you are using [MediaCapture](mediacapture.md) to capture audio, photos, or video programmatically.

## -examples

## -see-also
[Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui), [CameraCaptureUI](cameracaptureui.md), [CameraCaptureUIPhotoCaptureSettings.Format](cameracaptureuiphotocapturesettings_format.md)

## -capabilities
microphone, webcam
