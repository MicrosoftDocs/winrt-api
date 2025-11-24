---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTarget.CreateWatcher(Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions)
-api-type: winrt method
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.CreateWatcher(Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions)

<!--
public static Windows.ApplicationModel.DataTransfer.TransferTargetWatcher CreateWatcher (Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions options);
-->


## -description

The `CreateWatcher` method creates a new instance of the `TransferTargetWatcher` class, configured with the specified discovery options. This method allows applications to customize the discovery process for transfer targets.

## -parameters

### -param options

The `TransferTargetDiscoveryOptions` used to configure the watcher. These options specify criteria such as allowed target app IDs and the maximum number of targets to discover.

## -returns

A `TransferTargetWatcher` instance configured with the provided discovery options.

## -remarks

The `CreateWatcher` method is a static method that initializes a `TransferTargetWatcher` with the specified options. Applications can use this method to tailor the discovery process to their specific needs.

#### Usage Notes:

- Ensure that the `options` parameter is properly configured before calling this method.
- The returned watcher must be started using the `Start` method to begin discovery.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md)

## -examples

#### Example: Creating and Starting a TransferTargetWatcher

```csharp
var options = new TransferTargetDiscoveryOptions
{
    AllowedTargetAppIds = new List<string> { "App1", "App2" },
    MaxAppTargets = 5
};

var watcher = TransferTarget.CreateWatcher(options);
watcher.Start();
```
