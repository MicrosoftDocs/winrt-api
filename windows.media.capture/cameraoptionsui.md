---
-api-id: T:Windows.Media.Capture.CameraOptionsUI
-api-type: winrt class
---

<!-- Class syntax.
public class CameraOptionsUI 
-->

# Windows.Media.Capture.CameraOptionsUI

## -description
Provides a method for displaying a UI, by which the UI contains options for the capture of photos, audio recordings and videos.

## -remarks
This object is not instantiated directly. Simply use the static [Show](cameraoptionsui_show_30375942.md) method to display the options.

> [!NOTE]
> This API is in the **Desktop** device family which means it can only be used on devices that support that family. To use this API, you must add a reference to the **Windows Desktop Extensions for the UWP** to your app. For more information on device families, see Intro to the [Universal Windows Platform](https://docs.microsoft.com/windows/uwp/get-started/universal-application-platform-guide).

## -examples
The following example shows how to use this class to display the camera options.



[!code-js[MediaCaptureVideo_UIShow](../windows.media.capture/code/MediaCaptureVideo/javascript/default.js#SnippetMediaCaptureVideo_UIShow)]

## -see-also
[Audio, video, and camera](https://docs.microsoft.com/windows/uwp/audio-video-camera/index), [Audio, video, and camera](https://docs.microsoft.com/windows/uwp/audio-video-camera/index), [Camera capture UI sample](http://code.msdn.microsoft.com/windowsapps/CameraCaptureUI-Sample-845a53ac), [Camera options UI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/CameraOptionsUI%20Sample%20(Windows%208)/C%2B%2B)

## -capabilities
microphone, webcam
