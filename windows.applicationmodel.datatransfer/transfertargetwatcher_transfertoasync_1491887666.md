---
-api-id: M:Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.TransferToAsync(Windows.ApplicationModel.DataTransfer.TransferTarget,Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.ApplicationModel.DataTransfer.TransferTargetWatcher.TransferToAsync(Windows.ApplicationModel.DataTransfer.TransferTarget,Windows.UI.WindowId)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Windows.ApplicationModel.DataTransfer.TransferTargetInvokeResult,double> TransferToAsync (Windows.ApplicationModel.DataTransfer.TransferTarget target, Windows.UI.WindowId parentWindowHandle);
-->


## -description

The `TransferToAsync` method asynchronously invokes a transfer target with the specified data package. This method facilitates the sharing of content to a selected target.

## -parameters

#### -param target

The `TransferTarget` to which the data package will be transferred. This parameter specifies the destination for the sharing operation.

#### -param parentWindowHandle

A `WindowId` that represents the parent window handle. This parameter is used to associate the sharing operation with a specific window.

## -returns

An `IAsyncOperationWithProgress<TransferTargetInvokeResult, double>` that represents the asynchronous operation. The result indicates whether the transfer was successful, and the progress provides updates on the operation's status.

## -remarks

The `TransferToAsync` method is used to share content with a transfer target. Applications can use this method to initiate sharing operations and monitor their progress.

#### Usage Notes:

- Ensure that the `target` parameter is valid and enabled before calling this method.
- Handle the result of the operation to determine whether the transfer was successful.

## -see-also

[TransferTarget](transfertarget.md), [TransferTargetInvokeResult](transfertargetinvokeresult.md)

## -examples

#### Example: Invoking a Transfer Target Asynchronously

```csharp
var result = await watcher.TransferToAsync(target, parentWindowHandle);
if (result.Succeeded)
{
    Console.WriteLine("Transfer succeeded.");
}
else
{
    Console.WriteLine($"Transfer failed with error: {result.ExtendedError}");
}
```
