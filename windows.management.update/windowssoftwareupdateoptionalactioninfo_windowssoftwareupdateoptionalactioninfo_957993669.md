---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo.#ctor(Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo)
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo.#ctor(Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo)

<!--
public WindowsSoftwareUpdateOptionalActionInfo (Windows.Management.Update.WindowsSoftwareUpdateActionInfo closeAndDeployInfo, Windows.Management.Update.WindowsSoftwareUpdateActionInfo closeAndInstallInfo, Windows.Management.Update.WindowsSoftwareUpdateActionInfo closeAndRestartInfo);
-->


## -description

Creates a new [WindowsSoftwareUpdateOptionalActionInfo](./windowssoftwareupdateoptionalactioninfo.md). Supply `null` for any variant that doesn't apply.

## -parameters

### -param closeAndDeployInfo

The action to deploy the update after closing the target application, or `null`.

### -param closeAndInstallInfo

The action to install the update after closing the target application, or `null`.

### -param closeAndRestartInfo

The action to relaunch the target application after the update completes, or `null`.

## -remarks


## -see-also

[WindowsSoftwareUpdateOptionalActionInfo](./windowssoftwareupdateoptionalactioninfo.md)

## -examples

