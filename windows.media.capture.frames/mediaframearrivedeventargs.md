---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameArrivedEventArgs : Windows.Media.Capture.Frames.IMediaFrameArrivedEventArgs
-->

# Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs

## -description
Provides data for the [MediaFrameReader.FrameArrived](mediaframereader_framearrived.md) event.

## -remarks
Get an instance of this class by handling the [MediaFrameReader.FrameArrived](mediaframereader_framearrived.md) event. In the event handler, cast the sender as a [MediaFrameReader](mediaframereader.md) and call [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md) to get a [MediaFrameReference](mediaframereference.md) representing the latest frame from the frame source, if one is available.

## -examples

## -see-also
