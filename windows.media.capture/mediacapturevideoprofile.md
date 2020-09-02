---
-api-id: T:Windows.Media.Capture.MediaCaptureVideoProfile
-api-type: winrt class
---

<!-- Class syntax.
public class MediaCaptureVideoProfile : Windows.Media.Capture.IMediaCaptureVideoProfile
-->

# Windows.Media.Capture.MediaCaptureVideoProfile

## -description
Represents a video profile that indicates a configuration supported by the video capture device.

## -remarks
Video profiles provide a simple way to configure the video capture device with a group of settings that are guaranteed to work with a particular capture device and are optimized for your desired capture scenario. There is a set of known video profiles that the system provides for common scenarios, such as capturing high-quality photos or video, capturing a photo sequence, or video conferencing. To get a list of the known video profiles for a given video device, use [MediaCapture.FindKnownVideoProfiles](mediacapture_findknownvideoprofiles_875917242.md). Some hardware vendors may expose other video profiles that you can get by calling [MediaCapture.FindAllVideoProfiles](mediacapture_findallvideoprofiles_690787568.md).

A video profile exposes three lists of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) objects, [SupportedPhotoMediaDescription](mediacapturevideoprofile_supportedphotomediadescription.md), [SupportedPreviewMediaDescription](mediacapturevideoprofile_supportedpreviewmediadescription.md), and [SupportedRecordMediaDescription](mediacapturevideoprofile_supportedrecordmediadescription.md). Each item in these lists is a group of settings that are supported for the corresponding operation. For example, a single video profile may support recording 720p video at 30 fps with HDR video support and also support recording 1080p video at 30 fps without HDR video support. In this case, each of these would be represented by a [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) object in the [SupportedRecordMediaDescription](mediacapturevideoprofile_supportedrecordmediadescription.md) list of the video profile.

You configure the capture device to use a particular video profile by using the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object. It is important that the video profile you use when configuring the device is compatible with the other initialization settings. For more information on how to correctly use media profile descriptions in the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md), see [MediaCaptureInitializationSettings.VideoProfile](mediacaptureinitializationsettings_videoprofile.md).

Before using video profiles, you should check the value returned by [MediaCapture.IsVideoProfileSupported](mediacapture_isvideoprofilesupported_190014579.md) to make sure that video profiles are supported by the capture device.

For how-to guidance for working with video profiles, see [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | FrameSourceInfos |
| 1803 | 17134 | Properties |

## -examples

## -see-also
[FindKnownVideoProfiles](mediacapture_findknownvideoprofiles_875917242.md), [FindAllVideoProfiles](mediacapture_findallvideoprofiles_690787568.md), [FindConcurrentProfiles](mediacapture_findconcurrentprofiles_834250833.md), [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md), [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles)
## -capabilities
backgroundMediaRecording
