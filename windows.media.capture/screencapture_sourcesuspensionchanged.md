---
-api-id: E:Windows.Media.Capture.ScreenCapture.SourceSuspensionChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SourceSuspensionChanged<Windows.Media.Capture.ScreenCapture,  Windows.Media.Capture.SourceSuspensionChangedEventArgs>
-->

# Windows.Media.Capture.ScreenCapture.SourceSuspensionChanged

## -description
Raised when the suspension of screen captured audio or video changes.

## -remarks
> [!IMPORTANT]
> The **ScreenCapture** feature is only supported for mobile devices running Windows Phone 8.1. This API is not supported on Windows 10.

The capture of audio or video will be suspended when protected content is being played or displayed. You can use [IsAudioSuspended](screencapture_isaudiosuspended.md) or [IsVideoSuspended](screencapture_isvideosuspended.md) to determine whether audio or video is currently suspended. Handle this event to be notified when the suspension of audio or video changes.

## -examples

## -see-also
