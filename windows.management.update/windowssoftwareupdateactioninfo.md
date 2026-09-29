---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateActionInfo
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateActionInfo

<!--
public sealed class WindowsSoftwareUpdateActionInfo
-->


## -description

Describes how a provider performs a single update action by specifying the file to invoke, its arguments, and the action type.

## -remarks

For an executable provider, *fileName* is the executable to run; for a PowerShell provider, it's the script file. The orchestrator invokes the file with the supplied arguments when the corresponding [WindowsSoftwareUpdateActionType](./windowssoftwareupdateactiontype.md) needs to run. Files are invoked in SYSTEM context. For authoring guidance, see the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md), [WindowsSoftwareUpdateOptionalActionInfo](./windowssoftwareupdateoptionalactioninfo.md), [WindowsSoftwareUpdateActionType](./windowssoftwareupdateactiontype.md)

## -examples

