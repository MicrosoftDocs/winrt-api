---
-api-id: T:Windows.Media.MediaProperties.AudioEncodingProperties
-api-type: winrt class
---

<!-- Class syntax.
public class AudioEncodingProperties : Windows.Media.MediaProperties.IAudioEncodingProperties, Windows.Media.MediaProperties.IAudioEncodingProperties2, Windows.Media.MediaProperties.IAudioEncodingPropertiesWithFormatUserData, Windows.Media.MediaProperties.IMediaEncodingProperties
-->

# Windows.Media.MediaProperties.AudioEncodingProperties

## -description
Describes the encoding properties of an audio stream.

## -remarks
The encoding quality **Auto** is a special preset that fills in the proper settings based on the current camera settings. Settings that are manually modified are ignored. For example, if you create a preset profile using one of the static create methods, such as [CreateWav](mediaencodingprofile_createwav_1267537239.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.

> [!NOTE]
> It is possible to create an **AudioEncodingProperties** that is not supported on a particular device. For example, you may successfully call [CreateMp3](audioencodingproperties_createmp3_946859991.md), but if an mp3 encoder is not present on the device, attempting to encode audio with the properties returned from this method will fail. For a list of the codecs present by default for each device family, see [Supported codecs.](/windows/uwp/audio-video-camera/supported-codecs).

For how-to guidance for setting the encoding properties for captured audio, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CreateAlac |
| 1703 | 15063 | CreateFlac |
| 1703 | 15063 | IsSpatial |
| 1803 | 17134 | Copy |

## -examples

## -see-also
[Supported codecs.](/windows/uwp/audio-video-camera/supported-codecs), [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture)
