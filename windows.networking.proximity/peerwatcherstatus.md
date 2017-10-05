---
-api-id: T:Windows.Networking.Proximity.PeerWatcherStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.Proximity.PeerWatcherStatus : int
-->

# PeerWatcherStatus

## -description
Describes the status of a [PeerWatcher](peerwatcher.md) object.

## -enum-fields
### -field Created:0
The peer watcher has been created and can start watching for peer apps within wireless range.

### -field Started:1
The peer watcher has started watching for peer apps within wireless range.

### -field EnumerationCompleted:2
A scan operation is complete and all peer apps within wireless range have been found.

### -field Stopping:3
The peer watcher is stopping.

### -field Stopped:4
The peer watcher has stopped watching for peer apps within wireless range.

### -field Aborted:5
Watching for peers has stopped due to a failure.


## -remarks

## -examples

## -see-also
## -capabilities
proximity
