---
-api-id: T:Windows.Media.Capture.AppBroadcastHeartbeatRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastHeartbeatRequestedEventArgs : Windows.Media.Capture.IAppBroadcastHeartbeatRequestedEventArgs
-->

# Windows.Media.Capture.AppBroadcastHeartbeatRequestedEventArgs

## -description
Provides data for the [AppBroadcastBackgroundService.HeartbeatRequested](appbroadcastbackgroundservice_heartbeatrequested.md) event which is raised by the system periodically to confirm that the broadcasting background task is currently active.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
In the handler for the [HeartbeatRequested](appbroadcastbackgroundservice_heartbeatrequested.md) event, set the [Handled](appbroadcastheartbeatrequestedeventargs_handled.md) property to true to confirm that the broadcasting background task is currently active.

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
