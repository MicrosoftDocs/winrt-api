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
Multiple apps can simultaneously acquire frames from the same [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md), but only a single app can acquire exclusive control of and modify the settings for the frame source. Set **SharingMode** to [ExclusiveControl](mediacapturesharingmode.md) if you need to adjust the configuration of any of the frame sources included the requested [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md). However, this means that the call to [InitializeAsync](mediacapture_initializeasync.md) will fail if another app already has exclusive control of one of the frame sources in the group. If you only need to acquire frames without modifying the configuration, set **SharingMode** to [SharedReadOnly](mediacapturesharingmode.md).

## -examples

## -see-also
