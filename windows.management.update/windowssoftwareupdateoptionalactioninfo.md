---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo

<!--
public sealed class WindowsSoftwareUpdateOptionalActionInfo
-->


## -description

Describes the optional "close-and-deploy", "close-and-install", and "close-and-restart" action variants for a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) — the actions that run when the target application must be closed first.

## -remarks

The optional actions aren't separate action types; they represent the same underlying Deploy, Install, and AppRestart actions performed with application closure requested. Supply `null` for any variant that doesn't apply to your update.

## -see-also

[WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md), [WindowsSoftwareUpdateActionInfo](./windowssoftwareupdateactioninfo.md)

## -examples

