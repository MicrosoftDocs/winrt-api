---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceGroup.FindAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.Frames.MediaFrameSourceGroup>> FindAllAsync()
-->

# Windows.Media.Capture.Frames.MediaFrameSourceGroup.FindAllAsync

## -description
Asynchronously retrieves a list of the available media frame source groups on the current device.

## -returns
An asynchronous operation that returns a list of [MediaFrameSourceGroup](mediaframesourcegroup.md) objects upon completion.

## -remarks
If MediaFrameSourceGroup.FindAllAsync() returns zero groups, request the Webcam capability in your Package.appxmanifest file.

## -examples

## -see-also
