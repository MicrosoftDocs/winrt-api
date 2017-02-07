---
-api-id: T:Windows.Media.MediaProperties.VideoEncodingProperties
-api-type: winrt class
---

<!-- Class syntax.
public class VideoEncodingProperties : Windows.Media.MediaProperties.IMediaEncodingProperties, Windows.Media.MediaProperties.IVideoEncodingProperties, Windows.Media.MediaProperties.IVideoEncodingProperties2, Windows.Media.MediaProperties.IVideoEncodingProperties3, Windows.Media.MediaProperties.IVideoEncodingProperties4
-->

# Windows.Media.MediaProperties.VideoEncodingProperties

## -description
Describes the format of a video stream.

## -remarks
Properties that are manually set are ignored for [VideoEncodingProperties](videoencodingproperties_videoencodingproperties.md) created from one of the presets encoding profiles: [CreateH264](videoencodingproperties_createh264.md) and [CreateMpeg2](videoencodingproperties_creatempeg2.md).

The encoding quality **Auto** is a special preset that fills in the proper settings based on the current camera settings. Settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as [CreateM4a](mediaencodingprofile_createm4a.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.

> [!NOTE]
> It is possible to create an **VideoEncodingProperties** that is not supported on a particular device. For example, you may successfully call [CreateH264](videoencodingproperties_createh264.md), but if an h264 encoder is not present on the device, attempting to encode video with the properties returned from this method will fail. For a list of the codecs present by default for each device family, see [Supported codecs.](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/supported-codecs).

For how-to guidance for setting the encoding properties for captured audio, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture)