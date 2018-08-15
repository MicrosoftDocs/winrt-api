---
-api-id: E:Windows.Media.Capture.Frames.MediaFrameReader.FrameArrived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FrameArrived<Windows.Media.Capture.Frames.MediaFrameReader,  Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs>
-->

# Windows.Media.Capture.Frames.MediaFrameReader.FrameArrived

## -description
Occurs when a new frame arrives from the media frame source associated with the [MediaFrameReader](mediaframereader.md).

## -remarks
In the handler for the **FrameArrived** event, call [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md) to get a [MediaFrameReference](mediaframereference.md) representing the latest frame from the media frame source.

## -examples

## -see-also