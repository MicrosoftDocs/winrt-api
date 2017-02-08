---
-api-id: M:Windows.Media.Capture.MediaCapture.InitializeAsync(Windows.Media.Capture.MediaCaptureInitializationSettings)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InitializeAsync(Windows.Media.Capture.MediaCaptureInitializationSettings mediaCaptureInitializationSettings)
-->

# Windows.Media.Capture.MediaCapture.InitializeAsync

## -description
Initializes the [MediaCapture](mediacapture.md) object.

## -parameters
### -param mediaCaptureInitializationSettings
The initialization settings.

## -returns
Returns a [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
[InitializeAsync](mediacapture_initializeasync_837464435.md) will launch a consent prompt to get the user's permission for the app to access the microphone or camera. [InitializeAsync](mediacapture_initializeasync_837464435.md) should be called from the main UI thread of your app. In apps that use C# or C++, the first use of the [MediaCapture](mediacapture.md) object to call [InitializeAsync](mediacapture_initializeasync.md) should be on the STA thread. Calls from an MTA thread may result in undefined behavior.

For how-to guidance on initializing and shutting down the **MediaCapture** object, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

## -see-also
[InitializeAsync](mediacapture_initializeasync_315323248.md), [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture)

## -capabilities
webcam, microphone