---
-api-id: M:Windows.Media.Capture.MediaCapture.InitializeAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InitializeAsync()
-->

# Windows.Media.Capture.MediaCapture.InitializeAsync

## -description
Initializes the [MediaCapture](mediacapture.md) object, using default settings.

## -returns
Returns a [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
InitializeAsync will launch a consent prompt to get the user's permission for the app to access the microphone or camera. InitializeAsync should be called from the main UI thread of your app. In apps that use C# or C++, the first use of the [MediaCapture](mediacapture.md) object to call InitializeAsync should be on the STA thread. Calls from an MTA thread may result in undefined behavior.

For how-to guidance on initializing and shutting down the **MediaCapture** object, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

Starting with Windows, version 1803, **InitializeAsync** will return an error or throw an exception with an error code of 0xC00DAFC8 (MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT) when an unsupported capture device is detected. You can check for this error code and update your UI to alert to the user.

## -examples

## -see-also
[InitializeAsync(MediaCaptureInitializationSettings)](mediacapture_initializeasync_837464435.md), [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture)

## -capabilities
backgroundMediaRecording
microphone, webcam
