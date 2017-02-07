---
-api-id: M:Windows.Media.Capture.AppBroadcastStreamReader.TryGetNextAudioFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Capture.AppBroadcastStreamAudioFrame TryGetNextAudioFrame()
-->

# Windows.Media.Capture.AppBroadcastStreamReader.TryGetNextAudioFrame

## -description
Attempts to obtain an [AppBroadcastStreamAudioFrame](appbroadcaststreamaudioframe.md) object representing the latest audio frame from the broadcast stream.

## -returns
If successful, the latest audio frame from the broadcast stream; otherwise, null.

## -remarks
In order to avoid unnecessary copying of frame data, this method returns a reference to frame data stored in a circular buffer. After acquiring a frame, you should make a copy of frame data and release the buffer as quickly as possible.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings