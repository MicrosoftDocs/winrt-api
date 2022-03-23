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
CameraCaptureUI provides a full window UI experience for capturing audio, video, and images. It provides controls for setting a time delay on photo captures, trimming video, and for adjusting the camera's settings such as video resolution, the audio device, brightness, and contrast.

Call [CaptureFileAsync](cameracaptureui_capturefileasync_1903527183.md) to launch the UI. The user has control over when to start the capture. When the asynchronous [CaptureFileAsync](cameracaptureui_capturefileasync_1903527183.md) operation completes, a [StorageFile](../windows.storage/storagefile.md) object is returned. For how-to guidance for using **CameraCaptureUI**, see [Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui)

> [!NOTE]
> You should not specify the **webcam** or **microphone** capabilities in your app manifest file if you are using **CameraCaptureUI**. If you do so, your app will be displayed in the device's camera privacy settings, but even if the user denies camera access to your app, it will not prevent the **CameraCaptureUI** from capturing media. This is because the Windows built-in camera app is a trusted first-party app that requires the user to initiate photo, audio, and video capture with a button press. Your app may fail Windows Application Certification Kit certification when submitted to the Store if you specify the **webcam** or **microphone** capabilities when using **CameraCaptureUI**.

You must specify the **webcam** or **microphone** capabilities in your app manifest file if you are using [MediaCapture](mediacapture.md) to capture audio, photos, or video programmatically.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples
This code shows how to use the **CameraCaptureUI** class to take a picture. The code is from file CapturePhoto.xaml.cs of the [Camera capture UI C# sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/CameraCaptureUI%20Sample%20(Windows%208)/C%23). The equivalent [Camera capture UI C++ sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/CameraCaptureUI%20Sample%20(Windows%208)/C%2B%2B) is also available. The dialog with the user occurs when you call the asynchronous method [CaptureFileAsync](cameracaptureui_capturefileasync_1903527183.md).



[!code-csharp[CameraCaptureUI_CSharp](../windows.media.capture/code/CameraCaptureUI/cs/CapturePhoto.xaml.cs#SnippetCameraCaptureUI_CSharp)]

## -see-also
[Audio, video, and camera](/windows/uwp/audio-video-camera/index), [Capture photos and video with Windows built-in camera UI](/windows/uwp/audio-video-camera/capture-photos-and-video-with-cameracaptureui)


## -capabilities
microphone, webcam
