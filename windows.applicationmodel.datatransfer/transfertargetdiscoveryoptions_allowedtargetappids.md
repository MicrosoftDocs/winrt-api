---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.AllowedTargetAppIds
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetDiscoveryOptions.AllowedTargetAppIds

<!--
public string[] AllowedTargetAppIds { get; set; }
-->


## -description

The `AllowedTargetAppIds` property gets or sets a list of app IDs that are allowed as transfer targets. This property is used to filter the discovery process to include only specific apps.

## -property-value

A `string[]` array containing the app IDs of allowed transfer targets.

## -remarks

The `AllowedTargetAppIds` property provides a way to restrict the discovery of transfer targets to a predefined set of applications. This is useful for scenarios where only specific apps should be considered as targets.

#### Usage Notes:

- If this property is not set, all available transfer targets are considered.
- Use this property to enforce application-specific sharing policies.

## -see-also

[TransferTargetDiscoveryOptions](transfertargetdiscoveryoptions.md)

## -examples

#### Example: Setting Allowed Target App IDs

```csharp
var options = new TransferTargetDiscoveryOptions
{
    AllowedTargetAppIds = new[] { "App1", "App2" }
};
```