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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -remarks
You can begin the process of stopping a [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) by calling the [Stop](mobilebroadbandaccountwatcher_stop_1201535524.md) method. When the [MobileBroadbandAccountWatcher](mobilebroadbandaccountwatcher.md) fully stops, the Stopped event is raised.

You can query the status of a watcher using the [Status](mobilebroadbandaccountwatcher_status.md) property to determine if the watcher was aborted due to an unexpected internal error condition.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
