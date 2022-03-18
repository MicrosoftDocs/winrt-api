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

The encoding quality **Auto** is a special preset that fills in the proper settings based on the current camera settings. Settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as [CreateM4a](mediaencodingprofile_createm4a_1230065862.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.

> [!NOTE]
> It is possible to create a **MediaEncodingProfile** that is not supported on a particular device. For example, you may successfully call [CreateMp3](mediaencodingprofile_createmp3_1449480444.md), but if an mp3 encoder is not present on the device, attempting to encode audio with the properties returned from this method will fail. For a list of the codecs present by default for each device family, see [Supported codecs.](/windows/uwp/audio-video-camera/supported-codecs).

> [!NOTE]
> Only video encoding profile types support the encoding quality setting of Auto. Audio profiles don’t support this setting and will generate an error when the setting is used. For example: If you create a profile using [MediaEncodingProfile.CreateMp3](/uwp/api/windows.media.mediaproperties.mediaencodingprofile.createmp3#Windows_Media_MediaProperties_MediaEncodingProfile_CreateMp3_Windows_Media_MediaProperties_AudioEncodingQuality_) with [AudioEncodingQuality.Auto](/uwp/api/windows.media.mediaproperties.audioencodingquality) and then call [PrepareStreamTranscodeAsync](/uwp/api/windows.media.transcoding.mediatranscoder.preparestreamtranscodeasync), you will receive a [NullReferenceException](/dotnet/api/system.nullreferenceexception?view=dotnet-uwp-10.0&preserve-view=true) error. In this case you will need to choose an encoding quality setting other than Auto to allow you to create a functional profile.

For how-to guidance for using **MediaEncodingProfile** to set the encoding properties for captured images, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture). For information on using **MediaEncodingProfile** when transcoding media files, see [Transcode media files](/windows/uwp/audio-video-camera/transcode-media-files).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CreateAlac |
| 1703 | 15063 | CreateFlac |
| 1703 | 15063 | CreateHevc |
| 1709 | 16299 | GetAudioTracks |
| 1709 | 16299 | GetVideoTracks |
| 1709 | 16299 | SetAudioTracks |
| 1709 | 16299 | SetVideoTracks |
| 1803 | 17134 | GetTimedMetadataTracks |
| 1803 | 17134 | SetTimedMetadataTracks |

## -examples

## -see-also

[Transcoding media sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MediaTranscoding), [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [Transcode media files](/windows/uwp/audio-video-camera/transcode-media-files)
