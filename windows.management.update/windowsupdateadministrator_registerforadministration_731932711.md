---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.RegisterForAdministration(System.String,Windows.Management.Update.WindowsUpdateAdministratorOptions)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.RegisterForAdministration(System.String,Windows.Management.Update.WindowsUpdateAdministratorOptions)

<!--
public static Windows.Management.Update.WindowsUpdateAdministratorStatus RegisterForAdministration (string organizationName, Windows.Management.Update.WindowsUpdateAdministratorOptions options);
-->


## -description

Registers a Windows update administrator on the device to allow fine-grained control of update activity.

## -parameters

### -param organizationName

The organization name associated with the update administrator.

### -param options

A combination of [WindowsUpdateAdministratorOptions](./windowsupdateadministratoroptions.md) flags that determine which aspects the administrator requires explicit approval for.

## -returns

A [WindowsUpdateAdministratorStatus](./windowsupdateadministratorstatus.md) indicating whether registration was successful.

## -remarks

This registration must be performed from a SYSTEM or Administrator elevation on the device.

If there is already a Windows update administrator registered on the device, then this call will fail, because there can be only one active administrator at a time.

The organization name used at registration is required to acquire the **WindowsUpdateAdministrator** object via [GetRegisteredAdministrator](./windowsupdateadministrator_getregisteredadministrator_1823331721.md). It's also required in order to call [UnregisterForAdministration](./windowsupdateadministrator_unregisterforadministration_1234576495.md).

## -see-also

## -examples
