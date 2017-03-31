---
-api-id: T:Windows.Media.Capture.CameraCaptureUI
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CameraCaptureUI : Windows.Media.Capture.ICameraCaptureUI
-->

# Windows.Media.Capture.CameraCaptureUI

## -description
Provides a full window UI for capturing audio, video, and photos from a camera. As well as controls for trimming video, time delayed capture, and camera settings.

## -remarks
[CameraCaptureUI](cameracaptureui.md) provides a full window UI experience for capturing audio, video, and images. It provides controls for setting a time delay on photo captures, trimming video, and for adjusting the camera's settings such as video resolution, the audio device, brightness, and contrast.

Call [CaptureFileAsync](cameracaptureui_capturefileasync.md) to launch the UI. The user has control over when to start the capture. When the asynchronous [CaptureFileAsync](cameracaptureui_capturefileasync.md) operation completes, a [StorageFile](../windows.storage/storagefile.md) object is returned. For how-to guidance for using **CameraCaptureUI**, see [Capture photos and video with Windows built-in camera UI](https://msdn.microsoft.com/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui)

> [!NOTE]
> You should not specify the **webcam** or **microphone** capabilities in your app manifest file if you are using **CameraCaptureUI**. If you do so, your app will be displayed in the device's camera privacy settings, but even if the user denies camera access to your app, it will not prevent the **CameraCaptureUI** from capturing media. This is because the Windows built-in camera app is a trusted first-party app that requires the user to initiate photo, audio, and video capture with a button press. Your app may fail WACK (Windows Application Certification Kit) certification when submitted to the Store if you specify the **webcam** or **microphone** capabilities when using **CameraCaptureUI**.

You must specify the **webcam** or **microphone** capabilities in your app manifest file if you are using [MediaCapture](mediacapture.md) to capture audio, photos, or video programmatically.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
This code shows how to use the **CameraCaptureUI** class to take a picture. The code is from file CapturePhoto.xaml.cs of the [Camera capture UI sample](http://go.microsoft.com/fwlink/p/?linkid=249441). The dialog with the user occurs when you call the asynchronous method [CaptureFileAsync](cameracaptureui_capturefileasync.md).



[!code-csharp[CameraCaptureUI_CSharp](../windows.media.capture/code/CameraCaptureUI/cs/CapturePhoto.xaml.cs#SnippetCameraCaptureUI_CSharp)]



[!code-js[CameraCaptureUI_JavaScript](../windows.media.capture/code/CameraCaptureUI/js/js/capturephoto.js#SnippetCameraCaptureUI_JavaScript)]

## -see-also
[Audio, video, and camera](http://msdn.microsoft.com/library/0fc12d26-f1cf-4da7-b5a7-735a5074b74a), [Capture photos and video with Windows built-in camera UI](https://msdn.microsoft.com/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui)


## -capabilities
webcam, microphone