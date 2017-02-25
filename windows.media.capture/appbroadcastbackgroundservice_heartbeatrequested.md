---
-api-id: E:Windows.Media.Capture.AppBroadcastBackgroundService.HeartbeatRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HeartbeatRequested<Windows.Media.Capture.AppBroadcastBackgroundService,  Windows.Media.Capture.AppBroadcastHeartbeatRequestedEventArgs>
-->

# Windows.Media.Capture.AppBroadcastBackgroundService.HeartbeatRequested

## -description
Raised by the system periodically to confirm that the broadcasting background task is currently active.

## -remarks
Set the [Handled](appbroadcastheartbeatrequestedeventargs_handled.md) property to true to confirm that the background task is currently active. Failure to respond to this event and set the **Handled** property to true can result in the background task for the broadcast app being terminated.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings