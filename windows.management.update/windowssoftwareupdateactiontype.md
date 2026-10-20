---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateActionType
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateActionType

<!--
public enum WindowsSoftwareUpdateActionType
-->


## -description

Defines constants that specify an action that a provider performs to move a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) through its lifecycle.

## -enum-fields

### -field Download: 0
Acquire the update payload. Used by download/install updates as the first phase.

### -field Install: 1
Install a previously downloaded update payload.

### -field Deploy: 2
Acquire and install the update in a single combined step, without a separate download phase.

### -field Reboot: 3
Restart the system to complete the update.

### -field AppRestart: 4
Close and relaunch the target application to complete the update.

## -remarks

Each action is described to the orchestrator by a [WindowsSoftwareUpdateActionInfo](./windowssoftwareupdateactioninfo.md). The set of actions an update supports is reported through [ApprovedActions](./windowssoftwareupdate_approvedactions.md). For a discussion of how actions map to optional "close and *" operations, see the provider authoring guide in the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateActionInfo](./windowssoftwareupdateactioninfo.md), [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md)

## -examples

