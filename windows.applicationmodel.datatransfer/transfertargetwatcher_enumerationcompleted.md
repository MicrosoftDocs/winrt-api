---
-api-id: E:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.EnumerationCompleted
-api-type: winrt event
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.EnumerationCompleted

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.TransferTargetWatcher,object> EnumerationCompleted;
-->


## -description

The `EnumerationCompleted` event occurs when the `TransferTargetWatcher` completes the initial enumeration of transfer targets. This event indicates that all currently available targets have been discovered.

## -remarks

Applications can handle the `EnumerationCompleted` event to perform actions after the initial discovery of transfer targets is complete. This is useful for scenarios where the application needs to wait for all targets to be enumerated before proceeding.

#### Event Arguments:

- `object`: Reserved for future use; currently does not provide additional data.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Handling the EnumerationCompleted Event

```csharp
watcher.EnumerationCompleted += (sender, args) =>
{
    Console.WriteLine("Enumeration of transfer targets completed.");
};
```
