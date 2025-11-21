---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTarget
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTarget

<!--
public sealed class TransferTarget
-->

## -description

The `TransferTarget` class represents an application target for sharing data. It provides properties and methods to interact with and invoke the target for data transfer operations.

## -remarks

The `TransferTarget` class is part of the Transfer Target Platform API, which is designed to streamline the process of discovering and invoking transfer targets asynchronously. This API supports multiple providers and includes comprehensive filter options to ensure relevant targets are discovered efficiently.

#### Key Features

- **Asynchronous Target Discovery**: Ensures a responsive user experience by discovering targets asynchronously.
- **Invocation Support**: Allows invoking transfer targets with a data package for seamless sharing.
- **Real-Time Updates**: Provides events to notify applications about changes in available transfer targets.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md), [TransferTargetInvokeResult](transfertargetinvokeresult.md)

## -examples

For a complete sample demonstrating the use of the `TransferTargetWatcher` and related APIs, refer to the [Transfer Target Watcher Sample](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/TransferTargetWatcherAPI/).

#### Example - Discovering and Invoking a Transfer Target

```csharp
var watcher = TransferTarget.CreateWatcher();
TransferTarget discoveredTarget = null;

watcher.Added += (sender, args) =>
{
    Console.WriteLine($"Target added: {args.Target.Label}");
    discoveredTarget = args.Target;
};
watcher.Start();

// Invoke a target with the parent window handle
if (discoveredTarget != null)
{
    var parentWindowId = Windows.UI.WindowId.CreateFromWindowHandle(hwnd);
    var result = await discoveredTarget.TransferToAsync(discoveredTarget, parentWindowId);
}
```
