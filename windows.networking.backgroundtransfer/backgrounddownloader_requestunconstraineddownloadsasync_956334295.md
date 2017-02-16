---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.RequestUnconstrainedDownloadsAsync(Windows.Foundation.Collections.IIterable{Windows.Networking.BackgroundTransfer.DownloadOperation})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.BackgroundTransfer.UnconstrainedTransferRequestResult> RequestUnconstrainedDownloadsAsync(Windows.Foundation.Collections.IIterable<Windows.Networking.BackgroundTransfer.DownloadOperation> operations)
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.RequestUnconstrainedDownloadsAsync

## -description
Used to request an unconstrained download operation. When this method is called the user is provided with a UI prompt that they can use to indicate their consent for an unconstrained operation.An unconstrained transfer operation will run without the resource restrictions normally associated with background network operations while a device is running on battery.

## -parameters
### -param operations
The download operation to run unconstrained.

## -returns
Indicates if the operations will run unconstrained.

## -remarks

## -examples

## -see-also
