---
-api-id: T:Windows.Media.Audio.AudioPlaybackConnectionState
-api-type: winrt enumeration
---

## -description

Specifies the connection state of an [AudioPlaybackConnection](audioplaybackconnection.md).

## -enum-fields

### -field Closed:0
The connection is closed.

### -field Opened:1
The connection is open.

## -remarks

Open a connection by calling [Open](audioplaybackconnection_open_389234318.md) or [OpenAsync](audioplaybackconnection_openasync_171309613.md).

Get the current state of a connection by checking the [State](audioplaybackconnection_state.md) property. Receive notifiations when the connection state changes by implementing a handler for the [StateChanged](audioplaybackconnection_statechanged.md) event.

## -see-also

[Open](audioplaybackconnection_open_389234318.md), [OpenAsync](audioplaybackconnection_openasync_171309613.md), [State](audioplaybackconnection_state.md), [StateChanged](audioplaybackconnection_statechanged.md)

## -examples
