---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs

<!--
public sealed class TransferTargetChangedEventArgs
-->


## -description

The `TransferTargetChangedEventArgs` class provides data for events that notify applications about changes to a transfer target, such as when a target is added, removed, or updated.

## -remarks

This class is used in conjunction with the `TransferTargetWatcher` to deliver detailed information about transfer target changes. It allows applications to respond dynamically to updates in the available transfer targets.

#### Key Properties:

- `Target`: Gets the transfer target associated with the event.

#### Usage:

This class is typically used in event handlers for the `Added`, `Removed`, and `Updated` events of the `TransferTargetWatcher`.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTarget](transfertarget.md)

## -examples

#### Example: Handling TransferTargetWatcher Events

```csharp
watcher.Added += (sender, args) =>
{
    Console.WriteLine($"New target added: {args.Target.Label}");
};

watcher.Updated += (sender, args) =>
{
    Console.WriteLine($"Target updated: {args.Target.Label}");
};

watcher.Removed += (sender, args) =>
{
    Console.WriteLine($"Target removed: {args.Target.Label}");
};
```


