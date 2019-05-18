---
-api-id: E:Windows.Media.Core.MediaStreamSource.Paused
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Paused<Windows.Media.Core.MediaStreamSource,  object>
-->

# Windows.Media.Core.MediaStreamSource.Paused

## -description
Occurs when the [MediaStreamSource](mediastreamsource.md) is paused and stops requesting [MediaStreamSample](mediastreamsample.md) objects for an unspecified period of time, but is expected to resume requesting [MediaStreamSample](mediastreamsample.md) objects from the current position.

## -remarks
This event might be raised by the user pressing a “Pause” button in the UI. When the user decides to resume playback, it is likely that the [Starting](mediastreamsource_starting.md) event will indicate that the [MediaStreamSample](mediastreamsample.md) objects should continue to be delivered from the current position. The Paused event serves as a hint to the application that the next [Starting](mediastreamsource_starting.md) event will specify the current position.

The event is informational. Applications are not required to have a handler for this event.

## -examples

## -see-also
