---
-api-id: N:Windows.Media.Capture.Frames
-api-type: winrt namespace
---

# Windows.Media.Capture.Frames

## -description

This namespace provides APIs for obtaining media frames from one or more [MediaFrameSource](mediaframesource.md) objects representing capture devices.

[MediaFrameSourceGroup](mediaframesourcegroup.md) objects are used to discover groups of media frame sources that can be used simultaneously. A [MediaFrameReader](mediaframereader.md) is used to acquire frames from a frame source. Frames can arrive in several different formats depending on what type of media frame source is providing the frames. Frame types include [VideoMediaFrame](videomediaframe.md), [DepthMediaFrame](depthmediaframe.md), [InfraredMediaFrame](infraredmediaframe.md), and [BufferMediaFrame](buffermediaframe.md).

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -remarks

## -examples

## -see-also

[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader), [Camera frames sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraFrames), [Camera stream coordinate mapper sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraStreamCoordinateMapper), [Camera stream correlation sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraStreamCorrelation)