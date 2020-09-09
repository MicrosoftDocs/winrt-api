---
-api-id: T:Windows.Media.Capture.CameraCaptureUIVideoFormat
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.CameraCaptureUIVideoFormat : int
-->

# CameraCaptureUIVideoFormat

## -description
Determines the format for saving captured videos.

## -enum-fields
### -field Mp4:0
MP4/H.264/AAC format.

### -field Wmv:1
WMV format.


## -remarks
Set the video capture format for [CameraCaptureUI](cameracaptureui.md) by setting the [CameraCaptureUIPhotoCaptureSettings.Format](cameracaptureuivideocapturesettings_format.md) property to one of the values of this enumeration.

For how-to guidance for using **CameraCaptureUI** to capture photos and video, see [Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui).



> [!NOTE]
> You should not specify the **webcam** or **microphone** capabilities in your app manifest file if you are using **CameraCaptureUI**. If you do so, your app will be displayed in the device's camera privacy settings, but even if the user denies camera access to your app, it will not prevent the **CameraCaptureUI** from capturing media. This is because the Windows built-in camera app is a trusted first-party app that requires the user to initiate photo, audio, and video capture with a button press. Your app may fail Windows Application Certification Kit certification when submitted to the Store if you specify the **webcam** or **microphone** capabilities when using **CameraCaptureUI**.

You must specify the **webcam** or **microphone** capabilities in your app manifest file if you are using [MediaCapture](mediacapture.md) to capture audio, photos, or video programmatically.

## -examples

## -see-also
[Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui), [CameraCaptureUI](cameracaptureui.md), [CameraCaptureUIPhotoCaptureSettings.Format](cameracaptureuiphotocapturesettings_format.md)

## -capabilities
microphone, webcam
