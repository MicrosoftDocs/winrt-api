---
-api-id: P:Windows.Media.Capture.ScreenCapture.IsVideoSuspended
-api-type: winrt property
---

<!-- Property syntax
public bool IsVideoSuspended { get; }
-->

# Windows.Media.Capture.ScreenCapture.IsVideoSuspended

## -description
Gets whether the screen capture of video is currently suspended.

## -property-value
Whether the screen capture of video is currently suspended.

## -remarks
> [!IMPORTANT]
> The **ScreenCapture** feature is only supported for mobile devices running Windows Phone 8.1. This API is not supported on Windows 10.

The recording of video during screen capture is suspended when protected content, such as an incoming phone call notification, is displayed on the screen. You can check this property before beginning a screen capture and you can also handle the [SourceSuspensionChanged](screencapture_sourcesuspensionchanged.md) event to be notified if video is suspended while you are recording.

## -examples

## -see-also
