---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.ApproveWindowsUpdateAction(System.String,System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.ApproveWindowsUpdateAction(System.String,System.String)

<!--
public void ApproveWindowsUpdateAction (string updateId, string action);
-->


## -description

Allows a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) to mark an update action as approved.

## -parameters

### -param updateId

The unique ID associated with an update (in order to identify it).

### -param action

The string associated with the action that the administrator wants to approve.

## -remarks

The update ID will generally be a GUID, but it can be any string that uniquely identifies it.

The action string will most commonly be "Download" or "Install". Other possible actions include "Uninstall", "Commit", and "PostReboot".

This call fails if the *updateId* provided doesn't match any updates found by a previous scan.

## -see-also

## -examples
