---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTarget.Label
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.Label

<!--
public string Label { get; }
-->


## -description

The `Label` property gets the display name of the transfer target. You typically show this name to users so they can identify the target.

## -property-value

A `string` that represents the display name of the transfer target.

## -remarks

The `Label` property provides a user-friendly name for the transfer target. It's localized based on the current user's locale selection.

Applications can use this property to display the name in their user interface, making it easier for users to select the desired target.

#### Usage Notes:

- The `Label` is intended for display purposes and might not be unique.
- Combine the `Label` with other properties, such as `Id`, for unique identification if needed.

## -see-also

[TransferTarget](transfertarget.md)

## -examples

#### Example: Displaying the label of a transfer target

```csharp
var targetLabel = transferTarget.Label;
Console.WriteLine($"Transfer Target Label: {targetLabel}");
```
