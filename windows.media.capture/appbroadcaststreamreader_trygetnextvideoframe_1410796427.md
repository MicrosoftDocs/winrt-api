---
-api-id: M:Windows.Media.Capture.AppBroadcastStreamReader.TryGetNextVideoFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Capture.AppBroadcastStreamVideoFrame TryGetNextVideoFrame()
-->

# Windows.Media.Capture.AppBroadcastStreamReader.TryGetNextVideoFrame

## -description
Attempts to obtain an [AppBroadcastStreamVideoFrame](appbroadcaststreamvideoframe.md) object representing the latest video frame from the broadcast stream.

## -returns
If successful, the latest video frame from the broadcast stream; otherwise, null.

## -remarks
In order to avoid unnecessary copying of frame data, this method returns a reference to frame data stored in a circular buffer. After acquiring a frame, you should make a copy of frame data and release the buffer as quickly as possible.

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
