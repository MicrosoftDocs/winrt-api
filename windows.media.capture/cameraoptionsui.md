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
> This API is in the **Desktop** device family which means it can only be used on devices that support that family. To use this API, you must add a reference to the **Windows Desktop Extensions for the UWP** to your app. For more information on device families, see Intro to the [Universal Windows Platform](/windows/uwp/get-started/universal-application-platform-guide).

## -examples
The following example shows how to use this class to display the camera options.

```csharp
private void ShowWebcamSettings()
{
    var mediaCaptureMgr = new Windows.Media.Capture.MediaCapture();
    Windows.Media.Capture.CameraOptionsUI.Show(mediaCaptureMgr);
}
```

## -see-also
[Audio, video, and camera](/windows/uwp/audio-video-camera/index), [Camera capture UI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/CameraCaptureUI%20Sample)

## -capabilities
microphone, webcam
