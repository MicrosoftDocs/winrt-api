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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -remarks
You can begin the process of stopping a [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) by calling the [Stop](mobilebroadbandaccountwatcher_stop.md) method. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) fully stops, the [Stopped](mobilebroadbandaccountwatcher_stopped.md) event is raised. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) has been stopped, it no longer raises account-related events.

You can query the status of a watcher using the [Status](mobilebroadbandaccountwatcher_status.md) property to determine if the watcher was aborted due to an unexpected internal error condition.

Note that you do not need to explicitly stop and start the account watcher on App Suspend/Resume events. Instead, starting and starting the watcher is handled by the API itself.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
