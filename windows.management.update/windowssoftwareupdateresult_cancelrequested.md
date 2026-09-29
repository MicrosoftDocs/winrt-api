---
-api-id: P:Windows.Management.Update.WindowsSoftwareUpdateResult.CancelRequested
-api-type: winrt property
---

# Windows.Management.Update.WindowsSoftwareUpdateResult.CancelRequested

<!--
public bool CancelRequested { get; }
-->


## -description

Gets a value that indicates whether the orchestrator has requested cancellation of the operation.

## -property-value

`true` if cancellation has been requested; otherwise, `false`.

## -remarks

When this is `true`, a long-running action should stop work promptly and report a canceled result.

## -see-also

[WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md)

## -examples

