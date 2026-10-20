---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateResult
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateResult

<!--
public sealed class WindowsSoftwareUpdateResult
-->


## -description

Represents the result of a software-update operation, such as submitting a scan result, reporting progress, or reporting an action result.

## -remarks

Provider-status methods such as [SetScanResult](./windowssoftwareupdateproviderstatus_setscanresult_550695687.md) return a **WindowsSoftwareUpdateResult**. Inspect [Succeeded](./windowssoftwareupdateresult_succeeded.md) to determine the outcome, and [CancelRequested](./windowssoftwareupdateresult_cancelrequested.md) to detect when the orchestrator has asked the operation to stop.

## -see-also

[WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md)

## -examples

