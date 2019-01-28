---
-api-id: M:Windows.Media.Capture.MediaCapture.GetPreviewFrameAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.VideoFrame> GetPreviewFrameAsync()
-->

# Windows.Media.Capture.MediaCapture.GetPreviewFrameAsync

## -description
Gets a preview frame from the capture device.

## -returns
An asynchronous operation that returns a [VideoFrame](../windows.media/videoframe.md) on successful completion.

## -remarks
This method returns the preview frame in the current format of the capture device without copying or converting the frame. To get the preview frame in another format, use the [GetPreviewFrameAsync(VideoFrame)](mediacapture_getpreviewframeasync_440877418.md) overload and pass in a [VideoFrame](mediacapture_getpreviewframeasync_440877418.md) with your desired format.

For how-to guidance on preview frames, see [Get a preview frame](https://msdn.microsoft.com/windows/uwp/audio-video-camera/get-a-preview-frame).

## -examples

## -see-also
[GetPreviewFrameAsync(VideoFrame)](mediacapture_getpreviewframeasync_440877418.md), [Get a preview frame](https://msdn.microsoft.com/windows/uwp/audio-video-camera/get-a-preview-frame)
## -capabilities
backgroundMediaRecording
