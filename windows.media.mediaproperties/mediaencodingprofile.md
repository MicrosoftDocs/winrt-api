---
-api-id: T:Windows.Media.MediaProperties.MediaEncodingProfile
-api-type: winrt class
---

<!-- Class syntax.
public class MediaEncodingProfile : Windows.Media.MediaProperties.IMediaEncodingProfile
-->

# Windows.Media.MediaProperties.MediaEncodingProfile

## -description
Describes the encoding profile for an audio or video file. The encoding profile includes descriptions of the audio and video encoding formats, and a description of the media container.

## -remarks
The encoding quality **Auto** is a special preset that fills in the proper settings based on the current camera settings. Settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as [CreateM4a](mediaencodingprofile_createm4a.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.



> [!NOTE]
> It is possible to create a **MediaEncodingProfile** that is not supported on a particular device. For example, you may successfully call [CreateMp3](mediaencodingprofile_createmp3.md), but if an mp3 encoder is not present on the device, attempting to encode audio with the properties returned from this method will fail. For a list of the codecs present by default for each device family, see [Supported codecs.](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/supported-codecs).

For how-to guidance for using **MediaEncodingProfile** to set the encoding properties for captured images, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture). For information on using **MediaEncodingProfile** when transcoding media files, see [Transcode media files](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/transcode-media-files).

## -examples

## -see-also
[Transcoding media sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620569), [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [Transcode media files](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/transcode-media-files)