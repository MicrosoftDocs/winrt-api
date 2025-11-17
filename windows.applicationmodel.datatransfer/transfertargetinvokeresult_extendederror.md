---
-api-id: P:Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult.ExtendedError
-api-type: winrt property
---

# Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult.ExtendedError

<!--
public System.Exception ExtendedError { get; }
-->


## -description

The `ExtendedError` property gets the exception that provides additional information about why the transfer operation failed. This property is useful for diagnosing issues during the invocation of a transfer target.

## -property-value

An `Exception` object that contains details about the error that occurred during the transfer operation.

## -remarks

The `ExtendedError` property is populated only when the transfer operation fails. Applications can use this property to log or display error details to the user.

#### Usage Notes:

- Check the `Succeeded` property before accessing `ExtendedError` to ensure that the operation failed.
- Use this property to provide meaningful error messages or take corrective actions.

## -see-also

[TransferTargetInvokeResult](transfertargetinvokeresult.md), [TransferTargetWatcher](transfertargetwatcher.md)

## -examples

#### Example: Handling an Extended Error

```csharp
if (!result.Succeeded)
{
    Console.WriteLine($"Transfer failed with error: {result.ExtendedError.Message}");
}
```
