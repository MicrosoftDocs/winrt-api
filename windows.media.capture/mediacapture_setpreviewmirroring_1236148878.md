---
-api-id: M:Windows.Media.Capture.MediaCapture.SetPreviewMirroring(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void SetPreviewMirroring(System.Boolean value)
-->

# Windows.Media.Capture.MediaCapture.SetPreviewMirroring

## -description
Enables or disables horizontal mirroring of the video preview stream. This is not the preferred method for mirroring. See the Remarks section below for details.

## -parameters
### -param value
True to enable mirroring; false to disable mirroring.
<!--This changed to a bool in fbl_multimedia. Description is for the updated API-->

## -remarks
Horizontal mirroring is useful for video conferencing or video chat applications, because the users typically want to see a reflected image of themselves. The non-mirrored view can look strange, because we are used to seeing ourselves in a mirror.

To mirror the preview video, apps should instead use the following method. Windows app using JavaScript should use the [msHorizontalMirror](/previous-versions/hh772562(v=vs.85)) property of the [video](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/video) object. UWP apps using C++, C#, or Visual Basic should use the [FlowDirection](../windows.ui.xaml/flowdirection.md) property on the [CaptureElement](../windows.ui.xaml.controls/captureelement.md).

SetPreviewMirroring can potentially be used as a performance optimization on some devices

For how-to guidance on handling orientation and mirroring when using the camera, see [Handle device orientation with MediaCapture](/windows/uwp/audio-video-camera/handle-device-orientation-with-mediacapture).

## -examples

## -see-also


## -capabilities
backgroundMediaRecording
microphone, webcam
