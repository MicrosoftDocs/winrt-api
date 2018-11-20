---
-api-id: T:Windows.Devices.Enumeration.Pnp.PnpObjectWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class PnpObjectWatcher : Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectWatcher

## -description
Raises events to notify the client that a [PnpObject](pnpobject.md) has been added, updated, or removed from an enumerated collection of Pnp device objects in an incremental and asynchronous way.

## -remarks
An app calls [Start](pnpobjectwatcher_start_1587696324.md) to begin the search for devices. During this initial enumeration, the [PnpObjectWatcher](pnpobjectwatcher.md) raises an [Added](pnpobjectwatcher_added.md) event for each device that's found, until all devices are found. The [PnpObjectWatcher](pnpobjectwatcher.md) raises an [EnumerationCompleted](pnpobjectwatcher_enumerationcompleted.md) event when the initial enumeration is complete, and continues to raise events if a device is added, updated, or removed.

The following diagram shows how the [PnpObjectWatcher](pnpobjectwatcher.md) transitions between the states represented by [DeviceWatcherStatus](../windows.devices.enumeration/devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

The [Start](pnpobjectwatcher_start_1587696324.md) method can only be called when the [PnpObjectWatcher](pnpobjectwatcher.md) is in the **Created**, **Stopped** or **Aborted** state. The [Status](pnpobjectwatcher_status.md) property indicates the [PnpObjectWatcher](pnpobjectwatcher.md) state. When re-starting the watcher, wait for the [Stopped](pnpobjectwatcher_stopped.md) event before calling [Start](pnpobjectwatcher_start_1587696324.md).

A call to [Stop](pnpobjectwatcher_stop_1201535524.md) transitions the [PnpObjectWatcher](pnpobjectwatcher.md) to the **Stopping** state and completes immediately. The watcher will transition to the **Stopped** state once all events that are already in the process of being raised have completed.

After calling [Stop](pnpobjectwatcher_stop_1201535524.md), apps may wait for the [Stopped](pnpobjectwatcher_stopped.md) event if they need to know when the [PnpObjectWatcher](pnpobjectwatcher.md) has stopped. Callers must wait for the [Stopped](pnpobjectwatcher_stopped.md) event before they can call [Start](pnpobjectwatcher_start_1587696324.md) to restart the watcher. Callers may unsubscribe from events if they do not want to receive any additional events after [Stop](pnpobjectwatcher_stop_1201535524.md) but do not want to wait for the [Stopped](pnpobjectwatcher_stopped.md) event.

## -examples

## -see-also