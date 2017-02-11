---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundTransferGroup.TransferBehavior
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.BackgroundTransfer.BackgroundTransferBehavior TransferBehavior { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferGroup.TransferBehavior

## -description
Gets or sets the property used to specify if transfers within this group run simultaneously or in serial. Possible values are defined by [BackgroundTransferBehavior](backgroundtransferbehavior.md).

## -property-value
The group transfer behavior.

## -remarks
When using Background Transfer during development, you may get into a situation where the internal caches of active and completed transfer operations can get out of sync. This may result in the inability to start new transfer operations or interact with existing operations and [BackgroundTransferGroup](backgroundtransfergroup.md) objects. In some cases, attempting to interact with existing operations may trigger a crash. This result can occur if the [TransferBehavior](backgroundtransfergroup_transferbehavior.md) property is set to **Parallel**. This issue occurs only in certain scenarios during development and is not applicable to end users of your app. For more Information, see the Debugging Guidance section in [BackgroundDownloader](backgrounddownloader.md) and [BackgroundUploader](backgrounduploader.md).

## -examples

## -see-also
