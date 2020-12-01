---
-api-id: T:Windows.Devices.Enumeration.DeviceWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceWatcher : Windows.Devices.Enumeration.IDeviceWatcher, Windows.Devices.Enumeration.IDeviceWatcher2
-->

# Windows.Devices.Enumeration.DeviceWatcher

## -description
Enumerates devices dynamically, so that the app receives notifications if devices are added, removed, or changed after the initial enumeration is complete.

## -remarks
An app calls [Start](devicewatcher_start_1587696324.md) to begin the search for devices. During this initial enumeration, the DeviceWatcher raises an [Added](devicewatcher_added.md) event for each device that's found, until all devices are found. The DeviceWatcher raises an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete, and continues to raise events if a device is added, updated, or removed.

The following diagram shows how the DeviceWatcher transitions between the states represented by [DeviceWatcherStatus](devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

The [Start](devicewatcher_start_1587696324.md) method can only be called when the DeviceWatcher is in the **Created**, **Stopped** or **Aborted** state. The [Status](devicewatcher_status.md) property indicates the DeviceWatcher state. When re-starting the watcher, wait for the [Stopped](devicewatcher_stopped.md) event before calling [Start](devicewatcher_start_1587696324.md).

[Stop](devicewatcher_stop_1201535524.md) transitions the DeviceWatcher to the **Stopping** state and completes immediately. The watcher will transition to the **Stopped** state once all events that are already in the process of being raised have completed.

Apps may wait for the [Stopped](devicewatcher_stopped.md) event if they need to know when the DeviceWatcher has stopped. Callers must wait for the [Stopped](devicewatcher_stopped.md) event before they can call [Start](devicewatcher_start_1587696324.md) to restart the watcher. Callers may unsubscribe from events if they do not want to receive any additional events after [Stop](devicewatcher_stop_1201535524.md) but do not want to wait for the [Stopped](devicewatcher_stopped.md) event.

> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and [updated](devicewatcher_updated.md) events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

## -examples
For complete examples in C# and C++, see the [Device enumeration and pairing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DeviceEnumerationAndPairing).

## -see-also
[Device enumeration and pairing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DeviceEnumerationAndPairing)
