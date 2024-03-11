---
-api-id: T:Windows.Media.Capture.MediaCapture
-api-type: winrt class
ms.custom: project-verbatim
---

<!-- Class syntax.
public class MediaCapture : Windows.Foundation.IClosable, Windows.Media.Capture.IMediaCapture, Windows.Media.Capture.IMediaCapture2, Windows.Media.Capture.IMediaCapture3, Windows.Media.Capture.IMediaCapture4, Windows.Media.Capture.IMediaCapture5, Windows.Media.Capture.IMediaCaptureVideoPreview
-->

# Windows.Media.Capture.MediaCapture

## -description

Provides functionality for capturing photos, audio, and videos from a capture device, such as a webcam.

## -remarks

The MediaCapture class is used to capture audio, video, and images from a camera. For how-to guidance for displaying the camera preview, see [Display the camera preview](/windows/uwp/audio-video-camera/simple-camera-preview-access). To quickly get started capturing photos, audio, or video, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

The [Camera](/windows/uwp/audio-video-camera/camera) page is the main hub for how-to guidance for using **MediaCapture** in your app. In addition to the basic camera tasks, this page links to how-to articles for advanced scenarios including:

+ Using the hardware camera button on devices that have one
+ Handling device and screen orientation
+ Using camera profiles to determine device capabilities
+ Setting the format, resolution, and frame rate of captured video
+ Using [AdvancedPhotoCapture](advancedphotocapture.md) to capture HDR or low-light photos
+ Using the [VideoDeviceController](../windows.media.devices/videodevicecontroller.md) to access manual camera controls like exposure, white balance, auto-focus, and flash
+ Using effects while capturing video
+ Capturing photo sequences
+ Using [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) to get a stream of frames from one or more cameras, including rgb, infrared, and depth cameras
+ Getting a frame from the preview stream

The [Camera](/windows/uwp/audio-video-camera/camera) article also links to all of the UWP SDK samples for camera, such as the [Camera starter kit](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraStarterKit?amp;clcid=0x409) sample.

The [InitializeAsync](mediacapture_initializeasync_315323248.md) method, which initializes the **MediaCapture** object, must be called before you can start previewing or capturing from the device. In C# or C++ apps, the first use of the **MediaCapture** object to call **InitializeAsync** should be on the STA thread. Calls from an MTA thread may result in undefined behavior. [InitializeAsync](mediacapture_initializeasync_315323248.md) will launch a consent prompt to get the user's permission for the app to access the microphone or camera. **InitializeAsync** should be called from the main UI thread of your app. Apps must handle app suspension or termination by properly cleaning up media capture resources. For information on shutting down the **MediaCapture** object properly, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

> On Windows, music and media capture apps should monitor the [SystemMediaTransportControls.SoundLevel](../windows.media/systemmediatransportcontrols_soundlevel.md) to determine whether the audio streams on the app have been [Muted](../windows.media/soundlevel.md). For apps using the MediaCapture object, capture will be automatically stopped when the capture streams of the app are muted. Capture is not re-started automatically when the audio streams are unmuted, so the [SoundLevel](../windows.media/systemmediatransportcontrols_soundlevel.md) changed notification can be used to restart capture. Use the [SystemMediaTransportControls.PropertyChanged](../windows.media/systemmediatransportcontrols_propertychanged.md) event to determine when the [SoundLevel](../windows.media/systemmediatransportcontrols_soundlevel.md) property changes.

> For Windows Phone 8.x apps, music and media apps should clean up the MediaCapture object and associated resources in the [Suspending](../windows.applicationmodel.core/coreapplication_suspending.md) event handler and recreate them in the [Resuming](../windows.applicationmodel.core/coreapplication_resuming.md) event handler.

In Windows 8.1 audio only apps, if the [MediaCategory](mediacapturesettings_mediacategory.md) setting is [Other](mediacategory.md), then high latency mode is used. For low latency, set the [MediaCategory](mediacapturesettings_mediacategory.md) setting to [Communications](mediacategory.md).

Adding an in-place editing Media Foundation Transform effect into the capture preview will have no effect on the stream.

Windows 8 UWP apps that have declared both the webcam and microphone capabilities will not function in Windows 8.1 if the user has not enabled both the webcam and microphone privacy settings.

MediaCapture only supports one pass CBR encoding.

**Notes on JPEG:** JPEG types are passthrough only. To capture an image, the image encoding profile can be set to Auto or you need to specify an encoding profile that matches the native type. To add an effect, you need to switch to an uncompressed video native media type, such as NV12 or RGB32.

**Notes on H.264:** If the native type is H.264, you can record using a video media type with type identical to the native type. You cannot add an effect to an H.264 native type stream. To capture video, the image encoding profile can be set to Auto or you need to specify an encoding profile that matches the native type.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | CreateFrameReaderAsync(MediaFrameSource) |
| 1607 | 14393 | CreateFrameReaderAsync(MediaFrameSource,String) |
| 1607 | 14393 | CreateFrameReaderAsync(MediaFrameSource,String,BitmapSize) |
| 1607 | 14393 | FrameSources |
| 1607 | 14393 | PauseRecordWithResultAsync |
| 1607 | 14393 | RemoveEffectAsync |
| 1607 | 14393 | StopRecordWithResultAsync |
| 1703 | 15063 | CaptureDeviceExclusiveControlStatusChanged |
| 1703 | 15063 | CreateMultiSourceFrameReaderAsync |
| 2004 | 19041 | CreateRelativePanelWatcher |

## -examples

The following code sample shows how to create and initialize a **MediaCapture** object.

[!code-csharp[MediaCaptureVideo_InitMCobject](../windows.media.capture/code/MediaCaptureVideo/csharp/MainPage.xaml.cs#SnippetMediaCaptureVideo_InitMCobjectCS)]

For info about how to handle suspension, see [Handle app suspend](/windows/uwp/launch-resume/suspend-an-app).

[!code-xaml[MediaCapturePreviewXAML](../windows.media.capture/code/MediaCapture/csharp/MainPage.xaml#SnippetMediaCapturePreviewXAML)]

[!code-csharp[MediaCapturePreviewCode](../windows.media.capture/code/MediaCapture/csharp/MainPage.xaml.cs#SnippetMediaCapturePreviewCode)]

## -see-also

[Camera](/windows/uwp/audio-video-camera/camera), [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [Media capture sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/CameraStarterKit), [Camera capture UI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/CameraCaptureUI%20Sample%20(Windows%208)), [Camera options UI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/CameraOptionsUI%20Sample%20(Windows%208)), [Device enumeration sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/DeviceEnumerationAndPairing), [Real-Time communication sample](hhttps://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Real-time%20communication%20sample%20(Windows%208)), [Media extension sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Media%20extensions%20sample), [Supported audio and video formats](/previous-versions/windows/apps/hh986969(v=win.10)), [Real-time communication sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620600), [Camera preview frame sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraGetPreviewFrame), [Video stabilization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraVideoStabilization), [Holographic Mixed Reality Capture sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicMixedRealityCapture)

## -capabilities

backgroundMediaRecording
microphone, webcam