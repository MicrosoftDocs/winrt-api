---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTarget.IsEnabled
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTarget.IsEnabled

<!--
public bool IsEnabled { get; }
-->


## -description

The `IsEnabled` property indicates whether the transfer target is currently enabled and available for use.

## -property-value

A `bool` value that is `true` if the transfer target is enabled; otherwise, `false`.

## -remarks

The `IsEnabled` property allows applications to determine whether a transfer target can be used for sharing operations. This is useful for filtering out targets that are temporarily unavailable.

#### Usage Notes:

- Check the `IsEnabled` property before attempting to invoke a transfer target.
- An `IsEnabled` value of `false` may indicate that the target is disabled or not ready to accept data.

## -see-also

[TransferTarget](transfertarget.md)

## -examples

#### Example: Checking if a Transfer Target is Enabled

```csharp
if (transferTarget.IsEnabled)
{
    Console.WriteLine("The transfer target is enabled.");
}
else
{
    Console.WriteLine("The transfer target is not enabled.");
}
```
