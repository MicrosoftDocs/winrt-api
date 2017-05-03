---
-api-id: E:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Stopped
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Stopped<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,  object>
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Stopped

## -description
Occurs when the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) has stopped.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
You can begin the process of stopping a [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) by calling the [Stop](mobilebroadbandaccountwatcher_stop.md) method. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) fully stops, the [Stopped](mobilebroadbandaccountwatcher_stopped.md) event is raised.

You can query the status of a watcher using the [Status](mobilebroadbandaccountwatcher_status.md) property to determine if the watcher was aborted due to an unexpected internal error condition.

## -examples

## -see-also
