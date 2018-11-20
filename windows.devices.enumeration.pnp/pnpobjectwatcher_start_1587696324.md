---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Start
-api-type: winrt method
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Start

## -description
Starts raising the events to inform the client that a [PnpObject](pnpobject.md) has been added, updated, or removed.

## -remarks
An app calls [Start](pnpobjectwatcher_start_1587696324.md) to begin the search for devices. During this initial enumeration, the [PnpObjectWatcher](pnpobjectwatcher.md) raises an [Added](pnpobjectwatcher_added.md) event for each device that's found, until all devices are found. The [PnpObjectWatcher](pnpobjectwatcher.md) raises an [EnumerationCompleted](pnpobjectwatcher_enumerationcompleted.md) event when the initial enumeration is complete, and continues to raise events if a device is added, updated, or removed.

The [Start](pnpobjectwatcher_start_1587696324.md) method can only be called when the [PnpObjectWatcher](pnpobjectwatcher.md) is in the **Created**, **Stopped** or **Aborted** state. The [Status](pnpobjectwatcher_status.md) property indicates the [PnpObjectWatcher](pnpobjectwatcher.md) state. When re-starting the watcher, wait for the [Stopped](pnpobjectwatcher_stopped.md) event before calling [Start](pnpobjectwatcher_start_1587696324.md).

The following diagram shows how the [PnpObjectWatcher](pnpobjectwatcher.md) transitions between the states represented by [DeviceWatcherStatus](../windows.devices.enumeration/devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

## -examples

## -see-also
