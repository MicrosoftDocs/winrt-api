---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo.#ctor(Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo)
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdateExecutionInfo.#ctor(Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateActionInfo,Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo)

<!--
public WindowsSoftwareUpdateExecutionInfo (Windows.Management.Update.WindowsSoftwareUpdateActionInfo downloadInfo, Windows.Management.Update.WindowsSoftwareUpdateActionInfo installInfo, Windows.Management.Update.WindowsSoftwareUpdateOptionalActionInfo actions);
-->


## -description

Creates a new [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md) for a two-phase download/install update.

## -parameters

### -param downloadInfo

The action that downloads the update payload.

### -param installInfo

The action that installs the downloaded payload.

### -param actions

The optional "close and *" action variants, or `null`.

## -remarks


## -see-also

[WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md)

## -examples

