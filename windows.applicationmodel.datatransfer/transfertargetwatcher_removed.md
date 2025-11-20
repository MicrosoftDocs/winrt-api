---
-api-id: E:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Removed
-api-type: winrt event
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Removed

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.TransferTargetWatcher,Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs> Removed;
-->

## -description

The `Removed` event occurs when a transfer target is no longer available. This event is raised by the `TransferTargetWatcher` to notify applications about the removal of a previously discovered target.

## -remarks

> [!IMPORTANT]
> Reserved for future use. Currently, `TransferTargetWatcher` doesn't currently raise this event.

#### Event Arguments

- `TransferTargetChangedEventArgs`: Contains information about the removed transfer target.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetChangedEventArgs](transfertargetchangedeventargs.md)

## -examples
