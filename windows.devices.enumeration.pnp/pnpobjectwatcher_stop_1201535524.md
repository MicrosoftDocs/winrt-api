---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Stop

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Stops raising the events to inform the client that a [PnpObject](pnpobject.md) has been added, updated, or removed.

## -remarks
To stop a search for devices, an app calls Stop.

This call transitions the [PnpObjectWatcher](pnpobjectwatcher.md) to the **Stopping** state and completes immediately. The watcher will transition to the **Stopped** state once all events that are already in the process of being raised have completed.

Callers may wait for the [Stopped](pnpobjectwatcher_stopped.md) event if they need to know when the [PnpObjectWatcher](pnpobjectwatcher.md) has stopped. Callers must wait for the [Stopped](pnpobjectwatcher_stopped.md) event before they can call [Start](pnpobjectwatcher_start_1587696324.md) to restart the watcher. Callers may unsubscribe from events if they do not want to receive any additional events after Stop but do not want to wait for the [Stopped](pnpobjectwatcher_stopped.md) event.

The following diagram shows how the [PnpObjectWatcher](pnpobjectwatcher.md) transitions between the states represented by [DeviceWatcherStatus](../windows.devices.enumeration/devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

## -examples

## -see-also
