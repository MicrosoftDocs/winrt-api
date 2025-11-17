---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs.Target
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetChangedEventArgs.Target

<!--
public Windows.ApplicationModel.DataTransfer.TransferTarget Target { get; }
-->


## -description

The `Target` property gets the transfer target associated with the event. This property provides details about the target that was added, removed, or updated.

## -property-value

A `TransferTarget` object that represents the transfer target associated with the event.

## -remarks

The `Target` property is used in event handlers for `TransferTargetWatcher` events such as `Added`, `Removed`, and `Updated`. It provides access to the transfer target that triggered the event.

#### Usage Notes:

- Use the `Target` property to retrieve details about the transfer target involved in the event.
- The `Target` object contains additional properties such as `Id`, `Label`, and `IsEnabled`.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTarget](transfertarget.md)

## -examples

#### Example: Accessing the Target in an Event Handler

```csharp
watcher.Added += (sender, args) =>
{
    var target = args.Target;
    Console.WriteLine($"New target added: {target.Label}");
};
```


