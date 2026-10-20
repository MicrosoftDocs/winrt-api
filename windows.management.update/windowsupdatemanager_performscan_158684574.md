---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.PerformScan(Windows.Management.Update.WindowsUpdateManagerScanMode)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.PerformScan(Windows.Management.Update.WindowsUpdateManagerScanMode)

<!--
public Windows.Management.Update.WindowsSoftwareUpdateScanResult PerformScan (Windows.Management.Update.WindowsUpdateManagerScanMode scanMode);
-->


## -description

Performs a software-update scan across the registered providers and returns the discovered updates.

## -parameters

### -param scanMode

A [WindowsUpdateManagerScanMode](./windowsupdatemanagerscanmode.md) value that specifies how the scan is performed.

## -returns

A [WindowsSoftwareUpdateScanResult](./windowssoftwareupdatescanresult.md) that indicates whether the scan succeeded and lists the updates that were found.

## -remarks

Choose the scan mode that matches the originating intent. Use **UserInitiated** for scans triggered by a person, and **WhatIf** to evaluate results without changing device state. For end-to-end provider scan examples, see the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsUpdateManagerScanMode](./windowsupdatemanagerscanmode.md), [WindowsSoftwareUpdateScanResult](./windowssoftwareupdatescanresult.md)

## -examples

