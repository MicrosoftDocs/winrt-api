---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateApproval(System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.RevokeWindowsUpdateApproval(System.String)

<!--
public void RevokeWindowsUpdateApproval (string updateId);
-->


## -description

## -parameters

### -param updateId

## -remarks
This call will fail if:
- [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) was not previously called to register a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) on the device, this call will fail.
- The updateId provided does not match any updates found by a previous scan.

## -see-also

## -examples


