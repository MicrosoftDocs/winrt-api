---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult.Succeeded
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult.Succeeded

<!--
public bool Succeeded { get; }
-->


## -description

The `Succeeded` property indicates whether the transfer operation was successful. This property helps applications determine the outcome of invoking a transfer target.

## -property-value

A `bool` value that is `true` if the transfer operation succeeded; otherwise, `false`.

## -remarks

The `Succeeded` property provides a simple way to check the result of a transfer operation. Applications can use this property to decide whether to proceed with further actions or handle errors.

#### Usage Notes:

- If `Succeeded` is `false`, check the `ExtendedError` property for details about the failure.
- Use this property to provide feedback to the user about the success or failure of the operation.

## -see-also

[TransferTargetInvokeResult](transfertargetinvokeresult.md), [TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Checking if a Transfer Operation Succeeded

```csharp
if (result.Succeeded)
{
    Console.WriteLine("Transfer succeeded.");
}
else
{
    Console.WriteLine("Transfer failed.");
}
```
