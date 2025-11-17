---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions

<!--
public sealed class TransferTargetDiscoveryOptions
-->


## -description

The `TransferTargetDiscoveryOptions` class provides configuration options for discovering transfer targets. It allows developers to specify criteria for filtering and prioritizing transfer targets during the discovery process.

## -remarks

This class is used to customize the behavior of the `TransferTargetWatcher` when discovering transfer targets. By setting properties on this class, developers can control which targets are discovered and how they are prioritized.

#### Key Properties:

- `AllowedTargetAppIds`: Specifies a list of app IDs that are allowed as transfer targets.
- `DataPackage`: Specifies the data package used to filter relevant transfer targets.
- `MaxAppTargets`: Specifies the maximum number of app targets to discover.

#### Usage:

The `TransferTargetDiscoveryOptions` class is passed to the `TransferTargetWatcher` to configure the discovery process.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTarget](transfertarget.md)

## -examples

#### Example: Configuring TransferTargetWatcher with Discovery Options

```csharp
var options = new TransferTargetDiscoveryOptions
{
    AllowedTargetAppIds = new List<string> { "App1", "App2" },
    MaxAppTargets = 5
};

var watcher = TransferTarget.CreateWatcher(options);
watcher.Start();
```


