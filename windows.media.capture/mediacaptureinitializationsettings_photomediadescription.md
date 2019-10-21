---
-api-id: P:Windows.Media.Capture.MediaCaptureInitializationSettings.PhotoMediaDescription
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription PhotoMediaDescription { get;  set; }
-->

# Windows.Media.Capture.MediaCaptureInitializationSettings.PhotoMediaDescription

## -description
Gets or sets the media description for photo capture.

## -property-value
The media description for photo capture.

## -remarks
An instance of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) defines a group of capture settings that are supported by a video profile. For example, one [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) object could represent settings for recording 720p video at 30 fps with HDR video and another could represent settings for recording 1080p video at 30 fps without HDR video support. A [MediaCaptureVideoProfile](mediacapturevideoprofile.md) object contains separate lists of supported media descriptions for photo capture, preview, and video recording that are supported for that profile. For more information on video profiles, see [MediaCaptureVideoProfile](mediacapturevideoprofile.md).

The way the system uses the **PhotoMediaDescription** property depends on the value of the [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) property.
+ If you set [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) to a non-null value and you set PhotoMediaDescription to a value in the video profile's [SupportedPhotoMediaDescription](mediacapturevideoprofile_supportedphotomediadescription.md) list, the system will use your provided media description and will provide optimization hints to the driver based on the profile you specify.
+ If you set [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) to a non-null value and the value of PhotoMediaDescription is not set, then the system will use the first entry in the video profile's [SupportedPhotoMediaDescription](mediacapturevideoprofile_supportedphotomediadescription.md) list as the media description.
+ If the value of [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) is not set at all then the system ignores the value of PhotoMediaDescription and reverts to the legacy behavior before the video profile APIs were introduced.


## -examples

## -see-also
[PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md), [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md)
## -capabilities
backgroundMediaRecording
