---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceController
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameSourceController : Windows.Media.Capture.Frames.IMediaFrameSourceController
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController

## -description
Allows you to get and set properties of a [MediaFrameSource](mediaframesource.md) and to get a [VideoDeviceController](../windows.media.devices/videodevicecontroller.md), which provides camera controls such as exposure, focus, and zoom.

## -remarks
Get an instance of the MediaFrameSourceController class by accessing the [Controller](mediaframesource_controller.md) property of a [MediaFrameSource](mediaframesource.md).

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | GetPropertyByExtendedIdAsync |
| 1703 | 15063 | SetPropertyByExtendedIdAsync |
| 1803 | 17134 | AudioDeviceController |

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
