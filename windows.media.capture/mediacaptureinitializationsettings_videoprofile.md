---
-api-id: P:Windows.Media.Capture.MediaCaptureInitializationSettings.VideoProfile
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCaptureVideoProfile VideoProfile { get;  set; }
-->

# Windows.Media.Capture.MediaCaptureInitializationSettings.VideoProfile

## -description
Gets or sets the video profile which provides hints to the driver to allow it to optimize for different capture scenarios.

## -property-value
The video profile.

## -remarks
Video profiles provide a simple way to configure the video capture device with a group of settings that are guaranteed to work with a particular capture device and are optimized for your desired capture scenario. There is a set of known video profiles that the system provides for common scenarios, such as capturing high-quality photos during video capture or video conferencing. To get a list of the known video profiles for a given video device, use [MediaCapture::FindKnownVideoProfiles](mediacapture_findknownvideoprofiles.md). Some hardware vendors may expose other video profiles that you can get by calling [MediaCapture::FindAllVideoProfiles](mediacapture_findallvideoprofiles.md). For more information on video profiles, see [MediaCaptureVideoProfile](mediacapturevideoprofile.md).

The value you use for this property determines how the system handles the values for other properties of the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md).
+ If you set [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) to a valid [MediaCaptureVideoProfile](mediacapturevideoprofile.md) object, the system will use the driver hints associated with the profile and will use the media description values you specify for the [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md), [PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), and [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md) properties.
+ If you set [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) to a valid [MediaCaptureVideoProfile](mediacapturevideoprofile.md) object and you don't set either the [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md), [PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), or [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md) properties, the system will use the driver hints associated with the profile and use the first (0 index) entry in the profile's [SupportedPhotoMediaDescription](mediacapturevideoprofile_supportedphotomediadescription.md), [SupportedPreviewMediaDescription](mediacapturevideoprofile_supportedpreviewmediadescription.md), and [SupportedRecordMediaDescription](mediacapturevideoprofile_supportedrecordmediadescription.md) lists as the media description for the respective properties.
+ If you set [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) to null, the values you provide for [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md), [PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), and [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md) are used, but no optimization hints are sent to the capture device. Also, if the value you provide for [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md) does not match an existing video profile, errors or glitches may occur when capture is started.
+ If the value of [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) is not set at all - not even to null - then the system ignores the value of [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md), [PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), and [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md) and reverts to the legacy behavior before the video profile APIs were introduced.


Before using video profiles, you should check the value returned by [MediaCapture::IsVideoProfileSupported](mediacapture_isvideoprofilesupported.md) to make sure that video profiles are supported by the capture device.

For how-to guidance on using video profiles, see [Discover and select camera capabilities with camera profiles](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/camera-profiles)

## -examples

## -see-also
