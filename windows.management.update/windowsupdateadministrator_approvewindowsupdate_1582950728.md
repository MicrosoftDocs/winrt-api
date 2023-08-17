---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.ApproveWindowsUpdate(System.String,Windows.Management.Update.WindowsUpdateApprovalData)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.ApproveWindowsUpdate(System.String,Windows.Management.Update.WindowsUpdateApprovalData)

<!--
public void ApproveWindowsUpdate (string updateId, Windows.Management.Update.WindowsUpdateApprovalData approvalData);
-->


## -description
Allows a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) to mark an update as approved.

## -parameters

### -param updateId
The unique ID associated with an update to identify it.

### -param approvalData
A collection of additional properties that can change how an update is processed. See [WindowsUpdateApprovalData](./windowsupdateapprovaldata.md) for details.

## -remarks
The update ID will generally be a GUID but it can be any string that uniquely identifies it.

This call will fail if the updateId provided does not match any updates found by a previous scan.

## -see-also

## -examples


