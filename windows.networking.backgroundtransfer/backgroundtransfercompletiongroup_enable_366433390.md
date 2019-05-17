---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup.Enable
-api-type: winrt method
---

<!-- Method syntax
public void Enable()
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup.Enable

## -description
Indicates that the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) is complete and no more background transfer operations ([DownloadOperation](downloadoperation.md) or [UploadOperation](uploadoperation.md) objects) will be added t the completion group.

## -remarks
The Enable method must be called on the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) to enable the completion group, otherwise the background task associated with the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) will never be called.

Any attempt to add a [DownloadOperation](downloadoperation.md) or [UploadOperation](uploadoperation.md) to the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) after calling the Enable method will result in an exception.

The Enable method on a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) can only be called once. An attempt to call the Enable method more than once will result in an exception.

## -examples

## -see-also
[DownloadOperation](downloadoperation.md), [UploadOperation](uploadoperation.md)
