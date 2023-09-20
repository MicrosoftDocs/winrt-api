---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.UnregisterForAdministration(System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.UnregisterForAdministration(System.String)

<!--
public static Windows.Management.Update.WindowsUpdateAdministratorStatus UnregisterForAdministration (string organizationName);
-->


## -description

Unregisters a previously registered Windows update administrator on the device.

## -parameters

### -param organizationName

The organization name associated with the update administrator.

## -returns

A [WindowsUpdateAdministratorStatus](./windowsupdateadministratorstatus.md) indicating whether registration was successful.

## -remarks

The organization name provided must match the one provided when the Windows update administrator was registered using [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md).

## -see-also

## -examples
