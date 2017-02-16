---
-api-id: E:Windows.Media.Core.MediaStreamSource.SwitchStreamsRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SwitchStreamsRequested<Windows.Media.Core.MediaStreamSource,  Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs>
-->

# Windows.Media.Core.MediaStreamSource.SwitchStreamsRequested

## -description
Occurs when the [MediaStreamSource](mediastreamsource.md) will stop requesting [MediaStreamSample](mediastreamsample.md) objects for a certain stream and will start requesting [MediaStreamSample](mediastreamsample.md) objects from a different stream instead.

## -remarks
This event can be raised when there are multiple audio stream descriptors or multiple video stream descriptors. Normally, only one audio stream and one video stream will be selected at any given time. This event is raised when the currently selected audio or video stream is replaced by a different stream.

The event is informational. Applications are not required to have a handler for this event.

## -examples

## -see-also
[MediaStreamSourceSwitchStreamsRequestedEventArgs](mediastreamsourceswitchstreamsrequestedeventargs.md)