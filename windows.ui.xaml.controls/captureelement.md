---
-api-id: T:Windows.UI.Xaml.Controls.CaptureElement
-api-type: winrt class
---

<!-- Class syntax.
public class CaptureElement : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.ICaptureElement
-->

# Windows.UI.Xaml.Controls.CaptureElement

## -description
 Renders a stream from a capture device, such as a camera or webcam.  [CaptureElement](captureelement.md) is used in conjunction with the [Windows.Media.Capture.MediaCapture](../windows.media.capture/mediacapture.md) API, and must be hooked up in the code behind.

## -xaml-syntax
```xaml
<CaptureElement .../>
```


## -remarks
 [CaptureElement](captureelement.md) is used in conjunction with the [Windows.Media.Capture.MediaCapture](../windows.media.capture/mediacapture.md)  API. Make sure your project has specified device capabilities for Webcam and Microphone to use this API. For more info on how to use [CaptureElement](captureelement.md), see [Capture photos and video with MediaCapture](http://msdn.microsoft.com/library/1361e82a-202f-40f7-9239-56f00dfca54b).

Use the [MediaCapture](../windows.media.capture/mediacapture.md) object to control the stream and set options on the capture device. The [CaptureElement](captureelement.md) is the UI portion of the stream that is associated with the [MediaCapture](../windows.media.capture/mediacapture.md).

You can use at most one [CaptureElement](captureelement.md) to render a stream from a single capture device.

> [!NOTE]
> If your app manually sets the size of the **CaptureElement** control, you must make sure that the dimensions of the control do not exceed the device's native display resolution.

## -examples
Here's some code that shows how to capture video from a camera with a [MediaCapture](../windows.media.capture/mediacapture.md) control and display the preview with the [CaptureElement](captureelement.md).

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
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [MediaCapture](../windows.media.capture/mediacapture.md), [Capture photos and video with MediaCapture](http://msdn.microsoft.com/library/1361e82a-202f-40f7-9239-56f00dfca54b), [Media capture sample](http://go.microsoft.com/fwlink/p/?linkid=241428), [Camera capture UI sample](http://go.microsoft.com/fwlink/p/?linkid=249441), [Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83)