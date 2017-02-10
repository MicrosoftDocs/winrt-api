---
-api-id: P:Windows.Media.Capture.SourceSuspensionChangedEventArgs.IsAudioSuspended
-api-type: winrt property
---

<!-- Property syntax
public bool IsAudioSuspended { get; }
-->

# Windows.Media.Capture.SourceSuspensionChangedEventArgs.IsAudioSuspended

## -description
Gets whether the screen capture of audio is currently suspended.

## -property-value
Whether the screen capture of audio is currently suspended.

## -remarks
The recording of audio during screen capture is suspended when protected audio content, such as content protected by DRM, is played. You can also check the [IsAudioSuspended](screencapture_isaudiosuspended.md) property to determine if audio capture is suspended outside of the [SourceSuspensionChanged](screencapture_sourcesuspensionchanged.md) event handler.

## -examples

## -see-also
