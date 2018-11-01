---
-api-id: T:Windows.Media.Capture.MediaCaptureInitializationSettings
-api-type: winrt class
---

<!-- Class syntax.
public class MediaCaptureInitializationSettings : Windows.Media.Capture.IMediaCaptureInitializationSettings, Windows.Media.Capture.IMediaCaptureInitializationSettings2, Windows.Media.Capture.IMediaCaptureInitializationSettings3, Windows.Media.Capture.IMediaCaptureInitializationSettings4, Windows.Media.Capture.IMediaCaptureInitializationSettings5, Windows.Media.Capture.IMediaCaptureInitializationSettings6
-->

# Windows.Media.Capture.MediaCaptureInitializationSettings

## -description

Contains initialization settings for the [MediaCapture](mediacapture.md) object which are passed to the [MediaCapture.InitializeAsync](mediacapture_initializeasync_315323248.md) method.

## -remarks

For how-to guidance on initializing and shutting down the **MediaCapture** object, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

The following example initializes the **MediaCaptureInitializationSettings**. Call [InitializeAsync](mediacapture_initializeasync_837464435.md) with these settings to initialize a [MediaCapture](mediacapture.md) object.

[!code-csharp[MediaCaptureVideo_InitSettings](../windows.media.capture/code/MediaCaptureVideo/csharp/MainPage.xaml.cs#SnippetMediaCaptureVideo_InitSettingsCS)]

[!code-js[MediaCaptureVideo_InitSettings](../windows.media.capture/code/MediaCaptureVideo/javascript/default.js#SnippetMediaCaptureVideo_InitSettings)]

## -see-also

[Camera profiles sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraProfile), [Video stabilization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraVideoStabilization)

## -capabilities

backgroundMediaRecording
microphone, webcam
