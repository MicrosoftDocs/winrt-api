---
-api-id: T:Windows.Management.Update.WindowsUpdateManagerScanMode
-api-type: winrt enum
---

# Windows.Management.Update.WindowsUpdateManagerScanMode

<!--
public enum WindowsUpdateManagerScanMode
-->


## -description

Defines constants that specify how a software-update scan is performed when calling [WindowsUpdateManager.PerformScan](./windowsupdatemanager_performscan_158684574.md).

## -enum-fields

### -field Default: 0
Performs a standard scan that honors the orchestrator's normal scheduling and deferral behavior.

### -field BypassScanDeferrals: 1
Performs a scan that ignores configured scan deferrals, forcing providers to be queried even if a deferral window would otherwise apply.

### -field UserInitiated: 2
Performs the scan as if a user had selected **Check for updates**. The scan runs at higher priority and bypasses a variety of blocks that apply to background scans.

### -field WhatIf: 100
Performs a non-committal evaluation that reports the updates that *would* be returned without changing device state. Use this mode for diagnostics and validation.

## -remarks

Use the mode that matches the originating intent of the scan. [WindowsUpdateManagerScanMode](./windowsupdatemanagerscanmode.md) values that are not **UserInitiated** are treated as background scans.

## -see-also

[WindowsUpdateManager](./windowsupdatemanager.md)

## -examples

