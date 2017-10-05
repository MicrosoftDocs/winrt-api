---
-api-id: P:Windows.Media.Capture.MediaCaptureVideoProfile.SupportedRecordMediaDescription
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription> SupportedRecordMediaDescription { get; }
-->

# Windows.Media.Capture.MediaCaptureVideoProfile.SupportedRecordMediaDescription

## -description
Gets a list of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) objects that represent supported video device settings for video recording.

## -property-value
A list of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) objects that represent supported video device settings for video recording.

## -remarks
You configure the capture device to use a particular [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) for photo capture by using the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object. It is important that the video profile media description value you use when configuring the device is compatible with the other initialization settings. For more information on how to correctly use media profile descriptions in the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md), see [MediaCaptureInitializationSettings.RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md).

## -examples

## -see-also
[MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md), [MediaCaptureInitializationSettings::RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md)
## -capabilities
backgroundMediaRecording
