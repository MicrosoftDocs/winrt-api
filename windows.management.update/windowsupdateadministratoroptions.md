---
-api-id: T:Windows.Management.Update.WindowsUpdateAdministratorOptions
-api-type: winrt enum
---

# Windows.Management.Update.WindowsUpdateAdministratorOptions

<!--
public enum WindowsUpdateAdministratorOptions
-->


## -description

Defines constants that specify the administrator options that the caller wants control over when registering with [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md).

## -enum-fields

### -field None: 0

No additional controls are requested for preventing update activity.

### -field RequireAdministratorApprovalForScans: 1

Background scan activity will be blocked without explicit approval via [StartAdministratorScan](./windowsupdateadministrator_startadministratorscan_459526238.md).

### -field RequireAdministratorApprovalForUpdates: 2

Updates will not be permitted to proceed without explicit approval via [ApproveWindowsUpdate](./windowsupdateadministrator_approvewindowsupdate_1582950728.md).

### -field RequireAdministratorApprovalForActions: 4

Update actions will not be permitted to proceed without explicit approval via [ApproveWindowsUpdateAction](./windowsupdateadministrator_approvewindowsupdateaction_630494726.md).

## -remarks

These options can be combined using bitwise OR to set a combination of flags when registering a Windows Update administrator.

## -see-also

## -examples
