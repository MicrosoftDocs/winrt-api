---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo

<!--
public sealed class WindowsSoftwareUpdateExecutionInfo
-->


## -description

Describes the set of actions a provider runs to apply an executable or PowerShell [WindowsSoftwareUpdate](./windowssoftwareupdate.md).

## -remarks

Use the download/install constructor for two-phase updates that download and then install, and the deploy constructor for single-step updates that combine acquisition and installation. Both forms accept a [WindowsSoftwareUpdateOptionalActionInfo](./windowssoftwareupdateoptionalactioninfo.md) describing the "close-and-deploy", "close-and-install", and "close-and-restart" variants.

## -see-also

[WindowsSoftwareUpdateActionInfo](./windowssoftwareupdateactioninfo.md), [WindowsSoftwareUpdateOptionalActionInfo](./windowssoftwareupdateoptionalactioninfo.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

