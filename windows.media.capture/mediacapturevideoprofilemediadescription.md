---
-api-id: T:Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription
-api-type: winrt class
---

<!-- Class syntax.
public class MediaCaptureVideoProfileMediaDescription : Windows.Media.Capture.IMediaCaptureVideoProfileMediaDescription
-->

# Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription

## -description
Represents a description of media that is supported by a video profile.

## -remarks
An instance of MediaCaptureVideoProfileMediaDescription defines a group of capture settings that are supported by a video profile. For example, a single video profile may support recording 720p video at 30 fps with HDR video support and also support recording 1080p video at 30 fps without HDR video support. In this case, each of these would be represented by a MediaCaptureVideoProfileMediaDescription object in the [SupportedRecordMediaDescription](mediacapturevideoprofile_supportedrecordmediadescription.md) list of the video profile. Each profile contains separate lists of media descriptions for photo capture, preview, and video recording. For more information on video profiles, see [MediaCaptureVideoProfile](mediacapturevideoprofile.md).

You configure the capture device to use a particular MediaCaptureVideoProfileMediaDescription by using the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object. It is important that the video profile media description values you use when configuring the device are compatible with the other initialization settings. For more information on how to correctly use media profile descriptions in the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md), see [MediaCaptureInitializationSettings.PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md), [MediaCaptureInitializationSettings.PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), and [MediaCaptureInitializationSettings.RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md).

For how-to guidance for working with video profiles, see [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Properties |
| 1803 | 17134 | Subtype |

## -examples

## -see-also
[MediaCaptureVideoProfile](mediacapturevideoprofile.md), [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md), [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles)
## -capabilities
backgroundMediaRecording
