---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.#ctor(Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup)
-api-type: winrt method
---

<!-- Method syntax
public BackgroundDownloader(Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup completionGroup)
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.BackgroundDownloader

## -description
Creates a new [BackgroundDownloader](backgrounddownloader.md) object with a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

## -parameters
### -param completionGroup
The completion group to associate with this [BackgroundDownloader](backgrounddownloader.md) object.

This parameter cannot be **NULL**.

## -remarks
This constructor will associate all downloads created with the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) passed in the *completionGroup* parameter. Once the [Enable](backgroundtransfercompletiongroup_enable_366433390.md) method is called on the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md), no more additional downloads can be created using this [BackgroundDownloader](backgrounddownloader.md) object.

## -examples

## -see-also
[BackgroundDownloader constructor](backgrounddownloader_backgrounddownloader_1221375020.md), [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md)