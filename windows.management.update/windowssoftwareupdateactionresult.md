---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateActionResult
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateActionResult

<!--
public enum WindowsSoftwareUpdateActionResult
-->


## -description

Defines constants that specify the outcome of a software-update action that a provider reports through a [WindowsSoftwareUpdateProviderActionResult](./windowssoftwareupdateprovideractionresult.md).

## -enum-fields

### -field Succeeded: 0
The action completed successfully.

### -field Continue: 1
The action made progress but additional work remains; the orchestrator should invoke the provider again to continue.

### -field Failed: 2
The action failed. The accompanying result and extended-error codes describe the failure.

### -field Canceled: 3
The action was canceled, typically in response to a [CancelRequested](./windowssoftwareupdateproviderstatus_cancelrequested.md) notification.

### -field Removed: 4
The update is no longer applicable and was removed; no further action is required.

## -remarks


## -see-also

[WindowsSoftwareUpdateProviderActionResult](./windowssoftwareupdateprovideractionresult.md), [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md)

## -examples

