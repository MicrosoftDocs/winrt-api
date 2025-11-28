---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Stop
-api-type: winrt method
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Stop

<!--
public void Stop ();
-->


## -description

The `Stop` method stops the discovery of transfer targets by the `TransferTargetWatcher`. Once stopped, the watcher no longer raises events such as `Added`, `Removed`, or `Updated`.

## -remarks

Calling the `Stop` method halts the monitoring process of the `TransferTargetWatcher`. Applications can call this method to conserve resources or when monitoring is no longer needed. The `Stopped` event is raised when the watcher stops.

#### Usage Notes:

- Ensure that any ongoing operations related to the watcher are completed before calling `Stop`.
- The watcher can be restarted by calling the `Start` method again.

## -see-also

[TransferTargetWatcher.Start](transfertargetwatcher_start_1587696324.md), [TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Stopping the TransferTargetWatcher

```csharp
watcher.Stop();
Console.WriteLine("TransferTargetWatcher has been stopped.");
```
