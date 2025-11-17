---
-api-id: E:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Updated
-api-type: winrt event
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Updated

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.TransferTargetWatcher,Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs> Updated;
-->


## -description

The `Updated` event occurs when the properties of a transfer target are updated. This event is raised by the `TransferTargetWatcher` to notify applications about changes to an existing transfer target.

## -remarks

Applications can handle the `Updated` event to refresh their state or user interface when a transfer target's properties are modified. This ensures that the application displays the most current information about the target.

#### Event Arguments:

- `TransferTargetChangedEventArgs`: Contains information about the updated transfer target.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetChangedEventArgs](transfertargetchangedeventargs.md)

## -examples

#### Example: Handling the Updated Event

```csharp
watcher.Updated += (sender, args) =>
{
    Console.WriteLine($"Target updated: {args.Target.Label}");
};
```
