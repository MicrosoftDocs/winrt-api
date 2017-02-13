---
-api-id: M:Windows.Devices.Enumeration.DeviceWatcher.Start
-api-type: winrt method
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.Enumeration.DeviceWatcher.Start

## -description
Starts a search for devices, and subscribes to device enumeration events.

## -remarks
An app calls [Start](devicewatcher_start.md) to begin the search for devices. During this intial enumeration, the [DeviceWatcher](devicewatcher.md) raises an [Added](devicewatcher_added.md) event for each device that's found, until all devices are found. The [DeviceWatcher](devicewatcher.md) raises an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete, and continues to raise events if a device is added, updated, or removed.

The [Start](devicewatcher_start.md) method can only be called when the [DeviceWatcher](devicewatcher.md) is in the **Created**, **Stopped** or **Aborted** state. The [Status](devicewatcher_status.md) property indicates the [DeviceWatcher](devicewatcher.md) state. When re-starting the watcher, wait for the [Stopped](devicewatcher_stopped.md) event before calling [Start](devicewatcher_start.md). The following diagram shows how the [DeviceWatcher](devicewatcher.md) transitions between the states represented by [DeviceWatcherStatus](devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"/>

## -examples

## -see-also
