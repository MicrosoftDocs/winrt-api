---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Stop
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Stop()
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Stop

## -description
Stops the account watcher.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
You can begin the process of stopping a [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) by calling the [Stop](mobilebroadbandaccountwatcher_stop.md) method. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) fully stops, the [Stopped](mobilebroadbandaccountwatcher_stopped.md) event is raised. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) has been stopped, it no longer raises account-related events.

You can query the status of a watcher using the [Status](mobilebroadbandaccountwatcher_status.md) property to determine if the watcher was aborted due to an unexpected internal error condition.

## -examples

## -see-also
