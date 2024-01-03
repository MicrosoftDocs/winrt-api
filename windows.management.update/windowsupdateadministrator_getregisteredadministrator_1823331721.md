---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.GetRegisteredAdministrator(System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.GetRegisteredAdministrator(System.String)

<!--
public static Windows.Management.Update.WindowsUpdateGetAdministratorResult GetRegisteredAdministrator (string organizationName);
-->


## -description

Retrieves the administrator object that is needed to call the various update administration APIs.

## -parameters

### -param organizationName

The organization name associated with the [WindowsUpdateAdministrator](./windowsupdateadministrator.md) registered to the device.

## -returns

A [WindowsUpdateGetAdministratorResult](./windowsupdategetadministratorresult.md).

## -remarks

This call will fail if:

* [RegisterForAdministration](./windowsupdateadministrator_registerforadministration_731932711.md) was not previously called to register a [WindowsUpdateAdministrator](./windowsupdateadministrator.md) on the device.
* The organizationName provided does not match the organizationName used when the [WindowsUpdateAdministrator](./windowsupdateadministrator.md) was registered.

## -see-also

## -examples
