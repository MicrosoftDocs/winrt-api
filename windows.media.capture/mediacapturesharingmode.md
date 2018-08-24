---
-api-id: T:Windows.Media.Capture.MediaCaptureSharingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.MediaCaptureSharingMode : int
-->

# MediaCaptureSharingMode

## -description
Specifies the media frame source sharing mode for a [MediaCapture](mediacapture.md) object.

## -enum-fields
### -field ExclusiveControl:0
The [MediaCapture](mediacapture.md) should have exclusive control of one or more of the frame sources specified in [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md).

### -field SharedReadOnly:1
The [MediaCapture](mediacapture.md) can acquire frames from the frame sources specified in [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md) but can't adjust the configuration of the frame sources.


## -remarks
Specify the [MediaCapture](mediacapturememorypreference.md) sharing mode by setting the [SharingMode](mediacaptureinitializationsettings_sharingmode.md) property of the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object before calling [MediaCapture.InitializeAsync](/uwp/api/windows.media.capture.mediacapture.initializeasync).

## -examples

## -see-also
## -capabilities
backgroundMediaRecording
