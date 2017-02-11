---
-api-id: P:Windows.Media.Capture.MediaCaptureVideoProfile.SupportedPreviewMediaDescription
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription> SupportedPreviewMediaDescription { get; }
-->

# Windows.Media.Capture.MediaCaptureVideoProfile.SupportedPreviewMediaDescription

## -description
Gets a list of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) objects that represent supported video device settings for video preview.

## -property-value
A list of [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) objects that represent supported video device settings for video preview.

## -remarks
You configure the capture device to use a particular [MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md) for photo capture by using the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object. It is important that the video profile media description value you use when configuring the device is compatible with the other initialization settings. For more information on how to correctly use media profile descriptions in the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md), see [MediaCaptureInitializationSettings.PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md).

## -examples

## -see-also
[MediaCaptureVideoProfileMediaDescription](mediacapturevideoprofilemediadescription.md), [MediaCaptureInitializationSettings::PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md)