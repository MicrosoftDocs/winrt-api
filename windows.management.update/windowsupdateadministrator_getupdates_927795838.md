---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.GetUpdates
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.GetUpdates

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Management.Update.WindowsUpdate> GetUpdates ();
-->


## -description

Retrieves a list of all updates that are currently pending actions, and are known to the update administrator.

## -returns

A list of all updates that are currently pending actions, and are known to the update administrator.

## -remarks

The returned list is a superset of the updates that can be retrieved with [WindowsUpdateManager.GetApplicableUpdates](./windowsupdatemanager_getapplicableupdates_881665234.md), as it will include updates that have not yet been approved via [ApproveWindowsUpdate](./windowsupdateadministrator_approvewindowsupdate_1582950728.md).

## -see-also

## -examples
