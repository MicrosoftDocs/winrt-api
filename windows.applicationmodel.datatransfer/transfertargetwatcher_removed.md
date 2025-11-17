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

Applications can handle the `Removed` event to update their state or user interface when a transfer target is no longer available. This ensures that the application reflects the current set of available targets.

#### Event Arguments:

- `TransferTargetChangedEventArgs`: Contains information about the removed transfer target.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetChangedEventArgs](transfertargetchangedeventargs.md)

## -examples

#### Example: Handling the Removed Event

```csharp
watcher.Removed += (sender, args) =>
{
    Console.WriteLine($"Target removed: {args.Target.Label}");
};
```
