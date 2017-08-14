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
This object is not instantiated directly. Simply use the static [Show](cameraoptionsui_show.md) method to display the options.

> [!NOTE]
> This API is in the **Desktop** device family which means it can only be used on devices that support that family. To use this API, you must add a reference to the **Windows Desktop Extensions for the UWP** to your app. For more information on device families, see Intro to the [Universal Windows Platform](https://msdn.microsoft.com/windows/uwp/get-started/universal-application-platform-guide).

## -examples
The following example shows how to use this class to display the camera options.



[!code-js[MediaCaptureVideo_UIShow](../windows.media.capture/code/MediaCaptureVideo/javascript/default.js#SnippetMediaCaptureVideo_UIShow)]

## -see-also
[Audio, video, and camera](http://msdn.microsoft.com/library/0fc12d26-f1cf-4da7-b5a7-735a5074b74a), [Audio, video, and camera](http://msdn.microsoft.com/library/0fc12d26-f1cf-4da7-b5a7-735a5074b74a), [Camera capture UI sample](http://go.microsoft.com/fwlink/p/?linkid=249441), [Camera options UI sample](http://go.microsoft.com/fwlink/p/?linkid=228588 )

## -capabilities
microphone, webcam
