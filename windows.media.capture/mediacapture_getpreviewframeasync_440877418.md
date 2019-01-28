---
-api-id: M:Windows.Media.Capture.MediaCapture.GetPreviewFrameAsync(Windows.Media.VideoFrame)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.VideoFrame> GetPreviewFrameAsync(Windows.Media.VideoFrame destination)
-->

# Windows.Media.Capture.MediaCapture.GetPreviewFrameAsync

## -description
Gets a preview frame from the capture device, copied into the provided destination [VideoFrame](../windows.media/videoframe.md) and converted into the destination frame's format.

## -parameters
### -param destination
The video frame into which the preview frame will be copied.

## -returns
An asynchronous operation that returns a [VideoFrame](../windows.media/videoframe.md) on successful completion.

## -remarks
To get a preview frame without going through a copy or conversion operation, use the no argument overload of [GetPreviewFrameAsync](mediacapture_getpreviewframeasync_440877418.md).

For how-to guidance on preview frames, see [Get a preview frame](https://msdn.microsoft.com/windows/uwp/audio-video-camera/get-a-preview-frame).

## -examples

## -see-also
[GetPreviewFrameAsync](mediacapture_getpreviewframeasync_211909276.md), [Get a preview frame](https://msdn.microsoft.com/windows/uwp/audio-video-camera/get-a-preview-frame)
## -capabilities
backgroundMediaRecording
