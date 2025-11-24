---
-api-id: E:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Stopped
-api-type: winrt event
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.Stopped

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.TransferTargetWatcher,object> Stopped;
-->


## -description

The `Stopped` event occurs when the `TransferTargetWatcher` stops monitoring for transfer targets. This event is raised to notify applications that the watcher has been stopped, either programmatically or due to an error.

## -remarks

Applications can handle the `Stopped` event to perform cleanup or update their state when the `TransferTargetWatcher` is no longer active. This ensures that the application does not attempt to interact with the watcher after it has stopped.

#### Event Arguments:

- `object`: Reserved for future use; currently does not provide additional data.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Handling the Stopped Event

```csharp
watcher.Stopped += (sender, args) =>
{
    Console.WriteLine("TransferTargetWatcher has stopped.");
};
```
