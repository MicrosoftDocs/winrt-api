---
-api-id: E:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Added
-api-type: winrt event
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Added

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.TransferTargetWatcher,Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs> Added;
-->


## -description

The `Added` event occurs when a new transfer target is discovered by the `TransferTargetWatcher`. This event provides details about the added target through the `TransferTargetChangedEventArgs`.

## -remarks

Applications can handle the `Added` event to dynamically respond to the discovery of new transfer targets. This is useful for updating the user interface or initiating actions based on the newly available targets.

#### Event Arguments:

- `TransferTargetChangedEventArgs`: Contains information about the added transfer target.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetChangedEventArgs](transfertargetchangedeventargs.md)

## -examples

#### Example: Handling the Added Event

```csharp
watcher.Added += (sender, args) =>
{
    Console.WriteLine($"New target added: {args.Target.Label}");
};
```
