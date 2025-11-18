---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTarget.Id
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.Id

<!--
public string Id { get; }
-->


## -description

The `Id` property gets the unique identifier of the transfer target. This identifier can be used to distinguish the target from others.

## -property-value

A `string` that represents the unique identifier of the transfer target.

## -remarks

The `Id` property provides a way to uniquely identify a transfer target. This is particularly useful in scenarios where multiple targets are available, and the application needs to track or reference a specific target.

#### Usage Notes:

- The `Id` is guaranteed to be unique for each transfer target in a given session.
- Applications can use this property to store or compare transfer targets.

## -see-also

[TransferTarget](transfertarget.md)

## -examples

#### Example: Retrieving the ID of a Transfer Target

```csharp
var targetId = transferTarget.Id;
Console.WriteLine($"Transfer Target ID: {targetId}");
```
