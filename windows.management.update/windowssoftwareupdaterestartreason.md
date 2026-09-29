---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateRestartReason
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateRestartReason

<!--
public enum WindowsSoftwareUpdateRestartReason
-->


## -description

Defines constants that specify why a restart is required to complete a software-update action.

## -enum-fields

### -field None: 0
No restart is required.

### -field System: 1
A full system (operating system) restart is required.

### -field AppClose: 2
The target application must be closed before the action can complete.

### -field AppRestart: 3
The target application must be closed and relaunched to complete the action.

## -remarks

A provider reports a restart reason in a [WindowsSoftwareUpdateProviderActionResult](./windowssoftwareupdateprovideractionresult.md) so the orchestrator can coordinate the correct restart experience.

## -see-also

[WindowsSoftwareUpdateProviderActionResult](./windowssoftwareupdateprovideractionresult.md)

## -examples

