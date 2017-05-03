---
-api-id: M:Windows.Media.Capture.CameraCaptureUI.CaptureFileAsync(Windows.Media.Capture.CameraCaptureUIMode)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CaptureFileAsync(Windows.Media.Capture.CameraCaptureUIMode mode)
-->

# Windows.Media.Capture.CameraCaptureUI.CaptureFileAsync

## -description
Launches the [CameraCaptureUI](cameracaptureui.md) user interface.

## -parameters
### -param mode
Specifies whether the user interface that will be shown allows the user to capture a photo, capture a video, or capture both photos and videos.

## -returns
When this operation completes, a [StorageFile](../windows.storage/storagefile.md) object is returned.

## -remarks
Call [CaptureFileAsync](cameracaptureui_capturefileasync.md) to launch the UI. The user has control over when to start the capture. When the asynchronous operation completes, a [StorageFile](../windows.storage/storagefile.md) object is returned.

## -examples

## -see-also


## -capabilities
webcam, microphone