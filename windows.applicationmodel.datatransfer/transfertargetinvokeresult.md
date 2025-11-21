---
-api-id: T:Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult
-api-type: winrt class
---

# Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult

<!--
public sealed class TransferTargetInvokeResult
-->


## -description

The `TransferTargetInvokeResult` class represents the result of an attempt to invoke a transfer target. It provides information about whether the invocation succeeded and any associated error details.

## -remarks

This class is used to capture the outcome of invoking a transfer target with a data package. It helps developers handle success and error scenarios effectively.

#### Key Properties:

- `Succeeded`: Indicates whether the invocation was successful.
- `ExtendedError`: Provides additional error information if the invocation failed.

#### Usage:

The `TransferTargetInvokeResult` is returned by methods such as `TransferTargetWatcher.TransferToAsync` to indicate the result of the operation.

## -see-also

[TransferTargetWatcher](transfertargetwatcher.md), [TransferTarget](transfertarget.md)

## -examples

#### Example: Handling the Result of a Transfer Target Invocation

```csharp
var result = await watcher.TransferToAsync(target, dataPackage);
if (result.Succeeded)
{
    Console.WriteLine("Transfer succeeded.");
}
else
{
    Console.WriteLine($"Transfer failed with error: {result.ExtendedError}");
}
```
