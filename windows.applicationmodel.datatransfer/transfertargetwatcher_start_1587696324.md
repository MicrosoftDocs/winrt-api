---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Start
-api-type: winrt method
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Start

<!--
public void Start ();
-->


## -description

The `Start` method begins the discovery of transfer targets by the `TransferTargetWatcher`. Once started, the watcher raises events such as `Added`, `Removed`, and `Updated` to notify the application about changes in available transfer targets.

## -remarks

Calling the `Start` method enables the `TransferTargetWatcher` to actively monitor for transfer targets. Applications should ensure that the watcher is properly configured before calling this method. The watcher continues to monitor until the `Stop` method is called.

#### Usage Notes:

- Ensure that event handlers for `Added`, `Removed`, and other events are registered before starting the watcher.
- The watcher may raise the `EnumerationCompleted` event after the initial discovery phase.

## -see-also

[TransferTargetWatcher.Stop](transfertargetwatcher_stop.md), [TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Starting the TransferTargetWatcher

```csharp
var watcher = TransferTarget.CreateWatcher();
watcher.Added += (sender, args) =>
{
    Console.WriteLine($"Target added: {args.Target.Label}");
};

watcher.Start();
```
