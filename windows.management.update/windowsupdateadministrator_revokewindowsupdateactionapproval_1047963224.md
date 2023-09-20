---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateActionApproval(System.String,System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateActionApproval(System.String,System.String)

<!--
public void RevokeWindowsUpdateActionApproval (string updateId, string action);
-->


## -description

Revokes approval for an update action previously approved via [ApproveWindowsUpdateAction](./windowsupdateadministrator_approvewindowsupdateaction_630494726.md).

## -parameters

### -param updateId

The unique ID associated with an update (in order to identify it).

### -param action

The string associated with the action that the administrator wants to approve.

## -remarks

This call will fail in any of these cases:

* [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) wasn't previously called to register a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) on the device.
* the updateId/action combination provided doesn't match a previously approved update action.

## -see-also

## -examples
