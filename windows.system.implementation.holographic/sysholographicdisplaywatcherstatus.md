---
-api-id: T:Windows.System.Implementation.Holographic.SysHolographicDisplayWatcherStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SysHolographicDisplayWatcherStatus : int 
-->

# Windows.System.Implementation.Holographic.SysHolographicDisplayWatcherStatus

## -description
Describes the state of a [SysHolographicDisplayWatcher](sysholographicdisplaywatcher.md) object.

> [!IMPORTANT]
> This API is available only to components of the Windows operating system.  Calls to these APIs will fail at runtime for all other processes.  These APIs may be modified or removed in future Windows releases.

## -enum-fields
### -field Created:0
This is the initial state of a watcher object. During this state clients can register event handlers.

### -field Started:1
The watcher transitions to the **Started** state once [Start](sysholographicdisplaywatcher_start_1587696324.md) is called. The watcher is enumerating the initial collection. Note that during this enumeration phase it is possible to receive [Removed](sysholographicdisplaywatcher_removed.md) notifications but only to items that have already been [Added](sysholographicdisplaywatcher_added.md).

### -field EnumerationCompleted:2
The watcher has completed enumerating the initial collection. Items can still be added, updated or removed from the collection.

### -field Stopping:3
The client has called [Stop](sysholographicdisplaywatcher_stop_1201535524.md) and the watcher is still in the process of stopping. Events may still be raised.

### -field Stopped:4
The client has called **Stop** and the watcher has completed all outstanding events. No further events will be raised.

### -field Aborted:5
The watcher has aborted operation. No subsequent events will be raised.

## -remarks

## -see-also

## -examples

