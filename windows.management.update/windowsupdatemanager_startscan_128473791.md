---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.StartScan(System.Boolean)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.StartScan(System.Boolean)

<!--
public void StartScan (bool userInitiated);
-->


## -description

Initiates a new scan for updates on the device.

## -parameters

### -param userInitiated
Specifies whether the scan should be performed as if initiated by a user.

## -remarks
If a scan is started with *userInitiated* set to `true`, then it will function the same as if a user had clicked "Check for updates" from the **Settings** page. That will result in the updates being processed at higher priority, and will bypass a variety of blocks that can apply to background scans.

If a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) has been registered using [RequireAdministratorApprovalForScans](./windowsupdateadministratoroptions.md), then this scan attempt will be blocked, because only scans initiated via [StartAdministratorScan](./windowsupdateadministrator_startadministratorscan_459526238.md) are allowed in that mode.

## -see-also

## -examples
