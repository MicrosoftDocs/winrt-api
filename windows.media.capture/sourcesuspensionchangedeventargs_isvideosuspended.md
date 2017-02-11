---
-api-id: P:Windows.Media.Capture.SourceSuspensionChangedEventArgs.IsVideoSuspended
-api-type: winrt property
---

<!-- Property syntax
public bool IsVideoSuspended { get; }
-->

# Windows.Media.Capture.SourceSuspensionChangedEventArgs.IsVideoSuspended

## -description
Gets whether the screen capture of audio is currently suspended.

## -property-value
Whether the screen capture of audio is currently suspended.

## -remarks
The recording of video during screen capture is suspended when protected visual content, such as an incoming call notification, is displayed. You can also check the [IsVideoSuspended](screencapture_isvideosuspended.md) property to determine if video capture is suspended outside of the [SourceSuspensionChanged](screencapture_sourcesuspensionchanged.md) event handler.

## -examples

## -see-also
