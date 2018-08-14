---
-api-id: M:Windows.Devices.Enumeration.DeviceWatcher.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Windows.Devices.Enumeration.DeviceWatcher.Stop

## -description
Stop raising the events that add, update and remove enumeration results.

## -remarks
To stop a search for devices, an app calls [Stop](devicewatcher_stop_1201535524.md) and enters the **Stopping** state. The [Stopped](devicewatcher_stopped.md) event is raised when the [Stop](devicewatcher_stop_1201535524.md) operation completes and the [DeviceWatcher](devicewatcher.md) enters the **Stopped** state.

The following diagram shows how the [DeviceWatcher](devicewatcher.md) transitions between the states represented by [DeviceWatcherStatus](devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

This call transitions the [DeviceWatcher](devicewatcher.md) to the **Stopping** state and completes immediately. The watcher will transition to the **Stopped** state once all events that are already in the process of being raised have completed.

Callers may wait for the [Stopped](devicewatcher_stopped.md) event if they need to know when the [DeviceWatcher](devicewatcher.md) has stopped. Callers must wait for the [Stopped](devicewatcher_stopped.md) event before they can call [Start](devicewatcher_start_1587696324.md) to restart the watcher. Callers may unsubscribe from events if they do not want to receive any additional events after [Stop](devicewatcher_stop_1201535524.md) but do not want to wait for the [Stopped](devicewatcher_stopped.md) event.

## -examples

## -see-also
