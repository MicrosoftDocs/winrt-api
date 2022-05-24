---
-api-id: T:Windows.UI.Xaml.Controls.CaptureElement
-api-type: winrt class
---

<!-- Class syntax.
public class CaptureElement : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.ICaptureElement
-->

# Windows.UI.Xaml.Controls.CaptureElement

## -description
 Renders a stream from a capture device, such as a camera or webcam.  CaptureElement is used in conjunction with the [Windows.Media.Capture.MediaCapture](../windows.media.capture/mediacapture.md) API, and must be hooked up in the code behind.


## -xaml-syntax
```xaml
<CaptureElement .../>
```


## -remarks
 CaptureElement is used in conjunction with the [Windows.Media.Capture.MediaCapture](../windows.media.capture/mediacapture.md)  API. Make sure your project has specified device capabilities for Webcam and Microphone to use this API. For more info on how to use CaptureElement, see [Capture photos and video with MediaCapture](/windows/uwp/audio-video-camera/capture-photos-and-video-with-mediacapture).

Use the [MediaCapture](../windows.media.capture/mediacapture.md) object to control the stream and set options on the capture device. The CaptureElement is the UI portion of the stream that is associated with the [MediaCapture](../windows.media.capture/mediacapture.md).

You can use at most one CaptureElement to render a stream from a single capture device.

> [!NOTE]
> If your app manually sets the size of the **CaptureElement** control, you must make sure that the dimensions of the control do not exceed the device's native display resolution.

## -examples
Here's some code that shows how to capture video from a camera with a [MediaCapture](../windows.media.capture/mediacapture.md) control and display the preview with the CaptureElement.

```xaml
<StackPanel>
    <CaptureElement x:Name="myCaptureElement"         
                    Width="320" Height="240"/>
    <Button Click="Button_Click">Click me to see a preview</Button>
</StackPanel>

```

```csharp

// You must specify capabilities for Webcam and Microphone in your
// app manifest for this code to work.

private async void Button_Click(object sender, RoutedEventArgs e) 
{           
    // Using Windows.Media.Capture.MediaCapture APIs 
    // to stream from webcam
    MediaCapture mediaCaptureMgr = new MediaCapture();
    await mediaCaptureMgr.InitializeAsync();

    // Start capture preview.                
    myCaptureElement.Source = mediaCaptureMgr;
    await mediaCaptureMgr.StartPreviewAsync();
}

```



## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [MediaCapture](../windows.media.capture/mediacapture.md), [Capture photos and video with MediaCapture](/windows/uwp/audio-video-camera/capture-photos-and-video-with-mediacapture), [Media capture sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Media%20capture%20using%20capture%20device%20sample), [Camera capture UI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/CameraCaptureUI%20Sample), [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic)
