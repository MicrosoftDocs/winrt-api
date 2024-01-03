---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateApproval(System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateApproval(System.String)

<!--
public void RevokeWindowsUpdateApproval (string updateId);
-->


## -description

Revokes approval for an update action previously approved via [ApproveWindowsUpdate](./windowsupdateadministrator_approvewindowsupdate_1582950728.md).

## -parameters

### -param updateId

The unique ID associated with an update (in order to identify it).

## -remarks

This call will fail in any of these cases:

* [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) wasn't previously called to register a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) on the device.
* The updateId provided doesn't match a previously approved update.

## -see-also

## -examples
