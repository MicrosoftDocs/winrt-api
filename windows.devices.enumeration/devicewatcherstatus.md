---
-api-id: T:Windows.Devices.Enumeration.DeviceWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.DeviceWatcherStatus : int
-->

# DeviceWatcherStatus

## -description
Describes the state of a [DeviceWatcher](devicewatcher.md) object.

## -enum-fields
### -field Created:0
This is the initial state of a Watcher object. During this state clients can register event handlers.

### -field Started:1
The watcher transitions to the Started state once [Start](devicewatcher_start_1587696324.md) is called. The watcher is enumerating the initial collection. Note that during this enumeration phase it is possible to receive [Updated](devicewatcher_updated.md) and [Removed](devicewatcher_removed.md) notifications but only to items that have already been [Added](devicewatcher_added.md).

### -field EnumerationCompleted:2
The watcher has completed enumerating the initial collection. Items can still be added, updated or removed from the collection.

### -field Stopping:3
The client has called [Stop](devicewatcher_stop_1201535524.md) and the watcher is still in the process of stopping. Events may still be raised.

### -field Stopped:4
The client has called [Stop](devicewatcher_stop_1201535524.md) and the watcher has completed all outstanding events. No further events will be raised.

### -field Aborted:5
The watcher has aborted operation. No subsequent events will be raised.


## -remarks
The following state diagram shows how the [DeviceWatcher](devicewatcher.md) transitions between the states represented by [DeviceWatcherStatus](devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

## -examples

## -see-also