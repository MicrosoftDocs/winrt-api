---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTarget
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTarget

<!--
public sealed class TransferTarget
-->


## -description

The `TransferTarget` class represents a target for sharing data, such as an application or device. It provides properties and methods to interact with and invoke the target for data transfer operations.

## -remarks

The `TransferTarget` class is part of the Transfer Target Platform API, which is designed to streamline the process of discovering and invoking transfer targets asynchronously. This API supports multiple providers and includes comprehensive filter options to ensure relevant targets are discovered efficiently.

#### Key Features:

- **Asynchronous Target Discovery**: Ensures a responsive user experience by discovering targets asynchronously.
- **Invocation Support**: Allows invoking transfer targets with a data package for seamless sharing.
- **Real-Time Updates**: Provides events to notify applications about changes in available transfer targets.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md), [TransferTargetInvokeResult](transfertargetinvokeresult.md)

## -examples

#### Example: Discovering and Invoking a Transfer Target

```csharp
var watcher = TransferTarget.CreateWatcher();
watcher.Added += (sender, args) =>
{
    Console.WriteLine($"Target added: {args.Target.Label}");
};
watcher.Start();

// Invoke a target with a data package
var dataPackage = new DataPackage();
dataPackage.SetText("Hello, World!");
await watcher.TransferToAsync(target, dataPackage);
```
