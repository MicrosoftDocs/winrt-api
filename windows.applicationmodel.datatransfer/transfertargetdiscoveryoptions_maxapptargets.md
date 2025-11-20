---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.MaxAppTargets
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.MaxAppTargets

<!--
public int MaxAppTargets { get; set; }
-->


## -description

The `MaxAppTargets` property gets or sets the maximum number of app targets to discover. This property limits the number of transfer targets returned during the discovery process.

## -property-value

An `int` value that specifies the maximum number of app targets to discover.

## -remarks

The `MaxAppTargets` property provides a way to control the number of transfer targets discovered. This is useful for optimizing performance and ensuring that only a manageable number of targets are returned.

#### Usage Notes:

- If this property is not set, no transfer targets will be discovered.
- Use this property to limit the discovery process to a specific number of targets.

## -see-also

[TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md)

## -examples

#### Example: Setting the Maximum Number of App Targets

```csharp
var options = new TransferTargetDiscoveryOptions
{
    MaxAppTargets = 5
};
```


