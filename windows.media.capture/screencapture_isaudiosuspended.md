---
-api-id: P:Windows.Media.Capture.ScreenCapture.IsAudioSuspended
-api-type: winrt property
---

<!-- Property syntax
public bool IsAudioSuspended { get; }
-->

# Windows.Media.Capture.ScreenCapture.IsAudioSuspended

## -description
Gets whether the screen capture of audio is currently suspended.

## -property-value
Whether the screen capture audio is currently suspended.

## -remarks
> [!IMPORTANT]
> The **ScreenCapture** feature is only supported for mobile devices running Windows Phone 8.1. This API is not supported on Windows 10.

The recording of audio during screen capture is suspended when protected audio content, such as content protected by DRM, is played. You can check this property before beginning a screen capture and you can also handle the [SourceSuspensionChanged](screencapture_sourcesuspensionchanged.md) event to be notified if audio is suspended while you are recording.

## -examples

## -see-also
