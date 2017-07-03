---
-api-id: T:Windows.System.AppResourceGroupInfoWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppResourceGroupInfoWatcherStatus : int
-->

# Windows.System.AppResourceGroupInfoWatcherStatus

## -description
Describes the various states that the [AppResourceGroupInfoWatcher](appresourcegroupinfowatcher.md) may be in.

## -enum-fields
### -field Stopping:3
The watcher is in the process of stopping monitoring changes.

### -field Stopped:4
The watcher has stopped monitoring changes.

### -field Started:1
The watcher has started monitoring changes.

### -field EnumerationCompleted:2
The watcher has completed enumerating the resource groups that are available to monitor. After enumeration is complete, the watcher will report when items are added or removed.

### -field Created:0
The watcher has been created.

### -field Aborted:5
The watcher has been stopped by the system as the result of an internal error or other failure condition.

## -remarks

## -see-also

## -examples
