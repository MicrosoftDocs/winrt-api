---
-api-id: P:Windows.Media.Capture.MediaCaptureInitializationSettings.SharingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCaptureSharingMode SharingMode { get;  set; }
-->

# Windows.Media.Capture.MediaCaptureInitializationSettings.SharingMode

## -description
Gets or sets an object that specifies the sharing mode for the [MediaCapture](mediacapture.md).

## -property-value
An object that specifies the sharing mode for the [MediaCapture](mediacapture.md).

## -remarks
Multiple apps can simultaneously acquire frames from the same [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md), but only a single app can acquire exclusive control of and modify the settings for the frame source. Set **SharingMode** to [ExclusiveControl](mediacapturesharingmode.md) if you need to adjust the configuration of any of the frame sources included the requested [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md). However, this means that the call to [InitializeAsync](mediacapture_initializeasync_315323248.md) will fail if another app already has exclusive control of one of the frame sources in the group. If you only need to acquire frames without modifying the configuration, set **SharingMode** to [SharedReadOnly](mediacapturesharingmode.md).

When the **SharingMode** is set to [SharedReadOnly](mediacapturesharingmode.md), some of the MediaCaptureInitializationSettings properties can't be configured. See below table for details.

| **Properties** | **Can be configured in Sharing Mode** |
|----------------|---------------------------------------|
| [AlwaysPlaySystemShutterSound](mediacaptureinitializationsettings_alwaysplaysystemshuttersound.md) | Yes |
| [AudioDeviceId](mediacaptureinitializationsettings_audiodeviceid.md) | Yes |
| [AudioProcessing](mediacaptureinitializationsettings_audioprocessing.md) | Yes |
| [AudioSource](mediacaptureinitializationsettings_audiosource.md) | N/A |
| [DeviceUri](mediacaptureinitializationsettings_deviceuri.md) | Yes |
| [DeviceUriPasswordCredential](mediacaptureinitializationsettings_deviceuripasswordcredential.md) | Yes |
| [MediaCategory](mediacaptureinitializationsettings_mediacategory.md) | Yes |
| [MemoryPreference](mediacaptureinitializationsettings_memorypreference.md) | Yes |
| [PhotoCaptureSource](mediacaptureinitializationsettings_photocapturesource.md) | N/A |
| [PhotoMediaDescription](mediacaptureinitializationsettings_photomediadescription.md) | No |
| [PreviewMediaDescription](mediacaptureinitializationsettings_previewmediadescription.md) | No |
| [RecordMediaDescription](mediacaptureinitializationsettings_recordmediadescription.md) | No |
| [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md) | Yes |
| [StreamingCaptureMode](mediacaptureinitializationsettings_streamingcapturemode.md) | Yes |
| [VideoDeviceId](mediacaptureinitializationsettings_videodeviceid.md) | Yes |
| [VideoProfile](mediacaptureinitializationsettings_videoprofile.md) | No |
| [VideoSource](mediacaptureinitializationsettings_videosource.md) | Yes |

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
