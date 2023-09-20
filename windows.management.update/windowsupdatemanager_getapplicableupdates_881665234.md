---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.GetApplicableUpdates
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.GetApplicableUpdates

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Management.Update.WindowsUpdate> GetApplicableUpdates ();
-->


## -description

Retrieves a list of all applicable updates currently known to the [WindowsUpdateManager](./windowsupdatemanager.md).

## -returns

A list of applicable updates.

## -remarks

If a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) has been registered using [RequireAdministratorApprovalForUpdates](./windowsupdateadministratoroptions.md), then updates won't be considered applicable until they have been approved using [ApproveWindowsUpdate](./windowsupdateadministrator_approvewindowsupdate_1582950728.md).

## -see-also

## -examples
