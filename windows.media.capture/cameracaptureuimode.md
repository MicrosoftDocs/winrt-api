---
-api-id: T:Windows.Media.Capture.CameraCaptureUIMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.CameraCaptureUIMode : int
-->

# CameraCaptureUIMode

## -description
Determines whether the user interface for capturing from the attached camera allows capture of photos, videos, or both photos and videos.

## -enum-fields
### -field PhotoOrVideo:0
Either a photo or video can be captured.

### -field Photo:1
The user can only capture a photo.

### -field Video:2
The user can only capture a video.


## -remarks
> [!NOTE]
> You should not specify the **webcam** or **microphone** capabilities in your app manifest file if you are using **CameraCaptureUI**. If you do so, your app will be displayed in the device's camera privacy settings, but even if the user denies camera access to your app, it will not prevent the **CameraCaptureUI** from capturing media. This is because the Windows built-in camera app is a trusted first-party app that requires the user to initiate photo, audio, and video capture with a button press. Your app may fail WACK (Windows Application Certification Kit) certification when submitted to the Store if you specify the **webcam** or **microphone** capabilities when using **CameraCaptureUI**.

You must specify the **webcam** or **microphone** capabilities in your app manifest file if you are using [MediaCapture](mediacapture.md) to capture audio, photos, or video programmatically.

## -examples

## -see-also
[CaptureFileAsync](cameracaptureui_capturefileasync.md)

## -capabilities
webcam, microphone