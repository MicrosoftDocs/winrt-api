---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateProviderStatus.SetActionProgress(System.UInt64,System.UInt64)
-api-type: winrt method
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderStatus.SetActionProgress(System.UInt64,System.UInt64)

<!--
public Windows.Management.Update.WindowsSoftwareUpdateResult SetActionProgress (ulong current, ulong total);
-->


## -description

Reports the progress of the action that's currently running.

## -parameters

### -param current

The amount of work completed so far.

### -param total

The total amount of work that represents completion.

## -returns

A [WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md) that indicates whether the report was accepted. Check [CancelRequested](./windowssoftwareupdateresult_cancelrequested.md) on the result to detect a cancellation request.

## -remarks


## -see-also

[WindowsSoftwareUpdateActionProgress](./windowssoftwareupdateactionprogress.md)

## -examples

