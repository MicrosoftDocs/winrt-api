---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundUploader.RequestUnconstrainedUploadsAsync(Windows.Foundation.Collections.IIterable{Windows.Networking.BackgroundTransfer.UploadOperation})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.BackgroundTransfer.UnconstrainedTransferRequestResult> RequestUnconstrainedUploadsAsync(Windows.Foundation.Collections.IIterable<Windows.Networking.BackgroundTransfer.UploadOperation> operations)
-->

# Windows.Networking.BackgroundTransfer.BackgroundUploader.RequestUnconstrainedUploadsAsync

## -description
Used to request an unconstrained upload operation. When this method is called the user is provided with a UI prompt that they can use to indicate their consent for an unconstrained operation.An unconstrained transfer operation will run without the resource restrictions normally associated with background network operations while a device is running on battery.

## -parameters
### -param operations
The upload operation to run unconstrained.

## -returns
Indicates if the operations will run unconstrained.

## -remarks

## -examples

## -see-also
