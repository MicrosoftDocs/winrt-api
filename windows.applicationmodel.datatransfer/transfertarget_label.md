---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTarget.Label
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.Label

<!--
public string Label { get; }
-->


## -description

The `Label` property gets the display name of the transfer target. This name is typically shown to users to identify the target.

## -property-value

A `string` that represents the display name of the transfer target.

## -remarks

The `Label` property provides a user-friendly name for the transfer target. Applications can use this property to display the name in their user interface, making it easier for users to select the desired target.

#### Usage Notes:

- The `Label` is intended for display purposes and may not be unique.
- Combine the `Label` with other properties, such as `Id`, for unique identification if needed.

## -see-also

[TransferTarget](transfertarget.md)

## -examples

#### Example: Displaying the Label of a Transfer Target

```csharp
var targetLabel = transferTarget.Label;
Console.WriteLine($"Transfer Target Label: {targetLabel}");
```
