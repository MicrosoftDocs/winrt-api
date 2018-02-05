---
-api-id: P:Windows.Media.Capture.MediaCaptureSettings.CameraSoundRequiredForRegion
-api-type: winrt property
---

<!-- Property syntax
public bool CameraSoundRequiredForRegion { get; }
-->

# Windows.Media.Capture.MediaCaptureSettings.CameraSoundRequiredForRegion

## -description
Gets a value that indicates if the device’s region requires that a sound be played when a photo or video is captured.

## -property-value
**true** if the device’s region requires that a sound be played when a photo or video is captured; otherwise, **false**. An app may play a sound during photo or video capture even if it is not required by the device’s region.

## -remarks
App developers can use this information to determine if they should suppress playing a sound when the device takes a picture since the operating system will play a sound if it is required by the device's region. 

You can specify that the system should always play a shutter sound when a photo is captured by setting the [MediaCaptureInitializationSettings.AlwaysPlaySystemShutterSound](mediacaptureinitializationsettings_alwaysplaysystemshuttersound.md) property to **true** when initializing the [MediaCapture](mediacapture.md) object.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
